using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DesignCell : MonoBehaviour
{
    public GameObject block = null;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    private void OnMouseDown()
    {
        DesignGrid designGrid = transform.parent.gameObject.transform.parent.gameObject.GetComponent<DesignGrid>();
        Debug.Log("Putting down a block:  " + designGrid.current_block);
        if (block != null) 
        {
            Destroy(block);
        }
        block = (GameObject) Instantiate(Resources.Load("prefab/"+ designGrid.current_block+"_part"), GetComponent<Transform>().position, GetComponent<Transform>().rotation) ;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
