using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class N10_CargaDatosEscena : MonoBehaviour
{
    [SerializeField]
    public TextMeshProUGUI scoreEnemigos;

    [SerializeField]
    public TextMeshProUGUI scorePotenciadores;


    // Start is called before the first frame update
    void Start()
    {
        scoreEnemigos.text = PlayerPrefs.GetString("enemigos", "0");
        scorePotenciadores.text = PlayerPrefs.GetString("potenciadores", "0");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
