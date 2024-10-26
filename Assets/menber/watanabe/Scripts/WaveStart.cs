using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaveStart : MonoBehaviour
{
    [SerializeField]
    private TouchManger _touchmanger;
    private Animator _anim;
    // Start is called before the first frame update
    void Start()
    {
        _anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (_touchmanger._animStart == true)
        {
            _anim.SetBool("WaveBool", true);
        }
        else
        {
            _anim.SetBool("WaveBool", false);
        }
    }
}
