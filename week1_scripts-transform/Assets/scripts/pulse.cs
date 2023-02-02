using System; // for math abs
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pulse : MonoBehaviour
{
  Vector3 vector3_sine(float x)
  {
    float sine = Math.Abs(Mathf.Sin(Time.time)); // define sine as the absolute value of a sine function
    return (new Vector3(sine, sine, sine)); // return a vector3 containing sine as all values
  }

  void Update() { transform.localScale = vector3_sine(Time.time); } // set scale to vector3 sine every frame
}
