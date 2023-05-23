using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] private float jumpForce;

    private Rigidbody2D _rigidbody;

    void Start()
    {
        _rigidbody = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            _rigidbody.AddForce(Vector2.up * jumpForce, ForceMode2D.Impulse);
        }
    }
}