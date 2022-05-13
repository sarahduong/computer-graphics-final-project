using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChestCollect : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        Inventory inventory = other.GetComponent<Inventory>();
        if(inventory != null)
        {
            inventory.ChestCollected();
            gameObject.SetActive(false);
        }   

        Destroy(gameObject); 


    }
}