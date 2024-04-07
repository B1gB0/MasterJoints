using UnityEngine;

[RequireComponent(typeof(SpringJoint))]
[RequireComponent(typeof(Rigidbody))]
public class Thrower : MonoBehaviour
{
    [SerializeField] private Vector3 _positionAnchor;
    [SerializeField] private Vector3 _forceToAwake;

    private SpringJoint _springJoint;
    private Rigidbody _rigidbody;

    private Vector3 _difaultAnchorPosition;

    private void Start()
    {
        _springJoint = GetComponent<SpringJoint>();
        _rigidbody = GetComponent<Rigidbody>();

        _difaultAnchorPosition = _springJoint.anchor;
    }

    public void LaunchProjectile()
    {
        _rigidbody.AddForce(_forceToAwake);
        _springJoint.anchor = _positionAnchor;
    }

    public void SetDifaultState()
    {
        _rigidbody.AddForce(_forceToAwake);
        _springJoint.anchor = _difaultAnchorPosition;
    }
}
