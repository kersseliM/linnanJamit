using UnityEngine;
using System.Collections;

public class RealBomb : MonoBehaviour
{


    public float radius = 5;
    public float force = 10;
    public float timeToBoom=2;
    float timer;


    bool isDetonadet;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetButtonDown("Xplode"))
        {
            Explode();
        }




        if(isDetonadet)
        {

            timer+= Time.deltaTime;

            if(timer > timeToBoom)
            {
                Explode();
            }


        }

    }

    public void Denotate()
    {
        isDetonadet = true;
    }

    void Explode()
    {
        ExplosionManager.Instance.AddExplosion(transform.position, radius, force);
        gameObject.SetActive(false);
    }
}
