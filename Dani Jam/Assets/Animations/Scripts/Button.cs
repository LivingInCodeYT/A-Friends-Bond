using UnityEngine;
using UnityEngine.Events;

public class Button : MonoBehaviour {
    public UnityEvent onPress;
    public UnityEvent onUnPress;
    private Animator anim;

    void Start() {
        anim = GetComponent<Animator>();
    }

    void OnTriggerEnter2D(Collider2D other) {
        if (other.CompareTag("Player") || other.CompareTag("Enemy")) {
            anim.SetBool("isPressed", true);
            onPress.Invoke();
        }
    }
    void OnTriggerExit2D(Collider2D other) {
        if (other.CompareTag("Player") || other.CompareTag("Enemy")) {
            anim.SetBool("isPressed", false);
            onUnPress.Invoke();
        }
    }
}