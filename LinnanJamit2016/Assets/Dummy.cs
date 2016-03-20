using UnityEngine;
using System.Collections;

public class Dummy : MonoBehaviour {


    void OnDestroy()
    {

        GameManager.Instance.GameOverCanvas.SetActive(false);
        GameManager.Instance.canExit = false;
        ExplosionManager.Instance.firstExplo = false;
        ExplosionManager.Instance.Once = false;
      
    }

}
