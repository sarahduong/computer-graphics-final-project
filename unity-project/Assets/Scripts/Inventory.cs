using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory : MonoBehaviour
{
    public int numberChestsCollected
    {
        get;
        private set;
    }

    public int ChestCollected()
    {
        numberChestsCollected++;
        return numberChestsCollected;
    }
}
