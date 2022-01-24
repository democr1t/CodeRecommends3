using UnityEngine;

public class PlayerMover : MonoBehaviour
{
    [SerializeField] private Rigidbody2D _rigidbody2D;
    [SerializeField] private Animator _animator;
    [SerializeField] private SpriteRenderer _spriteRenderer;

    private float _speed;
    private float _jumpForce;
    private float _horizontalInput;
    private const string _isWalking = "IsWalking";

    private void Start()
    {
        _speed = 5;
        _jumpForce = 10;
    }

    private void FixedUpdate()
    {
        GetInput();
        Animate();
        Turn();
    }

    private void GetInput()
    {
        _horizontalInput = Input.GetAxis("Horizontal");
        
        transform.Translate(Vector2.right * _horizontalInput * _speed * Time.deltaTime);
        
        if (Input.GetKeyDown(KeyCode.Space))
        {
            _rigidbody2D.AddForce(Vector2.up * _jumpForce, ForceMode2D.Impulse);
        }
    }

    private void Turn()
    {
        if (_horizontalInput < 0)
        {
            _spriteRenderer.flipX = true;
        }
        else if (_horizontalInput > 0)
        {
            _spriteRenderer.flipX = false;
        }
    }

    private void Animate()
    {
        if (_horizontalInput != 0)
        {
            _animator.SetBool(_isWalking, true);
        }
        else
        {
            _animator.SetBool(_isWalking, false);
        }
    }
}
