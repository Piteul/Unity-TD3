using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionScript : MonoBehaviour {

    int nbCollision = 0;
    // Use this for initialization
    void Start() {

    }

    // Update is called once per frame
    void Update() {

    }

    void OnCollisionEnter(Collision col) {
        
        nbCollision++;

        switch (nbCollision) {

            case 1:
                col.gameObject.GetComponent<Renderer>().material.color = Color.yellow;
                break;
            case 2:
                col.gameObject.GetComponent<Renderer>().material.color = Color.green;
                break;
            case 3:
                col.gameObject.GetComponent<Renderer>().material.color = Color.magenta;
                break;
            case 4:
                Destroy(col.gameObject);
                break;
            default:
                break;
        }
      
    }
}
