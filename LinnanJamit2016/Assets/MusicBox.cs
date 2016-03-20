using UnityEngine;
using System.Collections;

public class MusicBox : MonoBehaviour
{
    public AudioClip a, b;
    AudioSource ac;
    // Use this for initialization
    void Start()
    {
        ac = GetComponent<AudioSource>();


        if(GameManager.Instance != null)
        {

            GameManager.Instance.mb = this;
            PlayMusic(a);

        }
        else
        {
            Invoke("Start", 1);
        }
    }


    public void PlayMusic(AudioClip _ac)
    {
        ac.clip = _ac;
        ac.Play();
    }

    void Update()
    {

    }
}
