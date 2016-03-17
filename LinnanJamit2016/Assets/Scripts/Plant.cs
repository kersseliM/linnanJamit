using UnityEngine;
using System.Collections;

public class Plant : MonoBehaviour
{

    public Transform rayPoint;
    public LayerMask check;
    public float rayDistance;
    public GameObject bomby;
    void Update()
    {
        if (Input.GetButtonUp("Pick"))
        {
            RaycastHit hit;
            if (Physics.Raycast(rayPoint.position, rayPoint.forward, out hit, rayDistance, check))
            {
                GameObject newBomb = (GameObject)Instantiate(bomby, hit.point, Quaternion.identity);
            }
        }
    }
}
