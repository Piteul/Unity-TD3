using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
        
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKey(KeyCode.D)) {
            Debug.Log("GameObject Destroy!");
            Destroy(gameObject);
        }
	}
}
