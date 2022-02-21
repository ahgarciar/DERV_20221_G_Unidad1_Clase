using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class N9_SpawnearEnemigos : MonoBehaviour
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

    [SerializeField]
    ScriptSpawnEnemy sse;

    // Start is called before the first frame update
    void Start()
    {
        refScriptTiempo = manejadorTiempo.GetComponent<N6_ControladorTiempo>();
        // refScriptTiempo.tiempoRestante = 100;
        
        sse = GetComponent<ScriptSpawnEnemy>();
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

            sse.SpawnearEnemigo();

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