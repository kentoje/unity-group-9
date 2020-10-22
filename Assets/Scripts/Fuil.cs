using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Fuil : MonoBehaviour
{
    public int Fuils = 3;

    void Start() {

    }

    public void AddFuil() {
        Fuils++;
    }

    public void LostFuil() {
        Fuils--;

        if (Fuils <= 0) {
            SceneManager.LoadScene("GameOver");
        }
    }

}

