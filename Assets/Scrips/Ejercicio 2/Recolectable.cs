using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Recolectable : MonoBehaviour
{
    [SerializeField] private string itemName;

    public static event Action<string> OnItemCollected;
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            OnItemCollected?.Invoke(itemName);
            Destroy(gameObject);
        }

    }
}
