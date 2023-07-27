using UnityEngine;

public class Enemy : MonoBehaviour {
    public int health = 5;
    public GameObject EnemyDeathEffect;

    [HideInInspector] public Rigidbody2D rb;

    private void Start() {
        rb = GetComponent<Rigidbody2D>();
    }

    public void TakeDamage(int damage) {
        health -= damage;

        if (health >= 0) {
            Instantiate(EnemyDeathEffect);
            Destroy(gameObject);
        }
    }
}
