using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {

    public float velocity;
    public SceneController sceneController;

    private Rigidbody2D rigibody;

    // Start is called before the first frame update
    void Start() {
        rigibody = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update() {
        if (Input.GetMouseButtonDown(0)){
            rigibody.velocity = Vector2.up * velocity;
        }
    }

    private void OnCollisionEnter2D(Collision2D other) {    
        sceneController.lostGame();
    }
}
