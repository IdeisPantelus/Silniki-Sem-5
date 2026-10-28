using UnityEngine;
using UnityEngine.InputSystem;

public class Input_debugged : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnJUMP()
    {
        Debug.Log("Jump");
    }
    void OnMove(InputValue Value)
    {
        Debug.Log(Value.Get<Vector2>());
    }


}
