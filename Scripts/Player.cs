using UnityEngine;

public class Player : MonoBehaviour {
    public float speed = 5f;
    public float BulletSpeed = 2f;

    private float moveInput = 0;
    private Rigidbody2D rb;

    [SerializeField] private GameObject BulletPerfab;
    [SerializeField] private Transform FirePoint;

    private void Start() {
        rb = GetComponent<Rigidbody2D>();
    }

    private void Update() {
        moveInput = Input.GetAxisRaw("Horizontal");
    }

    private void FixedUpdate() {
        float Force = moveInput * speed * Time.fixedDeltaTime;
        rb.MovePosition(rb.position + new Vector2 (Force, 0));

        if (Input.GetKey(KeyCode.Space)) {
            GameObject Bullet = Instantiate(BulletPerfab, FirePoint.position, FirePoint.rotation);
            Bullet.GetComponent<Rigidbody2D>().AddForce(Vector2.up * BulletSpeed, ForceMode2D.Impulse);
        }
    }
}
