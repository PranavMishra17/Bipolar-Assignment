using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;
using UnityEngine.UI;
using TMPro;

public class VideoplayerCtrl : MonoBehaviour
{
    public VideoPlayer videoPlayer;
    public AudioSource audsource;
    public GameObject playButton;
    public float raycastDistance = 10f;
    public TextMeshProUGUI txt;

    private RaycastHit hit;

    void Start()
    {

    }

    void Update()
    {
        // Check if the left mouse button is clicked
        if (Input.GetMouseButtonDown(0))
        {
            // Cast a ray from the camera's position in the direction of the mouse pointer
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

            // Check if the ray hits the play button
            if (Physics.Raycast(ray, out hit, raycastDistance) && hit.collider.gameObject == playButton)
            {
                if (videoPlayer.isPlaying)
                {
                    videoPlayer.Pause();
                    txt.text = "Play";
                }
                else  videoPlayer.Play();
                txt.text = "Pause";
            }
        }

        if (videoPlayer.isPlaying)
        {
            txt.text = "Pause";
        } else txt.text = "Play";
    }


}
