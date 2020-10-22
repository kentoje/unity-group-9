using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Fuel : MonoBehaviour
{
    public int Fuels = 3;

    void Start() {

    }

    public void AddFuel() {
        Fuels++;
    }

    public void LostFuel() {
        Fuels--;

        if (Fuels <= 0) {
            SceneManager.LoadScene("GameOver");
        }
    }

}

