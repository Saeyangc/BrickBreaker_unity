using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class Ball : MonoBehaviour
{
    Rigidbody2D rb;
    float x, y;



    void Start() {
        rb = GetComponent<Rigidbody2D>();
        do { x = Random.Range(-2, 2) * .05f; }
        while (x == 0);
        do { y = Random.Range(-2, 2) * .05f; }
        while (y == 0);
    }
    void Update() {
        Vector2 ballPath = new Vector2(x, y);
        rb.transform.Translate(ballPath);
        GameObject[] blocks = GameObject.FindGameObjectsWithTag("block");
        if (blocks.Length == 0) { SceneManager.LoadScene("main", LoadSceneMode.Single); }
        
    }
    void OnCollisionEnter2D(Collision2D col)
    {

        if (col.gameObject.tag == "isBorder") {
            x = x * -1;

        }
        if (col.gameObject.tag == "isCieling" || col.gameObject.tag == "paddle")
        {
            y = y * -1;

        }
        if (col.gameObject.tag == "TopBot" )
        {
            y = y * -1;
            Destroy(col.gameObject.transform.parent.gameObject);

        }
        if (col.gameObject.tag == "Side")
        {
            x = x * -1;
            Destroy(col.gameObject.transform.parent.gameObject);

        }
        
        if (col.gameObject.tag == "isDeath")
        {           
           SceneManager.LoadScene("main", LoadSceneMode.Single);     
            
        }


    }
}