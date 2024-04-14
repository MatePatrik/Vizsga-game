using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LaserLeftSpin : MonoBehaviour
{
    void Update()
    {
        transform.Rotate(0, 0, 10 * Time.deltaTime);
    }
}
