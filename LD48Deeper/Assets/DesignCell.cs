using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DesignCell : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }
    private void OnMouseDown()
    {
        var grunt = (GameObject) Instantiate(Resources.Load("prefab/hull_block_1"), GetComponent<Transform>().position, GetComponent<Transform>().rotation) ;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
