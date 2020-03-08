using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainCharacterInGame : MonoBehaviour
{
    public float speed = 500f;
    public float normalSpeed = 500f;
    public int speedCooldown = 2;
    public float speedBoost = 5000f;
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

    private void TouchingYBoost()
    {
        rb.velocity = Vector2.up * swingForce * skin.powerEfficiency;
    }

    private void TouchingXBoost()
    {
        speed = speedBoost;
    }



    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("XBoost"))
        {
            Destroy(collision.gameObject);
            TouchingXBoost();
            StartCoroutine("SpeedDuration");
        }

        if (collision.CompareTag("YBoost"))
        {
            Destroy(collision.gameObject);
            TouchingYBoost();
        }
    }

    IEnumerator SpeedDuration()
    {
        yield return new WaitForSeconds(speedCooldown);
        speed = normalSpeed;
    }


}
