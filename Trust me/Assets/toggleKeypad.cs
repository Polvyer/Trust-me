using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class toggleKeypad : MonoBehaviour
{
    public CanvasGroup canvasGroup;
    private bool state = false;
    private string input = ""; // player input
    public string keypadPin = "1234";
    public bool unlockDoor = false;

    public GameObject item; // player character
    public Transform guide; // keypad cube
    public GameObject firstPersonCam;

    public Button button0,button1,button2,button3,button4,button5,button6,button7,button8,button9,buttonClear,buttonAccept;


    void Start()
    {
        button0.onClick.AddListener(buttonClick0);
        button1.onClick.AddListener(buttonClick1);
        button2.onClick.AddListener(buttonClick2);
        button3.onClick.AddListener(buttonClick3);
        button4.onClick.AddListener(buttonClick4);
        button5.onClick.AddListener(buttonClick5);
        button6.onClick.AddListener(buttonClick6);
        button7.onClick.AddListener(buttonClick7);
        button8.onClick.AddListener(buttonClick8);
        button9.onClick.AddListener(buttonClick9);
        buttonAccept.onClick.AddListener(buttonClickAccept);
        buttonClear.onClick.AddListener(buttonClickClear);
    }
    // Update is called once per frame
    void Update()
    {
        float distance = Vector3.Distance(item.transform.position, guide.transform.position);
        print(input);
        
        if (Input.GetKeyDown(KeyCode.E) && state == false && distance < 3){

            firstPersonCam.GetComponent<MouseLook>().enabled = false;
            Cursor.lockState = CursorLockMode.None;
            Cursor.visible = true;

            Show();
            state = true;
            
        }
        else if(Input.GetKeyDown(KeyCode.E) || distance > 3)
        {
            firstPersonCam.GetComponent<MouseLook>().enabled = true;
            Cursor.lockState = CursorLockMode.Locked;
            Cursor.visible = false;
            Hide();
            input = "";
            state = false;
        }
    }

    void Hide()
    {
        canvasGroup.alpha = 0f; //this makes everything transparent
        canvasGroup.blocksRaycasts = false; //this prevents the UI element to receive input events
    }

    void Show()
    {
        canvasGroup.alpha = 1f; 
        canvasGroup.blocksRaycasts = true; 
    }

    void buttonClick0()
    {
        input += "0";
    }
    void buttonClick1()
    {
        input += "1";
    }
    void buttonClick2()
    {
        input += "2";
    }
    void buttonClick3()
    {
        input += "3";
    }
    void buttonClick4()
    {
        input += "4";
    }
    void buttonClick5()
    {
        input += "5";
    }
    void buttonClick6()
    {
        input += "6";
    }
    void buttonClick7()
    {
        input += "8";
    }
    void buttonClick8()
    {
        input += "8";
    }
    void buttonClick9()
    {
        input += "9";
    }
    void buttonClickClear()
    {
        input = "";
    }

    void buttonClickAccept()
    {
        if(input == keypadPin)
        {
            unlockDoor = true;
            //Debug.Log("Correct pin entered");
        }
    }

}
