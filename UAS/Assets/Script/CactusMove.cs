using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CactusMove : MonoBehaviour
{
    // Start is called before the first frame update
    public Vector2 veloc = new Vector2(-4, 0);
    void Start()
    {
        GetComponent<Rigidbody2D>().velocity = veloc;
        float range = Random.Range(1,5);
        if (Random.Range(1,10) >= 5 ) {
            transform.position = new Vector3(transform.position.x, -3, transform.position.z);

        } else {
            transform.position = new Vector3(transform.position.x, -3, transform.position.z);
        }
    }

    // Update is called once per frame
    void Update()
    {
        veloc = new Vector2(Random.Range(-20,-10), 0);
        GetComponent<Rigidbody2D>().velocity = veloc;
    }
}
