using UnityEngine;
using System.Collections;

public class Bomb : MonoBehaviour
{

    SphereCollider bc;
    bool isExpanding;
    float radius;
    float maxRadius;
    public float expandSpeed;
    public float ExplosionForce = 10;
    // Use this for initialization

    void Start()
    {
        bc = GetComponent<SphereCollider>();
        maxRadius = bc.radius;
        
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKeyDown(KeyCode.Space))
        {
            Explode();
        }


        if(isExpanding)
        {

            radius += Time.deltaTime * expandSpeed;

            float percentage = radius / maxRadius;

            bc.radius = Mathf.Lerp(0, maxRadius, percentage);

            if(percentage >=1)
            {
                isExpanding = false;
                bc.enabled = false;

            }
        }


    }


    private void Explode()
    {
        isExpanding = true;
        bc.enabled = true;
        GetComponent<MeshRenderer>().enabled = false;
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
    }


}

