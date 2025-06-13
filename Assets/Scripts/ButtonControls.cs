using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public enum buttonTypes
{
    Option1,
    Option2,
    Male,
    Female,
    Other
}

public class ButtonControls : MonoBehaviour
{
    public buttonTypes type;

    public static int count1;
    public static int count2;


    public static int countI;
    public static int countE;
    public static int countS;
    public static int countN;
    public static int countT;
    public static int countF;
    public static int countJ;
    public static int countP;

    public static int gender; //0 = Male, 1 = Female, 2 = Other

    public int currentScene;
    public int nextScene;

    public static string currentTransition;

    public List<string> transitionNames = new List<string>() { "CircleWipe", "CircleWipeUp", "CircleWipeLeft", "CircleWipeDown", "CrossFade" };
    public List<string> option1Texts = new List<string>() { string.Empty, "S", "T", "I", "J" };
    public List<string> option2Texts = new List<string>() { string.Empty, "N", "F", "E", "P" };

    public static List<int> option1Var = new List<int>() { 0, countS, countT, countI, countJ };
    public static List<int> option2Var = new List<int>() { 0, countN, countF, countE, countP };

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        currentScene = SceneManager.GetActiveScene().buildIndex;
        TextMeshProUGUI optionText = this.gameObject.GetComponentInChildren<TextMeshProUGUI>();

        if (currentScene > 3)
        {
            nextScene = 5;
        }
        else
        {
            nextScene = currentScene + 1;
        }

        if (type == buttonTypes.Option1)
        {
            optionText.text = option1Texts[currentScene];

            //this.gameObject.GetComponent<Image>().color = Color.white;
            //this.gameObject.GetComponentInChildren<TextMeshProUGUI>().text = "1";
        }
        else if (type == buttonTypes.Option2)
        {
            optionText.text = option2Texts[currentScene];

            //this.gameObject.GetComponent<Image>().color = Color.blue;
            //this.gameObject.GetComponentInChildren<TextMeshProUGUI>().text = "2";
        }
        else if (type == buttonTypes.Male)
        {
            this.gameObject.GetComponentInChildren<TextMeshProUGUI>().text = "Male";
        }
        else if (type == buttonTypes.Female)
        {
            this.gameObject.GetComponentInChildren<TextMeshProUGUI>().text = "Female";
        }
        else if (type == buttonTypes.Other)
        {
            this.gameObject.GetComponentInChildren<TextMeshProUGUI>().text = "Other";
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void SwapScene()
    {
        currentTransition = transitionNames[currentScene - 1];

        if (type == buttonTypes.Option1)
        {
            option1Var[currentScene]++;

            //Debug.Log(option1Var[currentScene]);

            count1 ++;
        }
        else if (type == buttonTypes.Option2)
        {
            option2Var[currentScene]++;

            //Debug.Log(option2Var[currentScene]);
            count2 ++;
        }

        Debug.Log(option1Var[currentScene] + " " +  option2Var[currentScene]);

        //SceneManager.LoadScene(nextScene, LoadSceneMode.Single);
        LevelManager.Instance.LoadScene(nextScene, currentTransition);
    }

    public void SwapSceneGender()
    {
        if (type == buttonTypes.Male)
        {
            gender = 0;
        }
        else if (type == buttonTypes.Female)
        {
            gender = 1;
        }
        else if (type == buttonTypes.Other)
        {
            gender = 2;
        }

        LevelManager.Instance.LoadScene(6, "CrossFade");
    }
}
