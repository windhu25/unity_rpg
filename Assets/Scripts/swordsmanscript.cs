using UnityEngine;
using UnityEngine.InputSystem;

public class swordsman : MonoBehaviour
{
    public float speed = 5f;              // Kecepatan gerak
    public Rigidbody2D rb;                // Referensi ke Rigidbody2D pemain
    private Vector2 moveInput;            // Menyimpan input per frame

    void Update()
    {
        // Baca input dari keyboard
        float moveX = 0;
        float moveY = 0;

        if (Keyboard.current.aKey.isPressed) moveX = -1;
        if (Keyboard.current.dKey.isPressed) moveX = 1;
        if (Keyboard.current.wKey.isPressed) moveY = 1;
        if (Keyboard.current.sKey.isPressed) moveY = -1;

        moveInput = new Vector2(moveX, moveY).normalized;
    }

    void FixedUpdate()
    {
        // Gerakkan pemain dengan Rigidbody2D
        rb.linearVelocity = moveInput * speed;
    }
}
