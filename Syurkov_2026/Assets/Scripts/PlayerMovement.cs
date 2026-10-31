using Unity.VisualScripting;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{


    public float jumpForce = 5f;
    private bool isGrounded;
    public float moveSpeed = 3f;
    private Rigidbody2D body;

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
            isGrounded = true;
        }
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
            isGrounded = false;
        }
    }


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        body = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        // Ожидание: если скорость будет = 0, то игрок будет стоять на месте, ничего происходить не будет
        float direction = Input.GetAxisRaw("Horizontal");
        body.linearVelocity = new Vector2(direction * moveSpeed, body.linearVelocityY);

        if (Input.GetKeyDown(KeyCode.Space) && isGrounded)
        {
            body.linearVelocity = new Vector2(body.linearVelocityX, jumpForce);
        }
    }
}
