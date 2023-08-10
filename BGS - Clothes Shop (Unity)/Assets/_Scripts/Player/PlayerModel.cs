using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerModel : MonoBehaviour
{
    [SerializeField] private PlayerView _playerView;
    [SerializeField] private Vector2 _walkDirection;
    [SerializeField] private Rigidbody2D _rigidbody;
    [SerializeField] private float _speed = 10f;
    [SerializeField] private bool _isWalking = false;

    [SerializeField] private PlayerClotheScriptable _playerClotheFoot;
    [SerializeField] private PlayerClotheScriptable _playerClothePants;
    [SerializeField] private PlayerClotheScriptable _playerClotheShirt;
    [SerializeField] private PlayerClotheScriptable _playerClotheHair;
    [SerializeField] private PlayerClotheScriptable _playerClotheHat;


    // Start is called before the first frame update
    void Start()
    {
        if (_playerClotheFoot != null) { EquipClothes(_playerClotheFoot); }
        if (_playerClothePants != null) { EquipClothes(_playerClothePants); }
        if (_playerClotheShirt != null) { EquipClothes(_playerClotheShirt); }
        if (_playerClotheHair != null) { EquipClothes(_playerClotheHair); }
        if (_playerClotheHat != null) { EquipClothes(_playerClotheHat); }
    }

    // Update is called once per frame
    void Update()
    {
        if (_walkDirection != Vector2.zero)
        {
            _isWalking = true;
            Vector2 newPosition = _rigidbody.position + _walkDirection.normalized * _speed * Time.deltaTime;
            _rigidbody.MovePosition(newPosition);

        }

        else
        {
            _isWalking = false;
        }

        _playerView.SetBodyParameters(_walkDirection.x, _walkDirection.y, _isWalking);


    }

    public void SetWalkDirection(float horizontal, float vertical)
    {
        _walkDirection.x = horizontal;
        _walkDirection.y = vertical;
    }

    public void EquipClothes(PlayerClotheScriptable playerClothe)
    {
        switch (playerClothe._clotheType)
        {
            case PlayerClotheScriptable.ClotheType.Foot:
                _playerClotheFoot = playerClothe;
                _playerView.ToggleFoots(true);
                return;

            case PlayerClotheScriptable.ClotheType.Pants:
                _playerClothePants = playerClothe;
                _playerView.TogglePants(true);
                return;

            case PlayerClotheScriptable.ClotheType.Shirt:
                _playerClotheShirt = playerClothe;
                _playerView.ToggleShirt(true);
                return;

            case PlayerClotheScriptable.ClotheType.Hair:
                _playerClotheHair = playerClothe;
                _playerView.ToggleHair(true);
                return;

            case PlayerClotheScriptable.ClotheType.Hat:
                _playerClotheHat = playerClothe;
                _playerView.ToggleHat(true);
                return;
        }
    }

    public void UnequipClothes(PlayerClotheScriptable playerClothe)
    {
        switch (playerClothe._clotheType)
        {
            case PlayerClotheScriptable.ClotheType.Foot:
                _playerClotheFoot = null;
                _playerView.ToggleFoots(false);
                return;

            case PlayerClotheScriptable.ClotheType.Pants:
                _playerClothePants = null;
                _playerView.TogglePants(false);
                return;

            case PlayerClotheScriptable.ClotheType.Shirt:
                _playerClotheShirt = null;
                _playerView.ToggleShirt(false);
                return;

            case PlayerClotheScriptable.ClotheType.Hair:
                _playerClotheHair = null;
                _playerView.ToggleHair(false);
                return;

            case PlayerClotheScriptable.ClotheType.Hat:
                _playerClotheHat = null;
                _playerView.ToggleHat(false);
                return;
        }
    }


}