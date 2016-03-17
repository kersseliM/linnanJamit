using UnityEngine;
using System.Collections;

public class Text_Effect : MonoBehaviour
{
    TextMesh textMEsh;
    Vector3 posToLerp;
    Vector3 startPos;
    float timeToLERP = 1;
    float timer;

    // Use this for initialization
    void Awake()
    {
        textMEsh = GetComponent<TextMesh>();
        SetText("tedsad");
    }


    public void SetText(string _text)
    {
        textMEsh.text = _text;
        lerp = true;
        posToLerp = transform.position + Vector3.up*2;
        startPos = transform.position;
    
    }


    void Update()
    {

        if(lerp)
        {
            timer +=Time.deltaTime;

            float percentage = timer / timeToLERP;
            transform.position = Vector3.Lerp(startPos, posToLerp, percentage);
            if(percentage>= 1)
            {
                gameObject.SetActive(false);
            }
        }
    }


    bool lerp = false;


}
