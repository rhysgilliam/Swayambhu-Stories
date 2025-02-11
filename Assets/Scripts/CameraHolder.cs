using UnityEngine;

public class CameraHolder : MonoBehaviour
{
    [SerializeField]
    private Transform cameraPosition;

    // Update is called once per frame
    private void Update()
    {
        transform.position = cameraPosition.position;
    }
}
