using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Fuel : MonoBehaviour
{
    public int Fuels = 3;
    public Text TxtFuels;

    void Start()
    {
        TxtFuels.text = "Fuels: " + Fuels;
    }

    public void AddFuel()
    {
        Fuels++;
        TxtFuels.text = "Fuels: " + Fuels;

    }

    public void LoseFuel()
    {
        Fuels--;
        TxtFuels.text = "Fuels: " + Fuels;

        if (Fuels <= 0)
        {
            Debug.Log("Les connard");
            SceneManager.LoadScene("GameOver");
        }
    }

}

