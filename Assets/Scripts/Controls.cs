using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controls : MonoBehaviour {
    float speed = .4f;
    private Rigidbody2D rb;

    

    // Use this for initialization
    void Start () {
        rb = GetComponent<Rigidbody2D>();
        
	}
	
	// Update is called once per frame
	void FixedUpdate () {
        float moveHorizontal = Input.GetAxis("Horizontal");         
        Vector2 movement = new Vector2(moveHorizontal,0);      
        rb.transform.Translate(movement*speed);
    }
}
