using UnityEngine;
using System.Collections;

public class Dummy : MonoBehaviour {



    void OnDestroy()
    {

        GameManager.Instance.GameOverCanvas.SetActive(false);
        ExplosionManager.Instance.firstExplo = false;


    }

}
