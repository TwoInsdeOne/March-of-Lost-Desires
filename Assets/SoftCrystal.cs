using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.U2D;

public class SoftCrystal : MonoBehaviour
{
    public SpriteShapeRenderer ssr;
    public PolygonCollider2D pc;
    public GameObject destroyFX;
    public bool destroyed;
    public SpriteRenderer sr;
    public Animator ani;
    private void Start()
    {
        sr.color = new Color(0, 0, 0, 0);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "blast" && !destroyed) {
            GameObject o = Instantiate(destroyFX);
            o.transform.parent = transform;
            o.transform.localPosition = Vector3.zero;
            ParticleSystem.MainModule mm = o.GetComponent<ParticleSystem>().main;
            ParticleSystem.MinMaxGradient mmg = mm.startColor;
            mmg = ssr.color;
            mm.startColor = mmg;
            ani.SetTrigger("Destroy");
            Destroy(pc);
            Destroy(gameObject, 1.5f);
            destroyed = true;
        }
    }
}
