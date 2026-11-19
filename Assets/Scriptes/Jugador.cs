using UnityEngine;
using UnityEngine.InputSystem;

public class Jugador : MonoBehaviour
{

    public float speed = 5f;

    private Rigidbody rb;

    private void Awake()
    {

        rb = GetComponent<Rigidbody>();
        
    }

    private void FixedUpdate()

    {
        Keyboard keyboard = Keyboard.current;
        if (keyboard == null)
        {
            return;
        }

        float moveHorizontal = 0f;
        float moveVertical = 0f;

        if (keyboard.aKey.isPressed || keyboard.leftArrowKey.isPressed)
            moveHorizontal -= 1f;
        if (keyboard.dKey.isPressed || keyboard.rightArrowKey.isPressed)
            moveHorizontal += 1f;
        if (keyboard.sKey.isPressed || keyboard.downArrowKey.isPressed)
            moveVertical -= 1f;
        if (keyboard.wKey.isPressed || keyboard.upArrowKey.isPressed)
            moveVertical += 1f;

        Vector3 movement = new Vector3(moveHorizontal * speed, rb.linearVelocity.y, moveVertical * speed);

        rb.linearVelocity = movement;
    }

}