using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimedSpawn : MonoBehaviour
{
    public Vector2[] spawnpos;
    public GameObject square;
    bool spawnStart;
    private void Start()
    {
        spawnStart = true;
    }

    private void Update()
    {
        if (spawnStart)
        {
            StartCoroutine(SpawnStart());
            spawnStart = false;
        }
        
    }
    IEnumerator SpawnStart()
    {
        int i = Random.Range(0, 5);
        Instantiate(square, spawnpos[i], Quaternion.identity, transform.parent);
        yield return new WaitForSeconds(2);
        spawnStart = true;
    }
}
