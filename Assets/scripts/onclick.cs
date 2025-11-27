using Unity.VisualScripting.Antlr3.Runtime.Tree;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class onclick : MonoBehaviour, IPointerExitHandler, IPointerEnterHandler
{
    [Tooltip("for hower description and")]
    [Header("assign current game objects for hower description")]
    public GameObject description;
    public GameObject currentAssignedButton;
    [Space(10)]

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
    [Tooltip("exit button pannel")]
    public GameObject exitPannel;
    //private string exitChoiceName = "exit pannel";
    public Button YesButton;
    public Button NoButton;




    public void OnPointerEnter(PointerEventData eventData) {
        if (currentAssignedButton != null) { Debug.Log(currentAssignedButton.name); description.SetActive(true); }
    }
    public void OnPointerExit(PointerEventData eventData) { description.SetActive(false); }
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        newGame.onClick.AddListener(loadscene);
        //multiplayerMinigames.onClick.AddListener(loadscene);
        //settings.onClick.AddListener(loadscene);
        //purchaseDlc.onClick.AddListener(loadscene);
        //license.onClick.AddListener(loadscene);
        exit.onClick.AddListener(quitOption);
        
    }
    void loadscene()
    {
        SceneManager.LoadScene(newGameClickAction);
    }
    void quitOption()
    {
        //exitChoice = GameObject.Find(exitChoiceName);

        if (exitPannel != null)
        {
            exitPannel.SetActive(true);
            YesButton.onClick.AddListener(() => { Application.Quit(); exitPannel.SetActive(false); Debug.Log("application exit"); });
            NoButton.onClick.AddListener(() => { exitPannel.SetActive(false); Debug.Log("pannel closed"); });
        }
        else { Debug.Log("not declared /not find"); }
    
    }

    // Update is called once per frame
    //void Update()
    //{
        
    //}
}
