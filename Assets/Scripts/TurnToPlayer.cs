using UnityEngine;
using DefaultNamespace;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Video;

public class TurnToPlayer : MonoBehaviour
{
    public Transform playerCamera;
    public FirstPersonController player;


    // Update is called once per frame
    void Update()
    {
        if (playerCamera)
        {
            // Make the canvas face the player
            transform.LookAt(transform.position + playerCamera.forward);
        }

    }
}
