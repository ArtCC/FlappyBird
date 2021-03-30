using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Points : MonoBehaviour {
    
    public static int points = 0;

    // Start is called before the first frame update
    void Start() {
        points = 0;
    }

    // Update is called once per frame
    void Update() {
        GetComponent<TextMeshProUGUI>().text= points.ToString();
    }
}
