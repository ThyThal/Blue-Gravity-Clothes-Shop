using System.Collections;
using System.Collections.Generic;
using UnityEngine;

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
    [SerializeField] private int _coins = 700;

    public int Coins => _coins;

    public void BoughtClothes(PlayerClotheScriptable item)
    {
        _coins -= item.Price;
        _playerController.DoEquipClothe(item);
    }
}