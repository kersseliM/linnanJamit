using UnityEngine;
using System.Collections;

public class RealBomb : MonoBehaviour 
{


    float radius = 5;
    float force = 10;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () 
    {

        if (Input.GetKeyDown(KeyCode.Space))
        {
            Explode();
        }


	}



    void Explode()
    {
       ExplosionManager.Instance.AddExplosion(transform.position,radius,force);
    }
}
