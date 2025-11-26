using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;
public class gameManager : MonoBehaviour
   

{
    [Tooltip("Time in seconds to show the first splash scene (flash activity)")]
    public float firstSplashDuration = 2f;

    [Tooltip("Time in seconds to show the second splash scene (flash activity-2)")]
    public float secondSplashDuration = 2f;

    [Tooltip("Name of the next scene after the splash sequence (main ui)")]
    public string mainSceneName = "main ui";

    void Awake()
    {
        DontDestroyOnLoad(gameObject);
    }

    private void Start()
    {
        StartCoroutine(RunSplashSequence());
    }

    private IEnumerator RunSplashSequence()
    {
        // Wait for the first splash duration
        yield return new WaitForSeconds(firstSplashDuration);

        // Load the second splash scene
        Debug.Log("time complete fpr 1st scene");
        SceneManager.LoadScene("flash activity-2");

        yield return new WaitForSeconds(secondSplashDuration);

        
        // Load the main UI scene
        SceneManager.LoadScene(mainSceneName);
        Debug.Log("time complete for 2nd scene");
    }
}
