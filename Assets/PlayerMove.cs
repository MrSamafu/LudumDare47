using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
	public bool isGrounded;
	private float playerSpeed;
	private float jumpHeight;



	private Rigidbody rb;

	private PlayerStat playerStat;
	private SpriteRenderer spriteRenderer;
	private Animator anim;
	private AudioSource audioSource;
	public AudioClip jumpSound;

	void Start()
    {
		rb = GetComponent<Rigidbody>();
		spriteRenderer = GetComponent<SpriteRenderer>();
		anim = GetComponent<Animator>();
		playerStat = GetComponent<PlayerStat>();
		playerSpeed = playerStat.speed;
		jumpHeight = playerStat.jumpForce;
		audioSource = GetComponent<AudioSource>();
    }

	void Update()
	{
		float moveDir = Input.GetAxis("Horizontal") * playerSpeed;
		rb.velocity = new Vector2(moveDir, rb.velocity.y);

		// Your jump code:
		if (Input.GetKeyDown(KeyCode.Space) && isGrounded)
		{
			rb.velocity = new Vector2(rb.velocity.x, jumpHeight);
			audioSource.PlayOneShot(jumpSound);
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
