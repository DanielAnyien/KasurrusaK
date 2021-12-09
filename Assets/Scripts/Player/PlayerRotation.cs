using UnityEngine;

public class PlayerRotation : MonoBehaviour
{
    [SerializeField] private Transform _cameraHolder;
    [SerializeField] private float _speed;
    [SerializeField] private float _rotationLimit;

    protected float vertRot;

    public virtual void Rotate()
    {
        vertRot -= GetVerticalValue();
        vertRot = vertRot <= -_rotationLimit ? -_rotationLimit :
            vertRot >= _rotationLimit ? _rotationLimit : vertRot;

        RotateVertical();
        RotateHorizontal();
    }

    protected virtual void RotateVertical() => _cameraHolder.localRotation = Quaternion.Euler(vertRot, 0f, 0f);
    protected virtual void RotateHorizontal() => transform.Rotate(Vector3.up * GetHorizontalValue());

    protected float GetVerticalValue() => Input.GetAxis("Mouse Y") * _speed * Time.deltaTime;
    protected float GetHorizontalValue() => Input.GetAxis("Mouse X") * _speed * Time.deltaTime;
}
