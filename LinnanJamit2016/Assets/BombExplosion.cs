using UnityEngine;
using System.Collections;
using UnityEngine.VR;

public class BombExplosion : MonoBehaviour
{
    public AudioClip explosion;
    private AudioSource source;

    SphereCollider bc;
    bool isExpanding;
    float radius;
    public float maxRadius;
    public float expandSpeed;
    public float ExplosionForce = 10;
    // Use this for initialization

    void Awake()
    {
        source = GetComponent<AudioSource>();

        bc = GetComponent<SphereCollider>();
        maxRadius = bc.radius;
    }

    // Update is called once per frame
    void Update()
    {
        if (isExpanding)
        {
            radius += Time.deltaTime * expandSpeed;

            float percentage = radius / maxRadius;

            bc.radius = Mathf.Lerp(0, maxRadius, percentage);

            if (percentage >= 1)
            {
                isExpanding = false;
                bc.enabled = false;
                gameObject.SetActive(false);
            }
        }
    }
    public void Explode()
    {
        isExpanding = true;
        bc.enabled = true;
        GetComponent<MeshRenderer>().enabled = false;

        source.PlayOneShot(explosion);
    }

    void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.GetComponent<Rigidbody>() != null)
        {
            AddForce(col.GetComponent<Rigidbody>());
        }
    }
    void AddForce(Rigidbody rb)
    {
        rb.isKinematic = false;
        Vector3 direction = rb.position - transform.position;
        direction = direction * ExplosionForce;
        rb.AddForce(direction, ForceMode.Impulse);

        if (rb.GetComponent<BasePamahtavaObjecti>() != null)
        {
            rb.gameObject.SetActive(false);
            rb.GetComponent<BoxCollider>().enabled = false;
            BasePamahtavaObjecti bs = rb.GetComponent<BasePamahtavaObjecti>();
            ExplosionManager.Instance.AddExplosion(bs.transform.position, bs.radius, bs.explosionForce);
        }
    }
}

