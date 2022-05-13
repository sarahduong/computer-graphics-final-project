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
            BoxCollider aCol = Stew.AddComponent(typeof(BoxCollider)) as BoxCollider;
            aCol.isTrigger = true;
            Stew.AddComponent<ChestCollect>();

            var position2 = new Vector3(Random.Range(5.0f, 245.0f), 1, Random.Range(5.0f, 245.0f));
            Instantiate(Ham, position2, Quaternion.identity);
            BoxCollider bCol = Ham.AddComponent(typeof(BoxCollider)) as BoxCollider;
            bCol.isTrigger = true;
            Ham.AddComponent<ChestCollect>();

            var position3 = new Vector3(Random.Range(5.0f, 245.0f), 1, Random.Range(5.0f, 245.0f));
            Instantiate(Bread, position3, Quaternion.identity);
            BoxCollider cCol = Bread.AddComponent(typeof(BoxCollider)) as BoxCollider;
            cCol.isTrigger = true;
            Bread.AddComponent<ChestCollect>();

            var position4 = new Vector3(Random.Range(5.0f, 245.0f), 1, Random.Range(5.0f, 245.0f));
            Instantiate(Pie, position4, Quaternion.identity);
            BoxCollider dCol = Pie.AddComponent(typeof(BoxCollider)) as BoxCollider;
            dCol.isTrigger = true;
            Pie.AddComponent<ChestCollect>();

            var position5 = new Vector3(Random.Range(5.0f, 245.0f), 1, Random.Range(5.0f, 245.0f));
            Instantiate(Cake, position5, Quaternion.identity);
            BoxCollider eCol = Cake.AddComponent(typeof(BoxCollider)) as BoxCollider;
            eCol.isTrigger = true;
            Cake.AddComponent<ChestCollect>();

            var position6 = new Vector3(Random.Range(5.0f, 245.0f), 1, Random.Range(5.0f, 245.0f));
            Instantiate(Cheese, position6, Quaternion.identity);
            BoxCollider fCol = Cheese.AddComponent(typeof(BoxCollider)) as BoxCollider;
            fCol.isTrigger = true;
            Cheese.AddComponent<ChestCollect>();

            var position7 = new Vector3(Random.Range(5.0f, 245.0f), 1, Random.Range(5.0f, 245.0f));
            Instantiate(Ribs, position7, Quaternion.identity);
            BoxCollider gCol = Ribs.AddComponent(typeof(BoxCollider)) as BoxCollider;
            gCol.isTrigger = true;
            Ribs.AddComponent<ChestCollect>();

            var position8 = new Vector3(Random.Range(5.0f, 245.0f), 1, Random.Range(5.0f, 245.0f));
            Instantiate(Watermelon, position8, Quaternion.identity);
            BoxCollider hCol = Watermelon.AddComponent(typeof(BoxCollider)) as BoxCollider;
            hCol.isTrigger = true;
            Watermelon.AddComponent<ChestCollect>();
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
