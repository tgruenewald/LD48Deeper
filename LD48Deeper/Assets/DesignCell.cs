using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DesignCell : MonoBehaviour
{
    public GameObject block = null;
    public float smooth = 1f;
    private Quaternion targetRotation;

    DesignGrid designGrid = null;

    GameObject submarine = null;
    string this_current_block = null;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    private void OnMouseDown()
    {
        designGrid = transform.parent.gameObject.transform.parent.gameObject.GetComponent<DesignGrid>();
        submarine = GameObject.Find("submarine");
        designGrid.current_cell = this.gameObject;
        Debug.Log("Putting down a block:  " + designGrid.current_block);
        if (designGrid.current_block == null || (this_current_block != null && this_current_block == designGrid.current_block)) {
            Destroy(block);
            this_current_block = null;
        }
        else {
            if (block != null) 
            {
                Destroy(block);
            }
            block = (GameObject) Instantiate(Resources.Load("prefab/"+ designGrid.current_block+"_part"), GetComponent<Transform>().position, GetComponent<Transform>().rotation) ;
            block.transform.parent = submarine.transform;
            this_current_block = designGrid.current_block;
            targetRotation = block.transform.rotation;
        }

    }

    // Update is called once per frame
    void Update()
    {
        if (designGrid != null && designGrid.current_cell == this.gameObject) {
            if (Input.GetKeyDown(KeyCode.A))
            {
                Debug.Log("Pressing A");
                targetRotation *=  Quaternion.AngleAxis(5, Vector3.forward);
            }
            if (Input.GetKeyDown(KeyCode.D))
            {
                Debug.Log("Pressing D");
                targetRotation *=  Quaternion.AngleAxis(-5, Vector3.forward);
            }
            if (block != null)
            {
                block.transform.rotation= Quaternion.Lerp (block.transform.rotation, targetRotation , 10 * smooth * Time.deltaTime);
            }
        }

    }
}
