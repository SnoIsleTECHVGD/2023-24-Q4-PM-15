using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using UnityEngine.Rendering;

public class DragAndDrop : MonoBehaviour
{
    // Start is called before the first frame update
    public bool isSelected;
    public void Select()
    {
        transform.position = new Vector3(Input.mousePosition.x, Input.mousePosition.y, 0);
    }

    public void OnMouseDown()
    {
        transform.position = new Vector3(Input.mousePosition.x, Input.mousePosition.y, 0);
    }
}
