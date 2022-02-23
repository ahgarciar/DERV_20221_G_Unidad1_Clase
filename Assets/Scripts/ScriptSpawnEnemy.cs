using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScriptSpawnEnemy : MonoBehaviour
{
    [SerializeField]
    GameObject []spawns;

    [SerializeField]
    GameObject prefabEnemy;

    int cont = 1;

    [SerializeField]
    int[] posBloqueada = new int[8]; //si es 0 no esta bloqueada, si es 1 , esta bloqueada

    public void SpawnearEnemigo() { 
        int pos = Random.Range(0,spawns.Length);
        Debug.Log("Pos Nuevo Enemigo: " + pos.ToString());

        //Instantiate(prefabEnemy, spawns[pos].transform);
        //Instantiate(prefabEnemy, spawns[pos].transform, false);
        GameObject enemigo = Instantiate(prefabEnemy, spawns[pos].transform.position, spawns[pos].transform.rotation);

        /*
        GameObject enemigo2 = Instantiate(prefabEnemy, 
            new Vector3(spawns[pos].transform.position.x, spawns[pos].transform.position.y, 30f), 
            spawns[pos].transform.rotation);
        */

        enemigo.gameObject.name = "Enemigo_" + cont.ToString() + "_" + pos.ToString();
        cont++;

    }

}
