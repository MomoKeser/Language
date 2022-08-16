using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Draggable : MonoBehaviour, IDragHandler, IDropHandler
{
    #region DEBUG_TEST
    private Vector3 originalPosition;

    private void Awake()
    {
        originalPosition = transform.position;
    }
    #endregion

    public void OnDrag(PointerEventData pointerEventData)
    {
        transform.position = pointerEventData.position;
    }

    public void OnDrop(PointerEventData pointerEventData)
    {
        transform.position = originalPosition;
        DraggableList.InputDraggable(this, pointerEventData.position);
    }
}
