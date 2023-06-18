using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HPBar : MonoBehaviour
{
    [SerializeField] private Image _hpBarcurrent;
    [SerializeField] private float _maxHealth;
    private float currentHealth;
    void Awake()
    {
        currentHealth = _maxHealth;
    }
    public void UpdateHP(float damageval)
    {
        if()
        currentHealth = Mathf.Clamp(currentHealth - damageval, 0, _maxHealth);
        _hpBarcurrent.fillAmount = currentHealth / _maxHealth;
    }
}
