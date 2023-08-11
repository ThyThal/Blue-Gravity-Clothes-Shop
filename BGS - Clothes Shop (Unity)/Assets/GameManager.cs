using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{
    #region Game Manager Instance
    public static GameManager Instance;
    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(this);
        }

        else
        {
            Destroy(gameObject);
        }
    }
    #endregion

    [SerializeField] private PlayerController _playerController;
    [SerializeField] private ShopManager _shopManager;
    [SerializeField] private TMP_Text _coinsText;
    [SerializeField] private Canvas _shopCanvas;
    [SerializeField] private int _startCoins = 100;
    private int _coins = 0;

    public int Coins => _coins;

    private void Start()
    {
        AddCoins(_startCoins);
    }

    private void Update()
    {
        if (Input.GetKey(KeyCode.P))
        {
            AddCoins(1);
        }

        if (Input.GetKey(KeyCode.O))
        {
            RemoveCoins(1);
        }
    }

    public void BoughtClothes(PlayerClotheScriptable item)
    {
        RemoveCoins(item.Price);
        _playerController.DoEquipClothe(item);
    }

    public void SoldClothes(PlayerClotheScriptable item)
    {
        AddCoins(item.Price);        
        _playerController.DoUnequipClothe(item);
    }

    public void ToggleShop(bool state)
    {
        _shopCanvas.enabled = state;
        if (state == false) return;

        _shopManager.UpdatePriceColors();
    }

    public void AddCoins(int amount)
    {
        _coins += amount;
        _coinsText.text = _coins.ToString();
    }

    public void RemoveCoins(int amount)
    {
        _coins -= amount;
        _coinsText.text = _coins.ToString();
    }
}