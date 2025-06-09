using TMPro;
using UnityEngine;

public class DisplayText : ButtonControls
{
    //ButtonControls buttonControls;
    public TextMeshProUGUI displayText;
    public TextMeshProUGUI MBTIDisplayText;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        /*
        if (selectType == 1)
        {
            displayText.text = "Selected Button: " + "1";
        }
        else if (selectType == 2)
        {
            displayText.text = "Selected Button: " + "2";
        }
        else if (selectType == 3)
        {
            displayText.text = "Selected Button: " + "3";
        }
        else if (selectType == 4)
        {
            displayText.text = "Selected Button: " + "4";
        }
        */

        displayText.text = "One: " + count1 + "\n" + "Two: " + count2 + "\n" + "Three: " + count3 + "\n" + "Four: " + count4;
        MBTIDisplayText.text = "Gender: " + gender + "\n" + "I/E: " + countI + "/" + countE + "\n" + "S/N: " + countS + "/" + countN + "\n" + "T/F: " + countT + "/" + countF + "\n" + "J/P: " + countJ + "/" + countP;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
