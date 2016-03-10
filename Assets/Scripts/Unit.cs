using UnityEngine;
using System.Collections;

public class Unit : MonoBehaviour
{
    [SerializeField] private Rigidbody _rigidBody;

    private void FixedUpdate()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            _rigidBody.AddForce(new Vector3(4, 25f, 0), ForceMode.Impulse);
        }
    }
}
