using UnityEngine;

public class Door : MonoBehaviour {
    private Animator anim;
    private Collider2D _collider;

    void Start() {
        _collider = GetComponent<Collider2D>();
        anim = GetComponent<Animator>();
    }

    public void OpenDoor() {
        anim.SetTrigger("Fade");
        _collider.enabled = false;
    }
    public void CloseDoor() {
        anim.SetTrigger("Unfade");
        _collider.enabled = true;
    }
}