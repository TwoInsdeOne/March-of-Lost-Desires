using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEditor.Rendering;
using UnityEngine;

public class RealityGate : MonoBehaviour
{
    public DesireCollector collector;
    public float attractionSpeed;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "desire flower")
        {
            int id = collision.gameObject.GetComponent<DesireFlower>().id;
            collector.FindDesire(id);
            collector.RemoveDistantJoint(id);
            collision.GetComponent<DesireFlower>().Realize();
            Rigidbody2D rb = collision.GetComponent<Rigidbody2D>();
            Vector2 direction = new Vector2(transform.position.x - collision.transform.position.x, transform.position.y - collision.transform.position.y);
            
            rb.AddForce(direction.normalized * attractionSpeed, ForceMode2D.Impulse);
        }
    }
}
