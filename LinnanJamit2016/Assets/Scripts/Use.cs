using UnityEngine;
using System.Collections;

public class Use : MonoBehaviour
{
    public Transform rayPoint;
    public LayerMask check;
    public float rayDistance;


    void Update()
    {
        if(Input.GetButtonUp("Xplode"))
        {
            RaycastHit hit;
            if (Physics.Raycast(rayPoint.position, rayPoint.forward, out hit, rayDistance, check))
            {
                if(hit.collider.gameObject.tag == "Bomb")
                {
                    // active xplosion
                    print("RÄJÄHTI!");
                }
            }
        }
    }
}
