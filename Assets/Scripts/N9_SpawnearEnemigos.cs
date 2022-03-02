using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

/*
PARA OBTENER REFERENCIAS A UN SCRIPT:
        Script scriptRef;  //Script al que se quiere accesar    


    OPCION 1 , CUANDO ESTAN EN EL MISMO GAMEOBJECT:
        scritRef = GETCOMPONENT<NOMBRE_SCRIPT>();

    OPCION 2 , CUANDO ESTAN DIFERENTE GAMEOBJECT:
        [SerializeField]
        GameObject NOMBREGAMEOBJECT;    //Se vincula el gameobject por inspector

        scritRef = NOMBREGAMEOBJECT.GETCOMPONENT<NOMBRE_SCRIPT>();
*/
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
        GameObject game_Object = collision.gameObject;

        if (game_Object.tag.Equals("Enemy"))
        {
            string nombreObjColision = game_Object.name;
            Debug.Log("Nombre: " + nombreObjColision);

            //indexSpawnPorDesbloquear
            char temp = nombreObjColision[nombreObjColision.Length - 1];
            int indexSpawn = temp - 48; //numero del spawn
            Debug.Log(indexSpawn);

            sse.posSpawners[indexSpawn-1] = 0; //desbloquear posicion

            Destroy(game_Object);
            contadorEnemigosDerrotados++;
            texto_EnemigoScore.text = contadorEnemigosDerrotados.ToString();

            sse.SpawnearEnemigo();

        }
        else if (game_Object.tag.Equals("PowerUp"))
        {
            Destroy(game_Object);
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