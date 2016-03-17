using UnityEngine;
using System.Collections;

public class Pick : MonoBehaviour
{

    public Transform rayPoint;
    public Transform holdPoint;
    public LayerMask check;
    public LayerMask pickables;
    public float rayDistance;
    public float throwForce = 1f;

    private bool isHolding = false;
    private GameObject heldObject;

    void Update()
    {
        if (Input.GetButtonUp("Pick"))
        {
            if (!isHolding)
            {
                RaycastHit hit;
                if (Physics.Raycast(rayPoint.position, rayPoint.forward, out hit, rayDistance, check))
                {
                    if (((1 << hit.collider.gameObject.layer) & pickables.value) > 0)
                    {
                        heldObject = hit.collider.gameObject;
                        heldObject.transform.parent = holdPoint;
                        heldObject.transform.localRotation = Quaternion.identity;
                        heldObject.transform.localPosition = Vector3.zero;
                        heldObject.GetComponent<Rigidbody>().isKinematic = true;
                        heldObject.GetComponent<Collider>().enabled = false;
                        isHolding = true;
                    }
                }
            }
            else
            {
                heldObject.transform.parent = null;
                heldObject.GetComponent<Collider>().enabled = true;
                heldObject.GetComponent<Rigidbody>().isKinematic = false;
                heldObject.GetComponent<Rigidbody>().AddForce(rayPoint.forward * throwForce, ForceMode.Impulse);
                isHolding = false;
                heldObject = null;
            }
        }
    }
}
