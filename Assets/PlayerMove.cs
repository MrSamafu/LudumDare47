using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
	public bool isGrounded;
	public float playerSpeed = 5.0f;
	public float jumpHeight = 1.0f;


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
		float moveDir = Input.GetAxis("Horizontal") * playerSpeed;
		rb.velocity = new Vector2(moveDir, rb.velocity.y);

		// Your jump code:
		if (Input.GetKeyDown(KeyCode.Space) && isGrounded)
		{
			rb.velocity = new Vector2(rb.velocity.x, jumpHeight);
		}
		if (rb.velocity.x != 0)
        {
			anim.SetBool("run", true);
			if (rb.velocity.x < 0)
            {
				spriteRenderer.flipX = true;
			}
			if(rb.velocity.x > 0)
            {
				spriteRenderer.flipX = false;
			}
		}
		if (rb.velocity.x == 0)
        {
			anim.SetBool("run", false);
		}
		anim.SetBool("isGrounded", isGrounded);
	}
}
