using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundChecker : MonoBehaviour
{
    private PlayerMove playerMove;

    private void Start()
    {
        playerMove = GetComponentInParent<PlayerMove>();
    }
    private void OnTriggerStay(Collider other)
    {
        if(other.gameObject.tag != "Player" && other.gameObject.tag != "Map")
        {
            playerMove.isGrounded = true;
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if(other.gameObject.tag != "Player" && other.gameObject.tag != "Map")
        {
            playerMove.isGrounded = false;
        }
    }
}
