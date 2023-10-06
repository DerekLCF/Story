using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class BackGround : MonoBehaviour,IDropHandler
{
    public void OnDrop(PointerEventData eventData)
    {

        GameObject dropped = eventData.pointerDrag;
        Draggable draggable = dropped.GetComponent<Draggable>();
        draggable.parentAfterDrag = draggable.ORG_Parent;

    }
}
