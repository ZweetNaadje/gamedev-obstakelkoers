using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spinner : MonoBehaviour
{
    // Change the speed of the spinners and their spin-axis in the Inspector
    [SerializeField] float xAngle;
    [SerializeField] float yAngle;
    [SerializeField] float zAngle;
  
    // Update is called once per frame
    void Update()
    {
        transform.Rotate(xAngle, yAngle, zAngle);
    }
}
