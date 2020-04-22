﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory : MonoBehaviour
{
    public GameObject inventory;
    public GameObject slotHolder;
    private bool inventoryEnabled;

    private int slots;
    private Transform[] slot;

    private GameObject itemPickedUp;

    public AudioClip sound;

    // Start is called before the first frame update
    void Start()
    {
        slots = slotHolder.transform.childCount;
        slot = new Transform[slots];
        DetectInventorySlots();
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
        inventory.SetActive(false);

        GetComponent<AudioSource>().playOnAwake = false;
        GetComponent<AudioSource>().clip = sound;

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.I))
        {
            inventoryEnabled = !inventoryEnabled;

            if (inventoryEnabled)
            {
                inventory.SetActive(true);
                Cursor.lockState = CursorLockMode.None;
                Cursor.visible = true;
            }
            else
            {
                inventory.SetActive(false);
                Cursor.lockState = CursorLockMode.Locked;
                Cursor.visible = false;
            }
        }

        /*
        if (inventoryEnabled)
        {
            inventory.SetActive(true);
            Cursor.lockState = CursorLockMode.None;
            Cursor.visible = true;
        }
        else
        {
            inventory.SetActive(false);
            //Cursor.lockState = CursorLockMode.Locked;
            //Cursor.visible = false;
        }
        */
    }

    public void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Item")
        {
            itemPickedUp = other.gameObject;
            AddItem(itemPickedUp);
            GetComponent<AudioSource>().Play();
        }
    }

    public void OnTriggerExit(Collider other)
    {
        /* Only run if we want item to be collectible more than once
        if (other.tag == "Item")
        {
            itemAdded = false;
        }
        */
    }

    public void AddItem(GameObject item)
    {
        for (int i = 0; i < slots; i++)
        {
            if (slot[i].GetComponent<Slot>().empty && itemPickedUp.GetComponent<Item>().itemAdded == false)
            {
                slot[i].GetComponent<Slot>().item = itemPickedUp;
                slot[i].GetComponent<Slot>().itemIcon = itemPickedUp.GetComponent<Item>().icon;
                item.GetComponent<Item>().itemAdded = true;
                item.GetComponent<BoxCollider>().enabled = false;
                item.GetComponent<Renderer>().enabled = false;
            }
        }
    }

    public void DetectInventorySlots()
    {
        for(int i = 0; i < slots; i++)
        {
            slot[i] = slotHolder.transform.GetChild(i);
        }
    }
}
