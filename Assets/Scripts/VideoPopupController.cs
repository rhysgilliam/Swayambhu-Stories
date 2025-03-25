using DefaultNamespace;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Video;

public class VideoPopupController : MonoBehaviour, IPopup
{
    public Transform playerCamera;
    public FirstPersonController player;

    public VideoPlayer videoPlayer;
    public RawImage rawImage;

    public GameObject text;
    public GameObject image;
    private bool _viewing;

    private void Start()
    {
        rawImage.enabled = false;
        _viewing = false;
    }

    private void Update()
    {
        if (playerCamera)
        {
            // Make the canvas face the player
            transform.LookAt(transform.position + playerCamera.forward);
        }

        // _canvas.enabled = _viewing;
        text.SetActive(_viewing);
        image.SetActive(_viewing);

        if (Input.GetKeyDown(KeyCode.Escape))
        {
            rawImage.enabled = false;
            videoPlayer.Stop();      // Stops current playback
            videoPlayer.frame = 0;   // Sets the current frame back to the beginning
        }
            

        _viewing = false;
    }

    public void View()
    {
        if (!rawImage.enabled)
            _viewing = true;
    }

    public void Interact()
    {
        rawImage.enabled = true;
        _viewing = false;
        videoPlayer.Play();
    }
}
