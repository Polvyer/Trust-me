using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class Slot : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler, IPointerClickHandler
{
    public bool hovered;
    public bool empty;

    public GameObject item;
    public Texture itemIcon;

    // Start is called before the first frame update
    void Start()
    {
        hovered = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (item)
        {
            empty = false;
            itemIcon = item.GetComponent<Item>().icon;
            this.GetComponent<RawImage>().texture = itemIcon;
        }
        else
        {
            empty = true;
        }
    }

    // Runs when the mouse cursor is hovering over the specific inventory slot
    public void OnPointerEnter(PointerEventData eventData)
    {
        hovered = true;
    }

    // Runs when the mouse cursor is no longer hovering over the specific inventory slot
    public void OnPointerExit(PointerEventData eventData)
    {
        hovered = false;
    }

    // Runs when the mouse cursor clicks on the specific inventory slot
    public void OnPointerClick(PointerEventData eventData)
    {
        if (item)
        {
            Item thisItem = item.GetComponent<Item>();

            // checking for item type
        }
    }
}
