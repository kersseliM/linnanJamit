using UnityEngine;
using System.Collections;

public class CellMaster : MonoBehaviour
{
    public GameObject main, pieces;

    void Start()
    {
        pieces.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            Active();
        }

    }



    void Active()
    {
        main.SetActive(false);
        pieces.SetActive(true);
    }

}
