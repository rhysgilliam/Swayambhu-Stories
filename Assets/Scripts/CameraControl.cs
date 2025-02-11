using UnityEngine;

public class CameraControl : MonoBehaviour
{
    [SerializeField]
    private float sensX;
    [SerializeField]
    private float sensY;

    public Transform orientation;

    private float _xRotation;
    private float _yRotation;
    
    
    private void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }

    private void Update()
    {
        var mouseX = Input.GetAxisRaw("Mouse X") * Time.deltaTime * sensX;
        var mouseY = Input.GetAxisRaw("Mouse Y") * Time.deltaTime * sensY;

        _yRotation += mouseX;

        _xRotation -= mouseY;
        _xRotation = Mathf.Clamp(_xRotation, _yRotation, 0);

        transform.rotation = Quaternion.Euler(_xRotation, _yRotation, 0);
        orientation.rotation = Quaternion.Euler(0, _yRotation, 0);
    }
}
