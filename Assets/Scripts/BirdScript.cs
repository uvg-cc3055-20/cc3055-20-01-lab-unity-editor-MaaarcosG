 using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BirdScript : MonoBehaviour {
    public float jumpForce;
    public float forwardSpeed;
    public GameObject cam;
    public bool dead;

    Rigidbody2D rb;
	// Use this for initialization
	void Start () {
        rb = GetComponent<Rigidbody2D>();
        jumpForce = 300f;
        forwardSpeed = 2f;
        dead = false;
        rb.freezeRotation = true;
	}

    // Update is called once per frame
    void Update() {
        if (dead.Equals(false))
        {
            cam.transform.Translate(new Vector3(1, 0, 0) * forwardSpeed * Time.deltaTime);
            rb.transform.Translate(new Vector3(1, 0, 0) * forwardSpeed * Time.deltaTime);
        }
        if (Input.GetButtonDown("Jump"))
        {
            rb.velocity = Vector2.zero;
            rb.AddForce(Vector2.up * jumpForce);
        }
        if (rb.position.x >= 35.47){
            dead = true;
        }
	}
    private void OnCollisionEnter2D(Collision2D collision)
    {
        dead = true;
    }
}
