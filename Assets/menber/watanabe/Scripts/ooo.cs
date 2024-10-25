using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ooo : MonoBehaviour
{
    [SerializeField]
    private Transform _self;
    [SerializeField]
    private Transform aaa;
    [SerializeField]
    TouchManger manger;
    private float RotSpeed = 500;
    void Update()
    {
        _self.LookAt(aaa);
    }
}
