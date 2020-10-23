using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Fuel : MonoBehaviour
{
    public int Fuels = 3;
    public Text TxtFuels;

    //   public GameObject Car;
    void Start()
    {
        TxtFuels.text = "Fuels: " + Fuels;
    }

    public void AddFuel()
    {
        Fuels++;
        TxtFuels.text = "Fuels: " + Fuels;
    }

    public void LoseFuel(GameObject obj)
    {
        if (LayerMask.LayerToName(obj.layer) == "Car")
        {
            Fuels--;
            TxtFuels.text = "Fuels: " + Fuels;
        }
        if (Fuels <= 0)
        {
            SceneManager.LoadScene("GameOver");
        }
    }

}

