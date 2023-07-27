using UnityEngine;

public class Player : MonoBehaviour {
    public float speed = 5f;

    private float moveInput = 0;
    private Rigidbody2D rb;

    private void Start() {
        rb = GetComponent<Rigidbody2D>();
    }

    private void Update() {
        moveInput = Input.GetAxisRaw("Horizontal");
    }

    private void FixedUpdate() {
        float Force = moveInput * speed * Time.fixedDeltaTime;
        rb.MovePosition(rb.position + new Vector2 (Force, 0));
    }
}
