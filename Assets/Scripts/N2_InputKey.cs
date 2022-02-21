using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class N2_InputKey : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W)){
            Debug.Log("W");
        }
        if (Input.GetKey(KeyCode.A)){
            Debug.Log("A");
        }
        if (Input.GetKey(KeyCode.S)){
            Debug.Log("S");
        }
        if (Input.GetKey(KeyCode.D)){
            Debug.Log("D");
        }
    }
}
