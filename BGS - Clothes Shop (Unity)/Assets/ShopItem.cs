using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ShopItem : MonoBehaviour
{
    [SerializeField] private Button _button;
    [SerializeField] private PlayerClotheScriptable _currentItem;
    [SerializeField] private ShopManager _shopManager;
    [SerializeField] private TMP_Text _priceText;
    [SerializeField] private Image _image;
    [SerializeField] private bool _isBought = false;

    public bool IsBought => _isBought;
    public int ItemPrice => _currentItem.Price;
    public Color PriceColor
    {
        get { return _priceText.color; }
        set { _priceText.color = value; }
    }

    // Start is called before the first frame update
    void Start()
    {
        if (_currentItem != null)
        {
            _image.sprite = _currentItem.Sprite;
            _priceText.text = _currentItem.Price.ToString();
        }

        else
        {
            gameObject.SetActive(false);
        }
    }

    public void DoShopInteraction()
    {
        if (_isBought)
        {
            Sell();
        }

        else
        {
            Purchase();
        }
    }

    public void Purchase()
    {
        if (_isBought) return;
        if (_currentItem.Price > GameManager.Instance.Coins) return;

        _priceText.color = Color.yellow;
        GameManager.Instance.BoughtClothes(_currentItem);
        _isBought = true;
        _shopManager.UpdatePriceColors();
    }

    public void Sell()
    {
        if (!_isBought) return;
        GameManager.Instance.SoldClothes(_currentItem);
        _isBought = false;
        _shopManager.UpdatePriceColors();
    }
}
