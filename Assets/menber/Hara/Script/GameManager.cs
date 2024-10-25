using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    // public static GameManager Instance { get; private set; }
    // public bool isGameOver = false;

    [SerializeField]
    private GameObject RockPrefab;
    [SerializeField]
    private GameObject VortexPrefab;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(CreateRock());
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private IEnumerator CreateRock()
    {
         yield return new WaitUntil(() => Input.GetMouseButtonDown(0));//テスト用生成クリック
        while (true)
        {
            Vector3 tmp = GameObject.Find("Player").transform.position;
            float y = tmp.y;
            float x = Random.Range(-4.5f, 4.5f);//ここの範囲からランダム生成
            int direction = Random.Range(0,11);
            if (direction == 2)
            {
                VortexPrefab.transform.position = new Vector3(x, y + 7.0f, 0);
                Instantiate(VortexPrefab);
                Debug.Log("渦");
            }
            else
            {
                RockPrefab.transform.position = new Vector3(x, y + 7.0f, 0);
                Debug.Log("岩１");
            }
            Instantiate(RockPrefab);
            
            yield return new WaitForSeconds(2.5f);
        }
        
        
    }
}
