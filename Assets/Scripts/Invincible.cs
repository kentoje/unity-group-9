using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Invincible : MonoBehaviour
{
    public float Intervalle = 0.1f;
    float TempsPasse = 0;
    public int InvincibleTime = 5;

    bool IsInvincible = false;

    float EnCours;

    void Update()
    {
        TempsPasse += Time.deltaTime;

        if (TempsPasse > Intervalle && IsInvincible)
        {
            gameObject.layer = LayerMask.NameToLayer("CarInvincible");
        }
    }

    public void GetInvincible(GameObject obj)
    {
        IsInvincible = true;
        Invoke("ResetInvicible", InvincibleTime);
    }

    void ResetInvicible()
    {
        IsInvincible = false;
        gameObject.layer = LayerMask.NameToLayer("Car");
    }
}
