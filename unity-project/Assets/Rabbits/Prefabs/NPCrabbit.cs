using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPCrabbit : MonoBehaviour
{
    public GameObject rabbitPrefab;
    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < 15; i++)
        {
            var position = new Vector3(Random.Range(5.0f, 245.0f), 0.1f, Random.Range(5.0f, 245.0f));
            Instantiate(rabbitPrefab, position, Quaternion.identity);
        }
    }
}
