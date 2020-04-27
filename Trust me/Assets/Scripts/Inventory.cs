using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Inventory : MonoBehaviour
{
    public GameObject inventory;
    public GameObject slotHolder;
    private bool inventoryEnabled;

    private int slots;
    private Transform[] slot;

    private GameObject itemPickedUp;

    public int polaroidCount;
    public AudioClip sound;
    public GameObject MemoriesUI;
    public GameObject firstPersonCam;
    float timeLeft = 0;

    // Start is called before the first frame update
    void Start()
    {
        polaroidCount = 0;
        slots = slotHolder.transform.childCount;
        slot = new Transform[slots];
        DetectInventorySlots();
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
        inventory.SetActive(false);
        MemoriesUI.SetActive(false);

        GetComponent<AudioSource>().playOnAwake = false;
        GetComponent<AudioSource>().clip = sound;

    }

    // Update is called once per frame
    void Update()
    {
        timeLeft -= Time.deltaTime;
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
            polaroidCount++;
            if (polaroidCount == 5)
            {
                ShowMemories();
            }
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

    void ShowMemories()
    {
        timeLeft = 5;
        // Freeze time and bring up pause menu UI
        MemoriesUI.SetActive(true);
        firstPersonCam.GetComponent<MouseLook>().enabled = false;
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;
        Time.timeScale = 0f;

        //resume
        if (timeLeft <= 0.0f)
        {
            MemoriesUI.SetActive(false);
            firstPersonCam.GetComponent<MouseLook>().enabled = true;
            Cursor.lockState = CursorLockMode.Locked;
            Cursor.visible = false;
            Time.timeScale = 1;
        }
    }
}
