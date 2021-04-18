using UnityEngine;

public enum EndPortalTypes {
PLAYER,
ENEMY
}

public class EndPortal : MonoBehaviour {
    public EndPortalTypes type;

    void OnTriggerEnter2D(Collider2D other) {
        if (type == EndPortalTypes.ENEMY) {
            if (other.CompareTag("Enemy")) {
                FindObjectOfType<GameManager>().ENEMY_REACHED_PORTAL = true;
            } else {
                return;
            }
        } else if (type == EndPortalTypes.PLAYER) {
            if (other.CompareTag("Player")) {
                FindObjectOfType<GameManager>().PLAYER_REACHED_PORTAL = true;
            } else {
                return;
            }
        }
    }
    void OnTriggerExit2D(Collider2D other) {
        if (type == EndPortalTypes.ENEMY) {
            if (other.CompareTag("Enemy")) {
                FindObjectOfType<GameManager>().ENEMY_REACHED_PORTAL = false;
            } else {
                return;
            }
        } else if (type == EndPortalTypes.PLAYER) {
            if (other.CompareTag("Player")) {
                FindObjectOfType<GameManager>().PLAYER_REACHED_PORTAL = false;
            } else {
                return;
            }
        }
    }
}