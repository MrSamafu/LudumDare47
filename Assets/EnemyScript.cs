using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyScript : MonoBehaviour
{
    private Rigidbody rb;
    private Vector2 initialPosition;
    public float speed;
    private float x;
    public float damage;
    void Start()
    {
        initialPosition = transform.position;
        x = 1;
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.x < initialPosition.x - 2)
        {
            x = -1;
        }
        if (transform.position.x > initialPosition.x + 2)
        {
            x = 1;
        }
        transform.Translate(new Vector2(0, x * speed * Time.deltaTime));
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name == "Player")
        {
            collision.gameObject.GetComponent<PlayerStat>().life -= damage;
        }
    }
}
