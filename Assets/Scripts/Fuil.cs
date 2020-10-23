using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Fuil : MonoBehaviour
{
    public int Fuils = 3;
    public Text TxtFuils;

    void Start() {
        TxtFuils.text = "Fuils: " + Fuils;
    }

    public void AddFuil() {
        Fuils++;
        TxtFuils.text = "Fuils: " + Fuils;
    }

    public void LostFuil() {
        Fuils--;

        TxtFuils.text = "Fuils: " + Fuils;

        if (Fuils <= 0) {
            SceneManager.LoadScene("GameOver");
        }
    }

}