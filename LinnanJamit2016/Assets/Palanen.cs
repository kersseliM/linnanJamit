using UnityEngine;
using System.Collections;

public class Palanen : MonoBehaviour
{
    public int score = 10;


    void OnCollisionEnter()
    {
        GameManager.Instance.AddScore(score);
    }


}
