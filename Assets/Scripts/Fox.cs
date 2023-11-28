using UnityEngine;

public class Fox : MonoBehaviour
{
    [SerializeField] private Animator _animator;
    [SerializeField] private float _force;

    private Rigidbody2D _rigidbody;

    private void Awake()
    {
        _rigidbody = GetComponent<Rigidbody2D>();
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        _animator.Play("fox_idle");
    }

    private void OnMouseDown()
    {
        _animator.Play("fox_jump");
        _rigidbody.AddForce(Vector2.up * _force);
    }
}
