using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hit : MonoBehaviour
{
    public GameObject bullet;
    public BoxCollider2D box;
    public LayerMask layer;
    private void Start()
    {
        box = transform.GetComponent<BoxCollider2D>();
        bullet = transform.GetComponent<GameObject>();
    }
    void Update()
    {
        if (isHit())
        {
            
            gameObject.SetActive(false);

            FindObjectOfType<audiomanager>().Play("EnemyDeath");
            for(int i = 0; i<10; i++)
            {
                Score.scoreValue++;
                for(int j = 0; j < 30; j++)
                {
                    if (Score.scoreValue % 30 == 0)
                    {
                        FindObjectOfType<GameManager>().Math();
                    }
                }
            }
            
        }
    }

    public bool isHit()
    {
        RaycastHit2D raycast = Physics2D.BoxCast(box.bounds.center, box.bounds.size, 0f, Vector2.down, .1f, layer);
        return raycast.collider != null;
    }
}
