using System.Collections;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.Audio;

public class Player : MonoBehaviour
{
    private Rigidbody2D _rb;
    private SpriteRenderer _spriteRenderer;
    private PlayerAnimation _anim;
    private PlayerInputActions _playerControls;
    public float moveSpeed = 0.125f;
    public float jumpForce = 8f;
    private Vector2 _moveDirection = Vector2.zero;
    public AudioSource jump;

    private void Awake()
    {
        _playerControls = new PlayerInputActions();
        _anim = GetComponent<PlayerAnimation>();
        _spriteRenderer = GetComponentInChildren<SpriteRenderer>();
        
        _rb = GetComponent<Rigidbody2D>();
    }

    private void OnEnable()
    {
        _playerControls.Player.Enable();
        _playerControls.Player.Jump.performed  += Jump;
    }

    private void OnDisable()
    {
        _playerControls.Player.Disable();
    }

    private void FixedUpdate()
    {
        _moveDirection = _playerControls.Player.Move.ReadValue<Vector2>();
        if (_moveDirection != Vector2.zero) { 
            Move(); 
        }
        _anim.Move(_moveDirection.x);
    }

    private void Move()
    {
        Vector2 currentPosition = transform.position;
        currentPosition.x += _moveDirection.x * moveSpeed;
        transform.position = currentPosition;
        if (_moveDirection.x != 0f)
        {
            Flip();
        }
    }

    private void Flip(){
        _spriteRenderer.flipX = _moveDirection.x < 0;
        
    }
    

    private bool IsGrounded()
    {

        RaycastHit2D hitInfo = Physics2D.Raycast(transform.position, Vector2.down, 0.5f, 1 << 8);
        if (hitInfo.collider != null)
        {
            _anim.Jump(false);
            return true;
        }
        return false;
    }

    private void Jump(InputAction.CallbackContext context)
    {
        if (!IsGrounded()) { return; }
        _rb.AddForce(Vector2.up * jumpForce, ForceMode2D.Impulse);
        _anim.Jump(true);
        jump.Play();
        StartCoroutine(OnJump());
    }

    private IEnumerator OnJump()
    {
        yield return new WaitForSeconds(0.2f);
        _anim.Jump(false);
    }
}




