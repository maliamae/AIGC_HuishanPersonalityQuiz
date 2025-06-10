using UnityEngine;
using UnityEngine.SceneManagement;

public class ResetButton : ButtonControls
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ReturnToStartScene()
    {
        count1 = 0;
        count2 = 0;
        gender = 0;

        for (int i = 1; i < option1Var.Count; i++)
        {
            option1Var[i] = 0;
            option2Var[i] = 0;
        }

        //SceneManager.LoadScene(0, LoadSceneMode.Single);
        LevelManager.Instance.LoadScene(0, "CrossFade");
    }
}
