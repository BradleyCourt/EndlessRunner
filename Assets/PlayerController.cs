using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour {

    public float speed;

    private Rigidbody rb;
    public Transform Playerpos;
    public bool isGrounded = true;
    void Start() {
        rb = GetComponent<Rigidbody>();
    }
    void Update() {
        if (Playerpos.position.y <= 1.1f) {
            isGrounded = true;
        } else {
            isGrounded = false;
        }

    }
    void FixedUpdate() {
        Vector3 movement = new Vector3(1, 0f, 0.0f);
        //float movement = 1;
        
        //rb.velocity += movement * speed * Time.deltaTime;
        //rb.AddForce(movement * speed * Time.deltaTime);

        transform.position += movement * speed * Time.deltaTime;

        if (Input.GetMouseButtonDown(0) && isGrounded) {
            Debug.Log("Pressed left click.");
            rb.AddForce(0, 1200, 0);
        }
            
    }

}
