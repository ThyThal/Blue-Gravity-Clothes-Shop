using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerView : MonoBehaviour
{
    [SerializeField] private List<Animator> _enabledClothes;
    [SerializeField] private Animator _animatorBody;
    [SerializeField] private Animator _animatorFoot;
    [SerializeField] private Animator _animatorPants;
    [SerializeField] private Animator _animatorShirt;
    [SerializeField] private Animator _animatorHair;
    [SerializeField] private Animator _animatorHat;

    [SerializeField] private bool _isWalking = false;
    [SerializeField] private float _horizontal = 0f;
    [SerializeField] private float _vertical = 0f;

    // Start is called before the first frame update
    void Awake()
    {
        _enabledClothes.Add(_animatorBody);
    }

    // Update is called once per frame
    void Update()
    {
        foreach (Animator animator in _enabledClothes)
        {
            animator.SetBool("IsWalking", _isWalking);
            animator.SetFloat("Horizontal", _horizontal);
            animator.SetFloat("Vertical", _vertical);
        }
    }

    public void SetBodyParameters(float horizontal, float vertical, bool isWalking)
    {
        if (_animatorBody == null) return;
        _isWalking = isWalking;
        _horizontal = horizontal;
        _vertical = vertical;
    }

    public void ToggleFoots(bool enabled)
    {
        if (_animatorFoot == null) return;

        if (enabled)
        {
            _animatorFoot.gameObject.SetActive(true);
            _animatorFoot.enabled = true;
            _enabledClothes.Add(_animatorFoot);
        }

        else
        {
            _animatorFoot.enabled = false;
            _enabledClothes.Remove(_animatorFoot);
            _animatorFoot.gameObject.SetActive(false);
        }
    }
    public void TogglePants(bool enabled)
    {
        if (_animatorPants == null) return;

        if (enabled)
        {
            _animatorPants.gameObject.SetActive(true);
            _animatorPants.enabled = true;
            _enabledClothes.Add(_animatorPants);
        }

        else
        {
            _animatorPants.enabled = false;
            _enabledClothes.Remove(_animatorPants);
            _animatorPants.gameObject.SetActive(false);
        }
    }
    public void ToggleShirt(bool enabled)
    {
        if (_animatorShirt == null) return;

        if (enabled)
        {
            _animatorShirt.gameObject.SetActive(true);
            _animatorShirt.enabled = true;
            _enabledClothes.Add(_animatorShirt);
        }

        else
        {
            _animatorShirt.enabled = false;
            _enabledClothes.Remove(_animatorShirt);
            _animatorShirt.gameObject.SetActive(false);
        }
    }
    public void ToggleHair(bool enabled)
    {
        if (_animatorHair == null) return;

        if (enabled)
        {
            _animatorHair.gameObject.SetActive(true);
            _enabledClothes.Add(_animatorHair);
            _animatorHair.enabled = true;
        }

        else
        {
            _enabledClothes.Remove(_animatorHair);
            _animatorHair.enabled = false;
            _animatorHair.gameObject.SetActive(false);
        }
    }
    public void ToggleHat(bool enabled)
    {
        if (_animatorHat == null) return;

        if (enabled)
        {
            _animatorHat.gameObject.SetActive(true);
            _animatorHat.enabled = true;
            _enabledClothes.Add(_animatorHat);
        }

        else
        {
            _enabledClothes.Remove(_animatorHat);
            _animatorPants.enabled = false;
            _animatorHat.gameObject.SetActive(false);
        }
    }
}

