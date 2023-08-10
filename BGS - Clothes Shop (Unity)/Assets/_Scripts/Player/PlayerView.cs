using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerView : MonoBehaviour
{
    [SerializeField] private Animator _animator;

    private static readonly int _horizontalHash = Animator.StringToHash("Horizontal");
    private static readonly int _verticalHash = Animator.StringToHash("Vertical");

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void SetParameters(float horizontal, float vertical)
    {
        _animator.SetFloat(_horizontalHash, horizontal);
        _animator.SetFloat(_verticalHash, vertical);
    }
}

