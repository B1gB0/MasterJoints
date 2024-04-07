using UnityEngine;

[RequireComponent(typeof(HingeJoint))]
[RequireComponent(typeof(Rigidbody))]
public class Swing : MonoBehaviour
{
    [SerializeField] private Vector3 _positionAnchor;
    [SerializeField] private Vector3 _forceToAwake;

    private HingeJoint _hingeJoint;
    private Rigidbody _rigidbody;

    private void Start()
    {
        _hingeJoint = GetComponent<HingeJoint>();
        _rigidbody = GetComponent<Rigidbody>();
    }

    public void StartRockingSwing()
    {
        _rigidbody.AddForce(_forceToAwake);
        _hingeJoint.anchor = _positionAnchor;
    }
}
