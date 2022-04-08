using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Unit : MonoBehaviour, IDamageable
{
    [SerializeField] private UnitDataSO _unitData;
    [SerializeField] private UnitColour _colour;
    [SerializeField] private UnitType _type;
    [SerializeField] private int _health;

    private void Awake()
    {
        Init(_unitData);
    }
    
    public void Init(UnitDataSO unitData)
    {
        _colour = unitData.Colour;
        _type = unitData.Type;
        _health = unitData.Health;
    }

    public void TakeDamage()
    {
        if (_health <= 1)
            Destroy(gameObject);
        else
            _health--;
    }
}
