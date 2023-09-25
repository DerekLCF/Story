using UnityEngine;

public class DraggableObjectWithSnap : MonoBehaviour
{
    private bool isDragging = false;
    private Vector3 offset;
    private bool isSnapped = false;
    public Transform snapTarget;

    private void OnMouseDown()
    {
        isDragging = true;
        offset = transform.position - GetMouseWorldPosition();
        isSnapped = false; // Reset the snapped state when dragging starts
    }

    private void OnMouseUp()
    {
        isDragging = false;

        if (isSnapped)
        {
            // If the object was snapped, detach it from the snap target
            transform.SetParent(null);
        }
    }

    private void OnMouseDrag()
    {
        if (isDragging)
        {
            transform.position = GetMouseWorldPosition() + offset;
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        // Check for a snap target when the object enters a trigger collider
        Debug.Log(other.name);
        snapTarget = other.transform;
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        // Clear the snap target when the object exits a trigger collider
        snapTarget = null;
    }

    private void Update()
    {
        if (isDragging && snapTarget != null && !isSnapped)
        {
            // Snap the object to the snap target
            transform.position = snapTarget.position;
            transform.SetParent(snapTarget);
            isSnapped = true;
        }
    }

    private Vector3 GetMouseWorldPosition()
    {
        Vector3 mousePosition = Input.mousePosition;
        mousePosition.z = -Camera.main.transform.position.z;
        return Camera.main.ScreenToWorldPoint(mousePosition);
    }
}