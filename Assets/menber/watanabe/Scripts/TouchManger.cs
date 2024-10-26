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
    [SerializeField]
    private GameObject _Water;
    [SerializeField]
    leaf _leaf;
    [SerializeField]
    public float _angle;
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
            SoundManager.instance.PlayAudioSorce(SoundManager.AudioOfType.SYSTEMSE, 0);
            // カーソル位置を取得
            Vector2 mousePos = (Vector2)Camera.main.ScreenToWorldPoint(Input.mousePosition);
            float dis = Vector2.Distance(mousePos, _center.transform.position);
            _angle = Mathf.Atan2(mousePos.y - _center.transform.position.y, mousePos.x - _center.transform.position.x);
            //Vector2 angle = (mousePos - (Vector2)transform.position);
            //_leaf.ArrowShot(-angle);
            transform.rotation = Quaternion.AngleAxis(_angle * Mathf.Rad2Deg, Vector3.forward);
            //mousePosition.z = 10;
            Debug.Log(-_angle);
            // GameObjectのtransform.positionにカーソル位置(ワールド座標)を代入
            transform.position = mousePos;
            GameObject obj = Instantiate(_Water, new Vector2(this.transform.position.x, this.transform.position.y), Quaternion.identity);
            _animStart = true;
        }
    }
}
