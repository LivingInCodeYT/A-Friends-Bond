using UnityEngine;

public class GameManager : MonoBehaviour {
    public bool PLAYER_REACHED_PORTAL;
    public bool ENEMY_REACHED_PORTAL;
    public Color lineColor;
    private Transform player1;
    private Transform player2;
    private LineRenderer lR;

    void Start() {
        player1 = GameObject.FindGameObjectWithTag("Player").transform;
        player2 = GameObject.FindGameObjectWithTag("Enemy").transform;
        lR = GetComponent<LineRenderer>();
    }
    void Update() {
        lR.SetPosition(0, player1.position);
        lR.SetPosition(1, player2.position);
        lR.startColor = lineColor;
        lR.endColor = lineColor;
        if (PLAYER_REACHED_PORTAL && ENEMY_REACHED_PORTAL) {
            FindObjectOfType<LevelLoader>().LoadNextLevel();
            Debug.Log("Next Level!");
            Destroy(gameObject);
        }
    }

}