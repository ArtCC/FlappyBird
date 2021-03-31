using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PointsArea : MonoBehaviour {

    private void OnTriggerEnter2D(Collider2D other) {
        Points.points++;
    }
}
