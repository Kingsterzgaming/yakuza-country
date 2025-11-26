using Unity.VisualScripting.Antlr3.Runtime.Tree;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class onclick : MonoBehaviour
{
    [Tooltip("name of the button for perfect action")]
    [Header("New game button and scene")]
    public Button newGame;
    public string newGameClickAction;
    [Space(10)]
    [Header("Multiplayer mini game button and scene")]
    public Button multiplayerMinigames;
    public string multiplayerGameClickAction;
    [Space(10)]
    [Header("settings button and scene")]
    public Button settings;
    public string settingsClickAction;
    [Space(10)]
    [Header("dlc  button and scene")]
    public Button purchaseDlc;
    
    [Space(10)]
    [Header("License button and scene")]
    public Button license;
    [Space(10)]
    [Header("Exit game logic")]
    public Button exit;
    //private GameObject exitChoice;
    public GameObject exitChoice;

    //private string exitChoiceName = "exit pannel";
   

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        newGame.onClick.AddListener(loadscene);
        exit.onClick.AddListener(quitOption);
    }
    void loadscene()
    {
        SceneManager.LoadScene(newGameClickAction);
    }
    void quitOption()
    {
        //exitChoice = GameObject.Find(exitChoiceName);

        if (exitChoice != null)
        {
            exitChoice.SetActive(true);
        }
        else { Debug.Log("not declared /not find"); }
    
    }

    // Update is called once per frame
    //void Update()
    //{
        
    //}
}
