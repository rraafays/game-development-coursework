using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class move : MonoBehaviour
{
  const float SPEED = 0.01f; // constant speed float

  void Update() { transform.position += new Vector3(SPEED, 0, 0); } // add the defined speed to the x value of a vector 3 every frame
}
