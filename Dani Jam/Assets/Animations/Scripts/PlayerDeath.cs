using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerDeath : MonoBehaviour {

    void OnTriggerEnter2D(Collider2D other) {
        if (other.CompareTag("Death")) {
            FindObjectOfType<LevelLoader>().LoadLevel(SceneManager.GetActiveScene().buildIndex);
        }
    }
}