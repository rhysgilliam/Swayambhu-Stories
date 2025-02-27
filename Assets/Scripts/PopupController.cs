using DefaultNamespace;
using UnityEngine;

public class PopupController : MonoBehaviour, IPopup
{
    public Transform playerCamera;
    public FirstPersonController player;
    public Canvas fullAnnotation;
    
    private Canvas _canvas;
    private bool _viewing;

    private void Start()
    {
        _viewing = false;
        _canvas = GetComponent<Canvas>();
    }

    private void Update()
    {
        if (playerCamera)
        {
            // Make the canvas face the player
            transform.LookAt(transform.position + playerCamera.forward);
        }

        _canvas.enabled = _viewing;

        _viewing = false;
        
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            player.playerCanMove = true;
            player.cameraCanMove = true;
            player.enableHeadBob = true;

            fullAnnotation.gameObject.SetActive(false);
        }
    }

    public void View()
    {
        _viewing = true;
    }

    public void Interact()
    {
        player.playerCanMove = false;
        player.cameraCanMove = false;
        player.enableHeadBob = false;

        fullAnnotation.gameObject.SetActive(true);
    }
}
