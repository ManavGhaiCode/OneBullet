using UnityEngine;

public class Bullet : MonoBehaviour {
    public int Damage = 5;

    private void OnTriggerEnter2D(Collider2D hitInfo) {
        Enemy enemy = hitInfo.GetComponent<Enemy>();

        if (enemy != null) {
            enemy.TakeDamage(Damage);
        }
    }
}
