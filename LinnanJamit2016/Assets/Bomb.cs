using UnityEngine;
using System.Collections;

public class Bomb : MonoBehaviour
{

    BoxCollider bc;
    // Use this for initialization
    void Start()
    {
        bc = GetComponent<BoxCollider>();
    }

    // Update is called once per frame
    void Update()
    {


        if (Input.GetKeyDown(KeyCode.Space))
        {

            Explode();

        }
    }

    private void Explode()
    {
        bc.enabled = true;
    }
}
