using UnityEngine;

public class MovingEnemy : Enemy {
    public float speed = 2.1f;

    public Transform[] movePoints;
    private int CIndex = 0;

    private void Update() {
        if (Vector2.Distance(rb.position, movePoints[CIndex].position) < .05f) {
            if (CIndex == 0) {
                CIndex = 1;
            } else {
                CIndex = 0;
            }
        }

        transform.position = Vector2.MoveTowards(transform.position, movePoints[CIndex].position, Time.deltaTime * speed);
    }
}
