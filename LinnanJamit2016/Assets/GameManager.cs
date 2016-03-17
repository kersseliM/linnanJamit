using UnityEngine;
using System.Collections;

public class GameManager : MonoBehaviour
{

    public int Score;

  public static  GameManager Instance;
    TextMananager tm;
    // Use this for initialization
    void Awake()
    {
        Instance = this;
        tm = GetComponent<TextMananager>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void AddScore(int _score,Vector3 pos)
    {
        tm.MakeText(pos, _score);
        Score+=_score;       
    }


}
