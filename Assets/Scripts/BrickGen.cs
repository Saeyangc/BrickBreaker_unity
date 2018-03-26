using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BrickGen : MonoBehaviour {
    public GameObject yellow, red, purple;

    const float ORIGIN = -6.5f;
    int row = 8, column = 23;
    float x = ORIGIN, y = 4;
    GameObject[] bricks = {};

    // Use this for initialization
    void Start () {
        GameObject[] temp = {yellow, red, purple};
        bricks = temp;
        for (int r = 0; r < row; r++) {
            int count = 0;
            for (int c = 0; c < column; c++) {
                
                if (count == 5) {
                    c = c+1;
                    x = x + 0.5f * 2;
                    count = 0;                    
                }
                count++;                
                Instantiate(bricks[Random.Range(0,3)], new Vector2(x, y), Quaternion.identity);
                x  = x + .5f;
            }
            x = ORIGIN;
            y = y-.4f;
        }
        
	}
	
	// Update is called once per frame
	void Update () {
        
    }
}
