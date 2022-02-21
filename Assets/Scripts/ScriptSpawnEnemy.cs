using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScriptSpawnEnemy : MonoBehaviour
{
    [SerializeField]
    GameObject []spawns;

    [SerializeField]
    GameObject prefabEnemy;

    public void SpawnearEnemigo() { 
        int pos = Random.Range(0,spawns.Length);
        Debug.Log("Pos Nuevo Enemigo: " + pos.ToString());

        Instantiate(prefabEnemy, spawns[pos].transform);

    }

}
