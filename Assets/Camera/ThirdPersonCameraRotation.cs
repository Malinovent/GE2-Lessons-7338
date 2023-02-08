using UnityEngine;
using Cinemachine;

public class ThirdPersonCameraRotation : MonoBehaviour
{
    private CinemachineVirtualCamera virtualCamera;
    public Transform target;
    public float rotationSpeed = 1.0f;

    private void Awake()
    {
        virtualCamera = GetComponent<CinemachineVirtualCamera>();
    }

    private void LateUpdate()
    {
        float horizontal = Input.GetAxis("Mouse X") * rotationSpeed;
        float vertical = Input.GetAxis("Mouse Y") * rotationSpeed;

        target.Rotate(0, horizontal, 0);
        virtualCamera.transform.RotateAround(target.position, target.right, -vertical);
    }
}
