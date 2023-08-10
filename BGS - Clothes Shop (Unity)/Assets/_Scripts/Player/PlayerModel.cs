using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerModel : MonoBehaviour
{
    [SerializeField] private PlayerView _playerView;
    [SerializeField] private Vector2 _walkDirection;
    [SerializeField] private Rigidbody2D _rigidbody;
    [SerializeField] private float _speed = 10f;


    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (_walkDirection != Vector2.zero)
        {
            Vector2 newPosition = _rigidbody.position + _walkDirection.normalized * _speed * Time.deltaTime;
            _rigidbody.MovePosition(newPosition);

        }
        _playerView.SetParameters(_walkDirection.x, _walkDirection.y);
    }

    public void SetWalkDirection(float horizontal, float vertical)
    {
        _walkDirection.x = horizontal;
        _walkDirection.y = vertical;
    }
}