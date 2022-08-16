using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DraggableList : MonoBehaviour
{
    private List<Draggable> draggables = new List<Draggable>();
    [SerializeField] private GameObject placedWords;

    private static DraggableList instance;

    private void Awake()
    {
        if(instance != null)
        {
            Destroy(gameObject);
        }
        else
        {
            instance = this;
        }
    }


    public static void InputDraggable(Draggable draggable, Vector2 mousePosition)
    {
        if(instance.draggables.Count == 0)
        {
            instance.draggables.Add(draggable);
            draggable.gameObject.transform.parent = instance.placedWords.transform;
        }
    }

}
