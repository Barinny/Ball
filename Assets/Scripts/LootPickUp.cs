using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class LootPickUp : MonoBehaviour
{
    public int value;
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            Destroy(gameObject);
            ScoreManger.Instance.IncreaseCoins(value);
        }
    }
}
