using UnityEngine;
[RequireComponent(typeof(CharacterController), typeof(PlayerMove), typeof(PlayerRotation))]

public class Player : MonoBehaviour
{
    private PlayerMove _move;
    private PlayerRotation _rotate;

    private void Awake()
    {
        _move = GetComponent<PlayerMove>();
        _rotate = GetComponent<PlayerRotation>();
        Cursor.lockState = CursorLockMode.Locked;
    }

    private void Update()
    {
        _move.Move();
        _rotate.Rotate();
    }
}
