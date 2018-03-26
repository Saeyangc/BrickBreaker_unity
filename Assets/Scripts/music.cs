using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class music : MonoBehaviour {
    void Awake()
    {
        GameObject[] musicObjs = GameObject.FindGameObjectsWithTag("music");
        if (musicObjs.Length > 1) { Destroy(this.gameObject); }
        
        DontDestroyOnLoad(this.gameObject);
    }
}
