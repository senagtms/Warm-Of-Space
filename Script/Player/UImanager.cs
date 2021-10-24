using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UImanager : MonoBehaviour
{
    public ObjectManager objectManager;


    public List<Button> DirectionButtonList;

    bool _pressed = false;

    // Start is called before the first frame update
    void Start()
    {
        foreach (var button in DirectionButtonList)
        {

            button.onClick.AddListener(() => TaskOnClick(button));
        }

        /*
        buttonUp.onClick.AddListener(()=>TaskOnClick(buttonUp));
        buttonDown.onClick.AddListener(() => TaskOnClick(buttonDown));
        buttonRight.onClick.AddListener(()=> TaskOnClick(buttonRight));
        buttonLeft.onClick.AddListener(() => TaskOnClick(buttonLeft));
        */
    }
    public void TaskOnClick(Button button)
    {

    }

    private Button currentButton;

    public void PointerDown(Button button)
    {
        currentButton = button;
        _pressed = true;
        //Debug.Log(_pressed);
    }

    public void OnPointerUp()
    {
        currentButton = null;
        _pressed = false;
        //Debug.Log(_pressed);
    }

    void Update()
    {
        if (_pressed)
        {
            if (object.Equals(currentButton, DirectionButtonList[0]))
                objectManager.ObjectUp();
            else if (object.Equals(currentButton, DirectionButtonList[1]))
                objectManager.ObjectDown();
            else if (object.Equals(currentButton, DirectionButtonList[2]))
                objectManager.ObjectRight();
            else if (object.Equals(currentButton, DirectionButtonList[3]))
                objectManager.ObjectLeft();
        }
    }

}
