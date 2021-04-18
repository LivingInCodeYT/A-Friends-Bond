using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelLoader : MonoBehaviour {
    public Animator anim;
    public float animTime = 1f;

    public void LoadNextLevel() {
        Debug.Log(SceneManager.GetActiveScene().buildIndex + 1);
        StartCoroutine(_LoadALevel(SceneManager.GetActiveScene().buildIndex + 1));
    }
    public void LoadLevel(int index) {
        StartCoroutine(_LoadALevel(index));
    }

    IEnumerator _LoadALevel(int index) {
        anim.SetTrigger("CircleTrans");
        anim.ResetTrigger("CircleTrans");
        yield return new WaitForSeconds(animTime);
        SceneManager.LoadScene(index);
    }

}