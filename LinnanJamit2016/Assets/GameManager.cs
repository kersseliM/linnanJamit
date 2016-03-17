using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{

    public int Score;

  public static  GameManager Instance;
    TextMananager tm;
    public GameObject GameOverCanvas;
    public Text t;
    // Use this for initialization
    void Awake()
    {
        Instance = this;
        tm = GetComponent<TextMananager>();
    }

    // Update is called once per frame
    void Update()
    {

        if(Input.GetButtonUp("Xplode"))
        {
            Application.LoadLevel(Application.loadedLevel);
        }

        if (Input.GetButtonUp("Xplode"))
        {
            if (canExit == true)
            {
                Application.LoadLevel(Application.loadedLevel);
            }
        }

    }

    public void AddScore(int _score,Vector3 pos)
    {
        tm.MakeText(pos, _score);
        Score+=_score;       
    }


    Vector3 vef;
    public void GameOver()
    {
        GameOverCanvas.SetActive(true);
        t.text = Score.ToString();
        vef = GameOverCanvas.transform.position;
        Invoke("i", 2);
    }

    bool canExit;

    void i ()
    {
        canExit = true;
       // GameOverCanvas.transform.parent = null;
       // GameOverCanvas.transform.position = vef;
        GameOverCanvas.gameObject.SetActive(false);
    }

}
