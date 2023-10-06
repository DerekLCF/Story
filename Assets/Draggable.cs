using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
public class Draggable : MonoBehaviour,IBeginDragHandler,IDragHandler, IEndDragHandler,IPointerClickHandler 
{
    public Transform ORG_Parent;
    public GameController GameController;
    public Transform parentAfterDrag;
    public Image image;
    public void Start( )
    {
        ORG_Parent = transform.parent;
    }
    public void OnBeginDrag(PointerEventData eventData)
    {
        parentAfterDrag = transform.parent;
        transform.SetParent(transform.root);
        transform.SetAsLastSibling();
        image.raycastTarget = false;
    }

    public void OnDrag(PointerEventData eventData)
    {
        transform.position = Input.mousePosition;
    }

    public void OnEndDrag(PointerEventData eventData)
    {
        transform.SetParent(parentAfterDrag);
        image.raycastTarget = true;
        GameController.CheckWin();
    }
    public void SetPosition()
    {

        if (parentAfterDrag.TryGetComponent(out Slot slot))
        {
            transform.SetParent(parentAfterDrag);
        }
        else {
            transform.SetParent(ORG_Parent);
        }
  
        GameController.CheckWin();
    }

    public void OnPointerClick(PointerEventData eventData)
    {
        if (eventData.button == PointerEventData.InputButton.Right)
        {
            parentAfterDrag = ORG_Parent;
            transform.SetParent(parentAfterDrag);
        }
    }
}
