using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ooo : MonoBehaviour
{
    private float RotSpeed = 500;
    void Update()
    {
        gameObject.transform.Rotate(new Vector3(0f, 0f, -RotSpeed) * Time.deltaTime);
    }
}
