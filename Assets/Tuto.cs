using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tuto : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(Hide());
    }

    IEnumerator Hide()
    {
        
        yield return new WaitForSeconds(10f);
        Destroy(gameObject);
    }
}
