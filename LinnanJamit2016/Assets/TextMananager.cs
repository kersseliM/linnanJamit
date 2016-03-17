using UnityEngine;
using System.Collections;

public class TextMananager : MonoBehaviour
{

    public GameObject Text;
    public Transform t;
    // Use this for initialization
    void Start()
    {
    }


    public void MakeText(Vector3 pos, int Score)
    {
        GameObject g = Instantiate(Text, pos, Text.transform.rotation) as GameObject;
        g.GetComponent<Text_Effect>().SetText(Score.ToString());
        g.transform.LookAt(t.position+t.forward *100);
    }

}
