using UnityEngine;

public class PromptScreen : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            //Debug.Log("Prompt go away");
            LevelManager.Instance.LoadScene(7, "CrossFade");
        }
    }
}
