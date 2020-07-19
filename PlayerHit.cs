using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHit : MonoBehaviour
{
    public GameObject square;
    public BoxCollider2D box;
    public LayerMask layer;
    private void Start()
    {
        box = transform.GetComponent<BoxCollider2D>();
        square = transform.GetComponent<GameObject>();
    }
    void Update()
    {
        if (isHit())
        {

            Destroy(gameObject);
            FindObjectOfType<audiomanager>().Play("EnemyDeath");
            FindObjectOfType<GameManager>().Math();
          
           
        }
    }

    public bool isHit()
    {
        RaycastHit2D raycast = Physics2D.BoxCast(box.bounds.center, box.bounds.size, 0f, Vector2.down, .1f, layer);
        return raycast.collider != null;
    }
}
