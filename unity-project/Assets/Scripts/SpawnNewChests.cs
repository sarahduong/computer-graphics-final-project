using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnNewChests : MonoBehaviour
{
    public GameObject treasure;
    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < 8; i++)
        {
            var position = new Vector3(Random.Range(5.0f, 245.0f), 0.2f, Random.Range(5.0f, 245.0f));

            Vector3 myVector = new Vector3(-90, 0, 0);


            Instantiate(treasure, position, Quaternion.Euler(myVector));
        }
    }
}
