using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "BGS Clothes/Clothe")]
public class PlayerClotheScriptable : ScriptableObject, IEquipable
{
    [SerializeField] private Sprite _sprite;
    [SerializeField] public ClotheType _clotheType;
    [SerializeField] private int _price;

    public Sprite Sprite => _sprite;
    public int Price => _price;
    public enum ClotheType
    {
        Foot,
        Pants,
        Shirt,
        Hair,
        Hat
    }

    public void Equip()
    {
        throw new System.NotImplementedException();
    }
}