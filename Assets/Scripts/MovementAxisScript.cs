using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementAxisScript : MonoBehaviour {


    void Update() {
        if (Input.GetKey(KeyCode.UpArrow)) {
            transform.Translate(0, 0, Input.GetAxis("Vertical") * 1);
        }
        if (Input.GetKey(KeyCode.DownArrow)) {
            transform.Translate(0, 0, -(Input.GetAxis("Vertical") * -1));
        }
        if (Input.GetKey(KeyCode.LeftArrow)) {
            transform.Translate(Input.GetAxis("Horizontal") * 1, 0, 0);
        }
        if (Input.GetKey(KeyCode.RightArrow)) {
            transform.Translate(-(Input.GetAxis("Horizontal") * -1), 0, 0);
        }
    }
}
