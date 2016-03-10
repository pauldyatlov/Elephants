using UnityEngine;
using System.Collections;

public class Lift : MonoBehaviour
{
    [SerializeField] private int _minYCoord;
    [SerializeField] private int _maxYCoord;
    [SerializeField] private float _step;

    private float Direction { get; set; }

    internal void Init(float xPosition)
    {
        transform.position = new Vector3(xPosition, GetRandomYPosition);

        Direction = _step;

        StartCoroutine("Co_MovementBehaviour");
    }

    private IEnumerator Co_MovementBehaviour()
    {
        while (true)
        {
            if (transform.position.y >= _maxYCoord)
            {
                Direction *= -1;
            }
            else
            {
                if (transform.position.y <= _minYCoord)
                {
                    Direction = Mathf.Abs(Direction);
                }
            }

            transform.position = new Vector3(transform.position.x, transform.position.y + Direction);

            yield return null;
        }
    }

    private float GetRandomYPosition
    {
        get
        {
            return Utils.NewRandom.Next(_minYCoord, _maxYCoord);
        }
    }
}
