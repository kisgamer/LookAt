using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Crouch : MonoBehaviour
{
    public Transform player;
    public Camera cameramain;
    public PlayerMovement movement;
    public Sprint sprint;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.LeftControl)) {
            player.transform.localScale = new Vector3(1f, 0.5f, 1f);
            player.transform.localPosition = new Vector3(0f, -.5f, 0f);
            cameramain.transform.localPosition = new Vector3(0f, -.5f, 0f);
            movement.speed = 5f;
            sprint.enabled = false;
        }
        if (Input.GetKeyUp(KeyCode.LeftControl))
        {
            player.transform.localScale = new Vector3(1f, 1f, 1f);
            player.transform.localPosition = new Vector3(0f, 0f, 0f);
            cameramain.transform.localPosition = new Vector3(0f, 0.703f, 0f);
            movement.speed = 12f;
            sprint.enabled = true;
        }
    }
}
