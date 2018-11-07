using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void FixedUpdate () {
        if (Input.GetKey(KeyCode.UpArrow)) {
            transform.position += transform.forward * 1;
        }
        if (Input.GetKey(KeyCode.DownArrow)) {
            transform.position -= transform.forward * 1;
        }
        if (Input.GetKey(KeyCode.LeftArrow)) {
            transform.position -= transform.right * 1;
        }
        if (Input.GetKey(KeyCode.RightArrow)) {
            transform.position += transform.right * 1;
        }      
		
	}
}
