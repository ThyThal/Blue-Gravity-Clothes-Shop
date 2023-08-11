using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MerchantTrigger : MonoBehaviour
{
    [SerializeField] private CircleCollider2D _shopTrigger;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            GameManager.Instance.ToggleShop(true);
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            GameManager.Instance.ToggleShop(false);
        }
    }
}
