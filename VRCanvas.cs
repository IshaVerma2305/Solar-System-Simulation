using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VRCanvas : MonoBehaviour
{
    public GazeableButton currentActiveButton;
public Color unselectedColor = Color.white;
public Color selectedColor = Color.green;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void SetActiveButton(GazeableButton activeButton)
    {
if(currentActiveButton!= null)
{
    currentActiveButton.SetButtonColor(unselectedColor);
}
if(activeButton!= null && currentActiveButton!= activeButton)
{
    currentActiveButton = activeButton;
    currentActiveButton.SetButtonColor(selectedColor);
}
else
{
Debug.Log("resetting");
currentActiveButton = null;
}
    }
}
