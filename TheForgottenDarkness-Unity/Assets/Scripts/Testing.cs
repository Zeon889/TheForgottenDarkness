using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class Testing : MonoBehaviour
{
    public Button buttonTest;
    public List<SpriteRenderer> slots;
    private int iteration = 0;
    public List<Sprite> items;

    // Start is called before the first frame update
    void Start() 
    {
        buttonTest.onClick.AddListener(() => Debug.Log("Button Pressed!"));
    }
    void Update() { }

    void onButtonClick()
    {
        iteration++;
        if (iteration < 5)
        {
            switch (iteration)
            {
                case 1:
                    slots[1].sprite = items[1];
                    Debug.Log("Action 1");
                    break;
                case 2:
                    slots[2].sprite = items[2];
                    break;
                case 3:
                    slots[3].sprite = items[3];
                    break;
                case 4:
                    slots[4].sprite = items[4];
                    break;
                case 5:
                    slots[5].sprite = items[5];
                    break;
                case 0:
                    break;

            }
        }
    }
}