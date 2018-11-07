using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeColor : MonoBehaviour {

    public float time;
    public float timeLimit;

    // Use this for initialization
    void Start() {
        time = 0;
        timeLimit = 5;
    }

    // Update is called once per frame
    void Update() {

        changeColorWithLerp();
        moveWithTime();

        calculTime();
    }

    public void changeColorClassic() {
        if (Input.GetKey(KeyCode.UpArrow)) {
            gameObject.GetComponent<Renderer>().material.color = Color.white;
        }
        if (Input.GetKey(KeyCode.DownArrow)) {
            gameObject.GetComponent<Renderer>().material.color = Color.black;
        }
        if (Input.GetKey(KeyCode.LeftArrow)) {
            gameObject.GetComponent<Renderer>().material.color = Color.cyan;
        }
        if (Input.GetKey(KeyCode.RightArrow)) {
            gameObject.GetComponent<Renderer>().material.color = Color.red;
        }
    }

    public void changeColorWithTime() {
        if (time < 1) {
            gameObject.GetComponent<Renderer>().material.color = Color.grey;
        }
        if (time > 1 && time < 3) {
            gameObject.GetComponent<Renderer>().material.color = Color.black;
        }
        if (time > 3 && time < 5) {
            gameObject.GetComponent<Renderer>().material.color = Color.cyan;
        }
        if (time > 5) {
            gameObject.GetComponent<Renderer>().material.color = Color.red;
        }
    }

    public void changeColorWithLerp() {

        if (Input.anyKey) {
            gameObject.GetComponent<Renderer>().material.color = Color.Lerp(Color.green, Color.red, time / timeLimit);
        }
        else {
            gameObject.GetComponent<Renderer>().material.color = Color.white;
        }
    }

    public void moveWithTime() {
        transform.position += transform.forward * time;
    }

    public void calculTime() {
        if (Input.anyKey) {
            time += Time.fixedDeltaTime;
        }
        else {
            if (time != 0) {
                Debug.Log("temps de touche :" + time.ToString());
                time = 0;
            }
        }
    }

}
