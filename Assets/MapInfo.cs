using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MapInfo : MonoBehaviour
{
    // Start is called before the first frame update
    private void OnTriggerStay(Collider other)
    {
        GameObject.Find("MapManager").GetComponent<MapManager>().actualMap = gameObject;
    }
}
