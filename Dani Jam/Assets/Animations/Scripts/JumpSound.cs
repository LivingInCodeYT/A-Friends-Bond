using UnityEngine;

public class JumpSound : MonoBehaviour {
    private InputToMove move;

    void Update() {
        if (Input.GetKeyDown(KeyCode.Space)) {
            if (move.isGrounded) {
                FindObjectOfType<SFXManager>().Play("Jump");
            }
        }
    }

}