using UnityEngine;
using System.Collections;

public class ExplosiveBarrel : MonoBehaviour {

    public static ExplosionManager Instance;

	void Start () 
    {
	
	}

    void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.GetComponent<Rigidbody>() != null)
        {
           // AddForce(col.GetComponent<Rigidbody>());
        }
    }


	
}
