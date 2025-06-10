using System.Collections;
using System.Linq;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelManager : MonoBehaviour
{
    public static LevelManager Instance;

    public GameObject transitionsContainer;

    private SceneTransition[] transitions;

    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;

            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }

    private void Start()
    {
        transitions = transitionsContainer.GetComponentsInChildren<SceneTransition>();
    }

    public void LoadScene(int sceneIndex, string transitionName)
    {
        StartCoroutine(LoadSceneAsync(sceneIndex, transitionName));
    }

    private IEnumerator LoadSceneAsync(int sceneIndex, string transitionName)
    {
        SceneTransition transition = transitions.First(t => t.name == transitionName);

        AsyncOperation scene = SceneManager.LoadSceneAsync(sceneIndex);
        scene.allowSceneActivation = false;

        yield return transition.AnimateTransitionIn();

        yield return new WaitForSeconds(.05f);

        scene.allowSceneActivation = true;

        yield return transition.AnimateTransitionOut();
    }
}
