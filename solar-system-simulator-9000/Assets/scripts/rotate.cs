using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotate : MonoBehaviour
{
  Vector3 ROTATION = new Vector3(0.01f, 0.02f, 0.03f); // const rotation vector3

  void Update() { transform.Rotate(ROTATION); } // rotate using the const rotation every frame
}
