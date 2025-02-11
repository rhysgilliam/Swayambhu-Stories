using DefaultNamespace;
using UnityEngine;

public class PopupController : MonoBehaviour, IPopup
{
    public Transform playerCamera; // Drag the player's camera here
    private Canvas canvas;
    private bool _viewing;

    private void Start()
    {
        _viewing = false;
        canvas = GetComponent<Canvas>();
    }

    private void Update()
    {
        if (playerCamera)
        {
            // Make the canvas face the player
            transform.LookAt(transform.position + playerCamera.forward);
        }

        canvas.enabled = _viewing;

        _viewing = false;
    }

    public void View()
    {
        _viewing = true;
    }

    public void Interact()
    {
        Debug.Log("TODO: implement full annotation viewing (video or text)");
    }
}
