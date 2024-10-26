using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class Score : MonoBehaviour
{
    public GameObject player;
    public Text scoreUI;

    Vector2 startPos;
    float nowPos;


    // Start is called before the first frame update
    void Start()
    {
        startPos = player.transform.position; //初期値
    }

    // Update is called once per frame
    void Update()
    {
        //進んだ距離計算
        nowPos = Vector2.Distance(startPos, player.transform.position);
        nowPos = Mathf.Floor(nowPos);
        scoreUI.text = Convert.ToString(nowPos)+"m";
    }
}
