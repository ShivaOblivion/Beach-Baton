using System.Collections;
using UnityEngine;

public class playmove : MonoBehaviour
{
    [Header("Movements")]
    public float moveSpeed;
    private Vector3 velocity = Vector3.zero;
    [Header("Jump")]
    public float CooldownJump = 5.0f;
    private float TimeSinceJump = 6.0f;
    public float distanceCheckGrounded = 0.5f;
    public float jumpForce;
    public LayerMask groundLayer;
    [Header("Refs")]
    private Rigidbody2D rb;
    private BoxCollider2D box2D;





    private void Start()
    {
        box2D = GetComponent<BoxCollider2D>();
        rb = GetComponent<Rigidbody2D>();
    }

    void FixedUpdate()
    {
        float horizontalMovement = Input.GetAxis("Horizontal") * moveSpeed * Time.deltaTime;
        MovePlayer(horizontalMovement);
    }

    private void Update()
    {
        TimeSinceJump += Time.deltaTime;
        if (Input.GetButtonDown("Jump") && IsGrounded() && TimeSinceJump > CooldownJump)
        {
            rb.AddForce(new Vector2(0f, jumpForce));
            TimeSinceJump = 0.0f;
        }
    }


    private bool IsGrounded()
    {
        Vector2 position = transform.position;
        Vector2 direction = Vector2.down;
        RaycastHit2D hit = Physics2D.Raycast(position, direction, distanceCheckGrounded, groundLayer);
        if (hit.collider != null)
        {
            return true;
        }
        return false;
    }


    void MovePlayer(float _horizontalMovement)
    {
        Vector3 targetVelocity = new Vector2(_horizontalMovement, rb.velocity.y);
        rb.velocity = Vector3.SmoothDamp(rb.velocity, targetVelocity, ref velocity, .05f);

    }

}