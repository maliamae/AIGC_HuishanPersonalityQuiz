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
        displayText.text = "One: " + count1 + "\n" + "Two: " + count2;
        MBTIDisplayText.text = "Gender: " + gender; // + "\n" + "I/E: " + countI + "/" + countE + "\n" + "S/N: " + countS + "/" + countN + "\n" + "T/F: " + countT + "/" + countF + "\n" + "J/P: " + countJ + "/" + countP;

        for (int i = 1; i < option1Var.Count; i++)
        {
            MBTIDisplayText.text = MBTIDisplayText.text + "\n" + option1Texts[i] + " " + option1Var[i] + "     " + option2Texts[i] + " " + option2Var[i];
            //Debug.Log(option1Texts[i] + " " + option1Var[i]);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
