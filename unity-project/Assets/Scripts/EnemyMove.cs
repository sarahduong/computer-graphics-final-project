using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMove : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(waiter());
    }

    // Update is called once per frame
    void Update()
    {
        
        int x = Random.Range(0, 10);
        int y = Random.Range(0, 10);

        if(x < 5)
        {
            transform.Translate(Vector3.forward * Time.deltaTime / 2);
        }
        else
        {
            transform.Translate(Vector3.back * Time.deltaTime / 2);
        }


        if(y < 5)
        {
            transform.Translate(Vector3.left * Time.deltaTime / 2);
        }
        else
        {
            transform.Translate(Vector3.right * Time.deltaTime / 2);
        }

        
        

    }

    IEnumerator waiter()
    {

        
            

            

        int z = Random.Range(0, 360);

        
        transform.Rotate(new Vector3(0, z, 0), Space.World);

        
        yield return new WaitForSeconds(4);

        

    
}

}
