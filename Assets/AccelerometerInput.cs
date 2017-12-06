using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AccelerometerInput : MonoBehaviour {
    Vector3 mousePos;
    // Use this for initialization
    void Start() {

    }

    // Update is called once per frame
    void Update() {
        Vector3 translation = Vector3.zero;

#if UNITY_ANDROID
        translation = new Vector3(Input.acceleration.x, 0, -Input.acceleration.z);

#else
        if (transform.eulerAngles.x >-55 && transform.eulerAngles.x < 55) && (transform.eulerAngles.z >-55 && <55)
        {
            translation = mousePos - new Vector3(-Input.mousePosition.y, 0, Input.mousePosition.x); // Todo normalise to (-1,1) range
            mousePos = new Vector3(-Input.mousePosition.y, 0, Input.mousePosition.x);
        }
        

#endif
        transform.Rotate(translation, Space.World);
    }
}
