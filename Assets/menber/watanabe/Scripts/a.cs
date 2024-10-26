using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class a : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        SoundManager.instance.PlayAudioSorce(SoundManager.AudioOfType.BGM, 0);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            SoundManager.instance.PlayAudioSorce(SoundManager.AudioOfType.SYSTEMSE, 0);
            SceneManager.LoadScene("MainScene");
        }
    }
}
