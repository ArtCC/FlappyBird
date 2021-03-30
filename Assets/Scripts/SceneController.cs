using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneController : MonoBehaviour {

    public GameObject gameOverCanvas;

    // Start is called before the first frame update
    void Start() {
        Time.timeScale = 1;
    }

    // Update is called once per frame
    void Update() {
    }

    public void startGame() {
        SceneManager.LoadScene("Game");
    }

    public void lostGame() {
        gameOverCanvas.SetActive(true);
        Time.timeScale = 0;
    }
}