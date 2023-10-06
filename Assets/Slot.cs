using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
public class Slot : MonoBehaviour,IDropHandler
{
    public GameController GameController;
    public void OnDrop(PointerEventData eventData)
    {
        GameObject dropped = eventData.pointerDrag;
        Draggable draggable = dropped.GetComponent<Draggable>();
        if (transform.childCount == 0)
        {
            draggable.parentAfterDrag = transform;
        }
        else {
            Transform TempParent;



            TempParent = draggable.parentAfterDrag;
            transform.GetChild(0).GetComponent<Draggable>().parentAfterDrag= TempParent;
            transform.GetChild(0).GetComponent<Draggable>().SetPosition();
            draggable.parentAfterDrag = transform;


        }


    }


}
