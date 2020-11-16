using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LookAt : MonoBehaviour
{
    public Transform player;
    public Transform followingObject;
    public float TargetDistance;
    public float AllowedDistance = 5;
    public float FollowSpeed = 0.05f;
    public RaycastHit Shot;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.LookAt(player.transform);
        if (Physics.Raycast(transform.position, transform.TransformDirection(Vector3.forward), out Shot))
        {
            TargetDistance = Shot.distance;
            if (TargetDistance >= AllowedDistance)
            { 
                
                followingObject.transform.position = Vector3.MoveTowards(transform.position, player.transform.position, FollowSpeed);
            }
        }

        
    }
}
