using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MapManager : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject map;
    private int difference = 60;
    public GameObject actualMap;
    public GameObject beforeMap;
    public GameObject afterMap;
    public Vector3 coor;
    private int count;

    private void Start()
    {
        actualMap = GameObject.Find("Map 1");
        count = 1;
        afterMap = Instantiate(map, actualMap.transform.position - new Vector3(-difference,0,0), Quaternion.identity);
        afterMap.name = "Map " + (count + 1);
        beforeMap = Instantiate(map, actualMap.transform.position - new Vector3(difference, 0, 0), Quaternion.identity);
        beforeMap.name = "Map " + (count - 1);
    }
}
