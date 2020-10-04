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
        if(other.gameObject.tag != "player" && other.gameObject.tag != "Map")
        {
            playerMove.isGrounded = true;
            Debug.Log(other.gameObject.name + "est touché");
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if(other.gameObject.tag != "player" && other.gameObject.tag != "Map")
        {
            playerMove.isGrounded = false;
        }
    }
}
