using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotatePath : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

        transform.position += transform.forward * 1;
        transform.localEulerAngles += new Vector3(0,5,0);

    }
}
