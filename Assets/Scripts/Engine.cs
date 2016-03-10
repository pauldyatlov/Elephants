using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Engine : MonoBehaviour
{
    [SerializeField] private Lift _lift;
    [SerializeField] private Unit _unit;
    [SerializeField] private Vector3 _firstLiftPosition;
    [SerializeField] private float _distanceBetweenLifts;
    [SerializeField] private int _liftsCount;

    private List<Lift> Lifts { get; set; }

    private void Awake()
    {
        Lifts = new List<Lift>();

        LiftsSpawn();
        UnitSpawn();
    }

    private void LiftsSpawn()
    {
        for (int i = 0; i < _liftsCount; i++)
        {
            var instantiatedLift = Instantiate(_lift) as Lift;
            instantiatedLift.Init(GetNextLiftPosition);

            Lifts.Add(instantiatedLift);
        }
    }

    private void UnitSpawn()
    {
        var pos = new Vector2(_firstLiftPosition.x, _firstLiftPosition.y + 5);
        var unit = Instantiate(_unit, pos, Quaternion.identity);
    }

    private float GetNextLiftPosition
    {
        get
        {
            return Lifts.Count * _distanceBetweenLifts + _firstLiftPosition.x;
        }
    }
}