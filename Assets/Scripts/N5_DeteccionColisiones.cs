using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class N5_DeteccionColisiones : MonoBehaviour
{
    [SerializeField]
    TextMeshProUGUI texto_EnemigoScore;
    
    public TextMeshProUGUI texto_PowerUps;

    [SerializeField]
    int contadorEnemigosDerrotados;
    int contadorPowerUpsObtenidos;

    // Start is called before the first frame update
    void Start()
    {
        contadorEnemigosDerrotados = 0;
        contadorPowerUpsObtenidos = 0;
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log("Entrando a colision con: " + collision.gameObject.name);
        GameObject gameObject = collision.gameObject;

        if (gameObject.tag.Equals("Enemy"))
        {
            Destroy(gameObject);
            contadorEnemigosDerrotados++;
            texto_EnemigoScore.text = contadorEnemigosDerrotados.ToString();
        }
        else if (gameObject.tag.Equals("PowerUp"))
        {
            Destroy(gameObject);
            contadorPowerUpsObtenidos++;
            texto_PowerUps.text = contadorPowerUpsObtenidos.ToString();
        }
        else { 
        //interaccion con el escenario
        }
    }

    private void OnCollisionStay(Collision collision)
    {
        Debug.Log("Manteniendo la colision con: " + collision.gameObject.name);
    }

    private void OnCollisionExit(Collision collision)
    {
        Debug.Log("Saliendo de la colision con: " + collision.gameObject.name);
    }


}
