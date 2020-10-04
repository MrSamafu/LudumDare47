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
    public AudioClip damageSound;
    void Start()
    {
        initialPosition = transform.position;
        x = 1;
        StartCoroutine(jump());
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.x < initialPosition.x - 2)
        {
            x = 1;
            GetComponent<SpriteRenderer>().flipX = false;
        }
        if (transform.position.x > initialPosition.x + 2)
        {
            x = -1;
            GetComponent<SpriteRenderer>().flipX = true;
        }
        transform.Translate(new Vector2(x * speed * Time.deltaTime, 0 ));
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name == "Player")
        {
            collision.gameObject.GetComponent<PlayerStat>().life -= damage;
            GetComponentInChildren<AudioSource>().PlayOneShot(damageSound);
        }
    }
    IEnumerator jump()
    {
        float time = Random.Range(1f, 5f);
        yield return new WaitForSeconds(time);
        GetComponent<Rigidbody>().AddForce(Vector3.up * 5, ForceMode.Impulse);
        StartCoroutine(jump());
    }
}
