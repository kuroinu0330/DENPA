using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Test : MonoBehaviour
{
    Rigidbody2D rb;
    [SerializeField]
    float jumpForce;
    Vector2 targetPosition;
    [SerializeField]
    private GameObject _Water;
    [SerializeField]
    public bool _animStart = false;
    // Start is called before the first frame update
    void Start()
    {
        rb = this.GetComponent<Rigidbody2D>();
        SoundManager.instance.PlayAudioSorce(SoundManager.AudioOfType.BGM, 0);
    }

    // Update is called once per frame
    void Update()
    {
        Jump();
    }
    void Jump()
    {
        if (Input.GetMouseButtonDown(0))
        {
            SoundManager.instance.PlayAudioSorce(SoundManager.AudioOfType.SYSTEMSE, 0);
            Vector3 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            targetPosition = mousePos - this.transform.position;
            targetPosition.Normalize();
            Debug.Log("x:" + targetPosition.x + "    y:" + targetPosition.y);
            rb.AddForce(targetPosition * jumpForce, ForceMode2D.Impulse);
            GameObject obj = Instantiate(_Water, new Vector2(mousePos.x, mousePos.y + 1), Quaternion.identity);
            _animStart = true;
        }

    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("End"))
        {
            SceneManager.LoadScene("Result");
        }
    }
}
