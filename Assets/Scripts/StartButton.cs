using UnityEngine;
using UnityEngine.SceneManagement;

public class StartButton : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void StartQuiz()
    {
        Debug.Log("Click");
        LevelManager.Instance.LoadScene("SceneQ_01", "CrossFade");
        //SceneManager.LoadScene(1, LoadSceneMode.Single);
    }
}
