using UnityEngine;

public class InputToMove : MonoBehaviour {
    private Rigidbody2D rb;

    private float hMove;

    public float moveSpeed;
    public float jumpForce;

    public bool isGrounded;
    public Transform groundCheck;
    public float checkRad = 0.3f;
    public LayerMask whatIsGround;
    public int extraJumps = 2;
    private int extraJumpCount = 2;

    void Start() {
        rb = GetComponent<Rigidbody2D>();
    }
    void Update() {
        hMove = Input.GetAxisRaw("Horizontal") * moveSpeed;
        isGrounded = Physics2D.OverlapCircle(groundCheck.position, checkRad, whatIsGround);
        if (Input.GetKeyDown(KeyCode.Space)) {
                Jump();
        }
        if (hMove > 0) {
            // Right Key Pressed
            GetComponent<SpriteRenderer>().flipX = true;
        } else if (hMove < 0) {
            // Left Key Pressed
            GetComponent<SpriteRenderer>().flipX = false;
        }
    }
    void FixedUpdate() {
        rb.velocity = new Vector2(hMove, rb.velocity.y);
    }
    void Jump() {
        if (isGrounded) {
            rb.velocity = new Vector2(rb.velocity.x, jumpForce);
            extraJumpCount = extraJumps;
        } else {
            if (extraJumpCount > 0) {
                rb.velocity = new Vector2(rb.velocity.x, jumpForce);
                extraJumpCount--;
            }
        }
    }
}