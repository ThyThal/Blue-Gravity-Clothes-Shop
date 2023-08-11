using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShopManager : MonoBehaviour
{
    [SerializeField] private Color _expensiveColor = Color.red;
    [SerializeField] private Color _cheapColor = Color.green;
    [SerializeField] private Color _boughtColor = Color.yellow;
    [SerializeField] private List<ShopItem> _items;

    private void Start()
    {
        UpdatePriceColors();
    }

    public void UpdatePriceColors()
    {
        foreach (var item in _items)
        {
            if (item.IsBought) continue;

            bool isExpensive = item.ItemPrice > GameManager.Instance.Coins ? true : false;
            if (isExpensive) { item.PriceColor = _expensiveColor; }
            else { item.PriceColor = _cheapColor; }
        }
    }
}
