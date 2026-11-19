using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    [SerializeField] private Transform _groundTransform;
    [SerializeField] private float _groundRadius = 0.1f;
    [SerializeField] private LayerMask _groundMask;
    [SerializeField] private float _jumpForce = 5f;
    [SerializeField] private float _moveSpeed = 3f;
    private Rigidbody2D _body;

    private void Start()
    {
        _body = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        // Ожидание: если скорость будет = 0, то игрок будет стоять на месте, ничего происходить не будет
        float direction = Input.GetAxisRaw("Horizontal");
        _body.linearVelocity = new Vector2(direction * _moveSpeed, _body.linearVelocityY);

        if (Input.GetKeyDown(KeyCode.Space) && IsGrounded())
        {
            _body.linearVelocity = new Vector2(_body.linearVelocityX, _jumpForce);
        }
    }

    private bool IsGrounded()
    {
        return Physics2D.OverlapCircle(_groundTransform.position, _groundRadius, _groundMask) != null;
    }
}
