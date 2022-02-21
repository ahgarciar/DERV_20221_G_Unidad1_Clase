using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class N8_GetComponent : MonoBehaviour
{
    [SerializeField]
    GameObject manejadorTiempo;

    N6_ControladorTiempo refScriptTiempo;

    [SerializeField]
    TextMeshProUGUI texto_EnemigoScore;

    public TextMeshProUGUI texto_PowerUps;

    [SerializeField]
    int contadorEnemigosDerrotados;
    int contadorPowerUpsObtenidos;

    // Start is called before the first frame update
    void Start()
    {
        refScriptTiempo = manejadorTiempo.GetComponent<N6_ControladorTiempo>();
        // refScriptTiempo.tiempoRestante = 100;
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
            
            refScriptTiempo.tiempoRestante += 10;
            refScriptTiempo.tiempo.text = refScriptTiempo.tiempoRestante.ToString();

            texto_PowerUps.text = contadorPowerUpsObtenidos.ToString();   
            
        }
        else
        {
            //interaccion con el escenario
        }
    }

}