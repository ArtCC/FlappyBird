using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleGenerator : MonoBehaviour {

    public float maxTime = 2;
    public GameObject obstacle;
    public float height;
    
    private float initialTime = 0;

    // Start is called before the first frame update
    void Start() {
        generateObstacle(0, 0);
    }

    // Update is called once per frame
    void Update() {
        if (initialTime > maxTime) {
            generateObstacle(-height, height);
        } else {
            initialTime += Time.deltaTime;
        }
    }

    private void generateObstacle(float x, float y) {
        GameObject newObstacle = Instantiate(obstacle);
        newObstacle.transform.position = transform.position + new Vector3(0, Random.Range(x, y), 0);
        Destroy(newObstacle, 5);
        
        initialTime = 0;
    }
}
