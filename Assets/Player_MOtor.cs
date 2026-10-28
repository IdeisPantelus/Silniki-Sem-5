
using UnityEngine;
using UnityEngine.InputSystem;

public class Player_MOtor : MonoBehaviour
{

    public float Acceleration = 10.0f;
    public float JumpForce = 10.0f;
    private Rigidbody2D rigidbody2D;
    private Vector2 direction;

    void Start()
    {
        rigidbody2D = GetComponent<Rigidbody2D>();
    }

    private void FixedUpdate()                                  //Transforms Input values into movement vector
    {
       
        rigidbody2D.AddForce(new Vector2(direction.x, 0) * Acceleration);
    }

    void OnMove(InputValue value)
    {
        direction = value.Get<Vector2>();
    }

    void OnJUMP()
    {
        
        rigidbody2D.AddForce(Vector2.up * JumpForce,ForceMode2D.Impulse);
    }

}
