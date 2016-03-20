using UnityEngine;
using System.Collections;

public class ExplosionManager : MonoBehaviour
{
    public static ExplosionManager Instance;
    public GameObject Explosion;
   public bool firstExplo;
    float timer;
    public float endWaitTime = 5;
    AudioSource ac;
    bool Once;

    void Awake()
    {

        if (Instance == null)
        {
            Instance = this;

            DontDestroyOnLoad(gameObject);
        }
        ac = GetComponent<AudioSource>();
    }

    void Update()
    {


        if (Input.GetButtonDown("Xplode"))
        {
            ac.Play();
        }




        if (firstExplo)
        {
            timer += Time.deltaTime;
            if (timer > endWaitTime)
            {
                if (!Once)
                {
                    Once = true;
                    GameManager.Instance.GameOver();
                }
            }

        }

    }


    public void AddExplosion(Vector3 pos, float radius, float force)
    {

        if(!firstExplo)
        {
            firstExplo = true;
            GameManager.Instance.mb.PlayMusic(GameManager.Instance.mb.b);
        }
        timer = 0;
        GameObject g = Instantiate(Explosion, pos, Quaternion.identity) as GameObject;
        BombExplosion b = g.GetComponent<BombExplosion>();
        b.maxRadius = radius;
        b.ExplosionForce = force;
        b.Explode();
    }
}


