using UnityEngine;


public class PlayerMovement : MonoBehaviour
{
    public float speed = 6f;
    public float jumpForce = 12f;
    public Transform groundCheck;
    public LayerMask groundLayer;


    Rigidbody2D rb;
    bool grounded;


    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }


    void Update()
    {
        float x = Input.GetAxis("Horizontal");
        rb.velocity = new Vector2(x * speed, rb.velocity.y);


        grounded = Physics2D.OverlapCircle(groundCheck.position, 0.2f, groundLayer);


        if ((Input.GetKeyDown(KeyCode.Space) || Input.GetMouseButtonDown(0)) && grounded)
            rb.velocity = new Vector2(rb.velocity.x, jumpForce);
    }
}