using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class Obstacle : MonoBehaviour {

    public float velocity;

    // Update is called once per frame
    void Update() {
        transform.position += Vector3.left * velocity * Time.deltaTime;
    }
}
