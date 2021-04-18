using UnityEngine;

public class MovingPlatform : MonoBehaviour {
    public GameObject[] wayPoints;
    private int wayPointIndex;

    public float moveSpeed;

    void Update() {
        if (transform.position == wayPoints[wayPointIndex].transform.position) {
            wayPointIndex++;
        }
        if (wayPointIndex == wayPoints.Length) {
            wayPointIndex = 0;
        }
        transform.position = Vector2.MoveTowards(transform.position, wayPoints[wayPointIndex].transform.position, moveSpeed);
    }
    void OnTriggerEnter2D(Collider2D other) {
        if (other.CompareTag("Player1") || other.CompareTag("Enemy")) {
            other.GetComponent<Rigidbody2D>().position = transform.position;
        }   
    }
}