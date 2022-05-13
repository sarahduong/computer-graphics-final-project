using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyDamage : MonoBehaviour
{
    
    public int health;

    void onTriggerEnter(Collider other)
    {
        if(other.tag == "Enemy"){
            //health -= 1;

            

            Destroy(other.gameObject);
        }

        else if(other.tag == "Food")
        {
            
            if(health < 5)
            {
                health++;

                Destroy(other.gameObject);
            }

            


        }

        else if(other.tag == "Chest")
        {
            Debug.Log("success");
        }
        
    }
}
