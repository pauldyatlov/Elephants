using UnityEngine;
using System.Collections;

public class Unit : MonoBehaviour
{
    [SerializeField] protected Transform _groundCheck;
    [SerializeField] private Rigidbody2D _rigidBody;

    private bool IsOnGround
    {
        get
        {
            return Physics2D.OverlapCircle(_groundCheck.position, Constants.GroundcheckOverlapRadius, 1 << Constants.EarthLayerMask.value);
        }
    }

    private void FixedUpdate()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Jump();
        }
    }

    private void Jump()
    {
        if (IsOnGround)
        {
            _rigidBody.AddForce(new Vector3(2, 8f, 0), ForceMode2D.Impulse);
        }
    }
}
