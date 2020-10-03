using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
	public float speed = 0.18f;
	public float jumpForce = 4.01f;

	private Rigidbody rb;

	void Start()
    {
		rb = GetComponent<Rigidbody>();
    }

	void Update()
	{

		Vector3 dp = new Vector3();

		if (Input.GetKey(KeyCode.Q))
		{
			rb.AddForce(Vector3.left * speed * Time.deltaTime);
		}

		if (Input.GetKey(KeyCode.D))
		{
			rb.AddForce(Vector3.right * speed * Time.deltaTime);
		}

		if (Input.GetKeyDown(KeyCode.Space))
        {
			rb.AddForce(Vector3.up * jumpForce * Time.deltaTime, ForceMode.Impulse);
        }

		transform.position += dp;
	}
}
