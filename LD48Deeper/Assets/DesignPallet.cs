using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DesignPallet : MonoBehaviour
{
    public string subPart;
    public Vector2 hotSpot = Vector2.zero;
	private CursorMode cursorMode = CursorMode.Auto;
    // Start is called before the first frame update
    DesignGrid designGrid = null;
    void Start()
    {
        designGrid = GetComponentInParent<Pallet>().designGrid;
    }

    private void OnMouseDown()
    {
        Debug.Log(subPart + "Clicked");
        if (subPart == "normal") 
        {
            Debug.Log("Restoring cursor");
            Cursor.SetCursor(null, Vector2.zero, CursorMode.Auto); 
            designGrid.current_block = null;
        }
        else {
            Cursor.SetCursor(Resources.Load(subPart + "_cursor") as Texture2D, hotSpot, cursorMode );
            // DesignGrid designGrid = GetComponentInParent<Pallet>().designGrid; //transform.parent.GetComponent<DesignGrid>();
            
            designGrid.current_block = subPart;
        }

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
