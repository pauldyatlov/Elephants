using UnityEngine;
using System.Collections.Generic;

public class Engine : MonoBehaviour
{
    [SerializeField] private GameObject _lift;
    [SerializeField] private Unit _unit;
    [SerializeField] private Vector3 _firstLiftPosition;
    [SerializeField] private float _distanceBetweenLifts;
    [SerializeField] private int _liftsCount;

    private void Awake()
    {
        LiftsSpawn();
        UnitSpawn();
    }

    private void LiftsSpawn()
    {
        for (int i = 0; i < _liftsCount; i++)
        {
            var instantiatedLift = Instantiate(_lift, new Vector2(_distanceBetweenLifts * i, 0), Quaternion.identity);
        }
    }

    private void UnitSpawn()
    {
        var pos = new Vector2(_firstLiftPosition.x, _firstLiftPosition.y + 5);
        var unit = Instantiate(_unit, pos, Quaternion.identity);
    }
}