using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpeedModifier : MonoBehaviour
{
  Global globalRef;

  public float Duree = 3;
  public float Acceleration = 10;

  bool IsAccel = false;
  float AccelEnCours;

  // Start is called before the first frame update
  void Start()
  {
    globalRef = GetComponent<Global>();
  }

  public void DoubleSpeed(GameObject obj)
  {

    SpeedFactor factorComp = obj.GetComponent<SpeedFactor>();

    if (!IsAccel)
    {
      IsAccel = true;

      if (factorComp != null)
      {
        globalRef.Speed += factorComp.SpeedFactorValue;
        AccelEnCours = factorComp.SpeedFactorValue;
      }
      else
      {
        globalRef.Speed += Acceleration;
        AccelEnCours = Acceleration;
      }

      Invoke("ResetSpeed", Duree);
    }
  }

  void ResetSpeed()
  {
    IsAccel = false;
    globalRef.Speed -= AccelEnCours;
  }
}
