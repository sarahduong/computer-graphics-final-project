using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    public GameObject enemyPrefab;
    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < 20; i++)
        { 
            var position = new Vector3(Random.Range(5.0f, 245.0f), 1, Random.Range(5.0f, 245.0f));
            Instantiate(enemyPrefab, position, Quaternion.identity);
        }
    }
}
