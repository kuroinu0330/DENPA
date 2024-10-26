using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class leaf : MonoBehaviour
{
    private Rigidbody2D rb;
    // â~ÇÃîºåaÇê›íËÇµÇ‹Ç∑ÅB
    [SerializeField] public float radius = 5f;

    [SerializeField] private float LeafSpeed = 1.0f;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {

    }
    private void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(transform.position, radius);
    }
    public void ArrowShot(Vector2 force)
    {
        rb.AddForce(force, ForceMode2D.Impulse);
    }
}

