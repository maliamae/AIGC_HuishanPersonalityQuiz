using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public enum buttonTypes
{
    Option1,
    Option2,
    Option3,
    Option4,
    Male,
    Female,
    Other
}

public class ButtonControls : MonoBehaviour
{
    public buttonTypes type;

    //public static int selectType;

    public static int count1;
    public static int count2;
    public static int count3;
    public static int count4;

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
    public List<string> option1Texts = new List<string>() { string.Empty, "I", "S", "T", "J" };
    public List<string> option2Texts = new List<string>() { string.Empty, "E", "N", "F", "P" };

    public static List<int> option1Var = new List<int>() { 0, countI, countS, countT, countJ };
    public static List<int> option2Var = new List<int>() { 0, countE, countN, countF, countP };

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //selectType = 0;
        currentScene = SceneManager.GetActiveScene().buildIndex;
        TextMeshProUGUI optionText = this.gameObject.GetComponentInChildren<TextMeshProUGUI>();

        //Debug.Log("Current Scene: " + currentScene);

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
        else if (type == buttonTypes.Option3)
        {
            //this.gameObject.GetComponent<Image>().color = Color.red;
            this.gameObject.GetComponentInChildren<TextMeshProUGUI>().text = "3";
        }
        else if (type == buttonTypes.Option4)
        {
            //this.gameObject.GetComponent<Image>().color = Color.pink;
            this.gameObject.GetComponentInChildren<TextMeshProUGUI>().text = "4";
        }
        else if (type == buttonTypes.Male)
        {
            //this.gameObject.GetComponent<Image>().color = Color.pink;
            this.gameObject.GetComponentInChildren<TextMeshProUGUI>().text = "Male";
        }
        else if (type == buttonTypes.Female)
        {
            //this.gameObject.GetComponent<Image>().color = Color.pink;
            this.gameObject.GetComponentInChildren<TextMeshProUGUI>().text = "Female";
        }
        else if (type == buttonTypes.Other)
        {
            //this.gameObject.GetComponent<Image>().color = Color.pink;
            this.gameObject.GetComponentInChildren<TextMeshProUGUI>().text = "Prefer Not to Say";
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void SwapScene()
    {
        //Debug.Log("SWAP");
        currentTransition = transitionNames[currentScene - 1];

        if (type == buttonTypes.Option1)
        {
            option1Var[currentScene]++;

            Debug.Log(option1Var[currentScene]);

            //selectType = 1;
            count1 ++;
        }
        else if (type == buttonTypes.Option2)
        {
            option2Var[currentScene]++;

            Debug.Log(option2Var[currentScene]);
            //selectType = 2;
            count2 ++;
        }
        else if (type == buttonTypes.Option3)
        {
            //selectType = 3;
            count3 ++;
        }
        else if (type == buttonTypes.Option4)
        {
            //selectType = 4;
            count4 ++;
        }
        



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

        LevelManager.Instance.LoadScene(1, "CrossFade");
    }
}
