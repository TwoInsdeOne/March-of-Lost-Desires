using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RealityGate : MonoBehaviour
{
    public DesireCollector collector;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "desire flower")
        {
            int id = collision.gameObject.GetComponent<DesireFlower>().id;
            collector.FindDesire(id);
            collector.RemoveDistantJoint(id);
            collision.GetComponent<DesireFlower>().Realize();
        }
    }
}
