using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Invincible : MonoBehaviour
{

  public float Duree = 5;

  bool IsInvincible = false;

  float EnCours;

  Collider CarCollider;

  // Start is called before the first frame update
  void Start()
  {
    CarCollider = GetComponent<Collider>();
  }

  public void GetInvincible()
  {
    if (!IsInvincible)
    {
      IsInvincible = true;
      CarCollider.enabled = !CarCollider.enabled;
      Debug.Log("Collider.enabled = " + CarCollider.enabled);

      Invoke("ResetInvicible", Duree);
    }
  }

  void ResetInvicible()
  {
    IsInvincible = false;
  }
}
