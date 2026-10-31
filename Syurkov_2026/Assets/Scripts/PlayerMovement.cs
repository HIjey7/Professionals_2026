using UnityEngine;

public class PlayerMovement : MonoBehaviour
{


    public float moveSpeed = 3f;
    private Rigidbody2D body;
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
    }
}
