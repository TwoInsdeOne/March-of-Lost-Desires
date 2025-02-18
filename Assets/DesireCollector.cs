using System;
using System.Collections.Generic;
using UnityEngine;

[Serializable]
public class Desire
{
    public string content;
    public int id;
    public bool realised;
}

public class DesireCollector : MonoBehaviour
{
    public Rigidbody2D rb;
    public List<Desire> desireFlowers;
    public Dictionary<int, DistanceJoint2D> id_djs;
    private void Start()
    {
        id_djs = new Dictionary<int, DistanceJoint2D>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "desire flower")
        {
            int id = collision.GetComponent<DesireFlower>().id;
            if (id_djs.ContainsKey(id))
            {
                return;
            }
            Desire desire = new Desire();
            desire.content = collision.GetComponent<DesireFlower>().content;
            desire.id = id;
            desireFlowers.Add(desire);

            DistanceJoint2D dj = gameObject.AddComponent<DistanceJoint2D>();
            dj.connectedBody = collision.GetComponent<Rigidbody2D>();
            dj.enableCollision = false;
            dj.distance = UnityEngine.Random.Range(1.0f, 2.0f);

            Debug.Log(desire.id);
            Debug.Log(dj);
            id_djs.Add(desire.id, dj);
        }
    }
    public void FindDesire(int id)
    {
        for (int i = 0; i < desireFlowers.Count; i++)
        {
            if (desireFlowers[i].id == id)
            {
                desireFlowers[i].realised = true;
                return;
            }
        }
    }

    public void RemoveDistantJoint(int id)
    {
        DistanceJoint2D temp_dj;
        bool success = id_djs.Remove(id, out temp_dj);
        Destroy(temp_dj);
    }
}
