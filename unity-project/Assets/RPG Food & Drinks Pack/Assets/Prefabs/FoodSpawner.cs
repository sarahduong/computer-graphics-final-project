using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FoodSpawner : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject Stew;
    public GameObject Ham;
    public GameObject Bread;
    public GameObject Pie;
    public GameObject Cake;
    public GameObject Cheese;
    public GameObject Ribs;
    public GameObject Watermelon;

    // Start is called before the first frame update
    void Start()
    {
        for(int i= 0; i < 2; i++)
        {
            var position1 = new Vector3(Random.Range(5.0f, 245.0f), 1, Random.Range(5.0f, 245.0f));
            Instantiate(Stew, position1, Quaternion.identity);

            var position2 = new Vector3(Random.Range(5.0f, 245.0f), 1, Random.Range(5.0f, 245.0f));
            Instantiate(Ham, position2, Quaternion.identity);

            var position3 = new Vector3(Random.Range(5.0f, 245.0f), 1, Random.Range(5.0f, 245.0f));
            Instantiate(Bread, position3, Quaternion.identity);

            var position4 = new Vector3(Random.Range(5.0f, 245.0f), 1, Random.Range(5.0f, 245.0f));
            Instantiate(Pie, position4, Quaternion.identity);

            var position5 = new Vector3(Random.Range(5.0f, 245.0f), 1, Random.Range(5.0f, 245.0f));
            Instantiate(Cake, position5, Quaternion.identity);

            var position6 = new Vector3(Random.Range(5.0f, 245.0f), 1, Random.Range(5.0f, 245.0f));
            Instantiate(Cheese, position6, Quaternion.identity);

            var position7 = new Vector3(Random.Range(5.0f, 245.0f), 1, Random.Range(5.0f, 245.0f));
            Instantiate(Ribs, position7, Quaternion.identity);

            var position8 = new Vector3(Random.Range(5.0f, 245.0f), 1, Random.Range(5.0f, 245.0f));
            Instantiate(Watermelon, position8, Quaternion.identity);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
