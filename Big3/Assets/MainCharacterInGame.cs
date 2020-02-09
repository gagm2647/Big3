using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainCharacterInGame : MonoBehaviour
{
    public float speed = 50f;
    private float moveInput;
    private float swingForce = 150f;
    private int swingLeft;

    public Skins skin;

    public bool isGrounded;
    public Transform groundCheck;
    public float checkRadius;
    public LayerMask whatIsGround;

    private Rigidbody2D rb;

    // Start is called before the first frame update
    void Start()
    {
        rb = gameObject.GetComponent<Rigidbody2D>();
        swingLeft = skin.totalSwing;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && !isGrounded && swingLeft > 0)
        {
            rb.velocity = Vector2.up * swingForce;
            swingLeft--;
        }
    }

    private void FixedUpdate()
    {
        isGrounded = Physics2D.OverlapCircle(groundCheck.position, checkRadius, whatIsGround);

        moveInput = Input.GetAxis("Horizontal");
        rb.velocity = new Vector2(speed * moveInput, rb.velocity.y);
    }

}
