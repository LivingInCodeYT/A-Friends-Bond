using UnityEngine;

public class MoveCam : MonoBehaviour {

    void OnTriggerEnter2D(Collider2D other) {
        if (other.CompareTag("Player") || other.CompareTag("Enemy")) {
            MoveCamera();
        }
    }
    void MoveCamera() {
        Camera.main.transform.position = transform.position;
    }

}