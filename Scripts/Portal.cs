using UnityEngine;

public class Portal : MonoBehaviour {
    public float BulletSpeed = 2f;
    public Vector2 dir;

    [SerializeField] private Transform OtherPortalExit;
    [SerializeField] private Portal OtherPortalScript;

    public void SetRBToDir(Rigidbody2D rb) {
        if (rb != null) {
            rb.velocity = Vector2.zero;
            rb.AddForce(dir * BulletSpeed, ForceMode2D.Impulse);
        }
    }

    private void OnTriggerEnter2D(Collider2D hitInfo) {
        Bullet bullet = hitInfo.GetComponent<Bullet>();

        if (bullet != null) {
            OtherPortalScript.SetRBToDir(bullet.GetComponent<Rigidbody2D>());
            bullet.GetComponent<Rigidbody2D>().position = OtherPortalExit.position;
        }
    }
}
