using UnityEngine;
using System.Collections;

public class TextMananager : MonoBehaviour 
{

    public GameObject Text;

	// Use this for initialization
	void Start ()
    {
	}


 public void  MakeText(Vector3 pos,int Score)
    {
        GameObject g = Instantiate(Text, pos, Text.transform.rotation) as GameObject;
        g.GetComponent<Text_Effect>().SetText(Score.ToString());
    }

}
