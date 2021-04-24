using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DesignPallet : MonoBehaviour
{
    public string subPart;
    public Vector2 hotSpot = Vector2.zero;
	private CursorMode cursorMode = CursorMode.Auto;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    private void OnMouseDown()
    {
        Debug.Log(subPart + "Clicked");
        Cursor.SetCursor(Resources.Load(subPart + "_cursor") as Texture2D, hotSpot, cursorMode );
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
