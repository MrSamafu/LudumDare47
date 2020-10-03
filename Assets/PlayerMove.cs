using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
	public float speed;
	public float jumpForce;
	public bool isGrounded;

	private Rigidbody rb;
	private SpriteRenderer spriteRenderer;
	private Animator anim;

	void Start()
    {
		rb = GetComponent<Rigidbody>();
		spriteRenderer = GetComponent<SpriteRenderer>();
		anim = GetComponent<Animator>();
    }

	void Update()
	{

		Vector3 dp = new Vector3();

		if (Input.GetKey(KeyCode.Q))
		{
			rb.AddForce(Vector3.left * speed * Time.deltaTime);
			spriteRenderer.flipX = true;
			anim.SetBool("run",true);
		}

		if (Input.GetKeyUp(KeyCode.Q)){
			anim.SetBool("run", false);
		}

		if (Input.GetKey(KeyCode.D))
		{
			rb.AddForce(Vector3.right * speed * Time.deltaTime);
			spriteRenderer.flipX = false;
			anim.SetBool("run",true);
		}

		if (Input.GetKeyUp(KeyCode.D)){
			anim.SetBool("run", false);
		}
		if (Input.GetKeyDown(KeyCode.Space) && isGrounded)
        {
			rb.AddForce(Vector3.up * jumpForce * Time.deltaTime, ForceMode.Impulse);
			
        }
		anim.SetBool("isGrounded", isGrounded);
		transform.position += dp;
	}
}
