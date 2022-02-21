using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class N3_DeltaTime : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            Debug.Log("W");    //[0, 0, 1]
            //Vector3....  Coordenadas Globales
            transform.Translate(Vector3.forward * 2f * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.A))
        {
            Debug.Log("A");
            //transform.right    transform.forward   <<<--Coordenadas locales
            transform.Translate(transform.right * -1f * 2f * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.S))
        {
            Debug.Log("S");
            transform.Translate(Vector3.back * 2f);
        }
        if (Input.GetKey(KeyCode.D))
        {
            Debug.Log("D");
            transform.Translate(new Vector3(1, 0, 0) * 2f * Time.deltaTime);
        }
    }
}
