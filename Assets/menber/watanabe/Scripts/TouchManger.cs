using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TouchManger : MonoBehaviour
{
    [SerializeField]
    leaf _liaf;

    [SerializeField] 
    private GameObject _center;
    [SerializeField]
    public bool _animStart = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        TouchMove();
        
    }

    private void TouchMove()
    {
        if (Input.GetMouseButtonDown(0))
        {
            // カーソル位置を取得
            Vector3 mousePosition = Input.mousePosition;
            float dis = Vector3.Distance(mousePosition, _center.transform.position);
            // カーソル位置のz座標を10に
            mousePosition.z = 10;
            // カーソル位置をワールド座標に変換
            Vector3 target = Camera.main.ScreenToWorldPoint(mousePosition);
            // GameObjectのtransform.positionにカーソル位置(ワールド座標)を代入
            transform.position = target;
            _animStart = true;
        }
        if (Input.GetMouseButtonUp(0))
        {
            _animStart = false;
        }
    }
}
