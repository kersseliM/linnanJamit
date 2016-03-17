using UnityEngine;
using System.Collections;

public class Text_Effect : MonoBehaviour
{
    TextMesh textMEsh;


    // Use this for initialization
    void Awake()
    {
        textMEsh = GetComponent<TextMesh>();
    }


    public void SetText(string _text)
    {
        textMEsh.text = _text;
    }

}
