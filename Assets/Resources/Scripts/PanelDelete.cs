using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PanelDelete : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        StartCoroutine(Destroy());

    }

    IEnumerator Destroy()
    {
        Debug.Log("Start Destroy");
        yield return new WaitForSeconds(1);
        Destroy(gameObject);
        Debug.Log("End Destroy");

    }
}
