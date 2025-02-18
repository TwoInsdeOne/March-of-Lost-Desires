using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DesireFlower : MonoBehaviour
{
    public string content;
    public int id;
    public Animator ani;

    public void Realize()
    {
        ani.SetTrigger("realize");
        Destroy(gameObject, 2f);
    }
}
