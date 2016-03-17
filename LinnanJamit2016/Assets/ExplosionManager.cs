using UnityEngine;
using System.Collections;

public class ExplosionManager : MonoBehaviour
{
    public static ExplosionManager Instance;
    public GameObject Explosion;


    void Awake()
    {

        if (Instance == null)
        {
            Instance = this;

            DontDestroyOnLoad(gameObject);

        }
    }

    public void AddExplosion(Vector3 pos, float radius, float force)
    {
        GameObject g = Instantiate(Explosion, pos, Quaternion.identity) as GameObject;
        BombExplosion b = g.GetComponent<BombExplosion>();
        b.maxRadius = radius;
        b.ExplosionForce = force;
        b.Explode();
    }
}
