using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class N7_ControlBotones : MonoBehaviour
{
    public void cambiarEscena(string nombre) {
        SceneManager.LoadScene(nombre);
    }
}
