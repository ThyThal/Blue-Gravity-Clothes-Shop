using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] PlayerModel _playerModel;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        var inputHorizontal = Input.GetAxisRaw("Horizontal");
        var inputVertical = Input.GetAxisRaw("Vertical");

        _playerModel.SetWalkDirection(0, 0);

        if (inputHorizontal != 0 || inputVertical != 0)
        {
            _playerModel.SetWalkDirection(inputHorizontal, inputVertical);
        }
    }

    private void DoMovement()
    {

    }
}
