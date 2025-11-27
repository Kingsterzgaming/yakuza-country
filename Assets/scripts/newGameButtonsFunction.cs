using TMPro;
using Unity.VisualScripting;
using Unity.VisualScripting.Antlr3.Runtime.Tree;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class newGameButtonsFunction : MonoBehaviour
{
  
    [Tooltip("assign buttons from action panel")]
    [Header("properties ui time")]
    public Button properties;
    public GameObject propertiesTab;
    [Space(10)]
    [Header("employees ui time")]
    public Button employees;
    public GameObject employeesTab;
    [Space(10)]
    [Header("debts ui time")]
    public Button debts;
    public GameObject debtsTab;
    [Space(10)]
    [Header("Boardroom ui time")]
    public Button boardRoom;
    public GameObject boardRoomTab;
    [Space(10)]
    [Header("ShareHolder Meeting scene time")]
    public Button shareholderMeetings;
    [Space(40)]
    [Tooltip("PROPERTIES BUTTON ACTION LINKS STARTS HERE ")]
    //[Tooltip("assign buttons from PropertiesTab")]
    [Header("PROPERTIES BUTTON ACTION LINKS STARTS HERE")]
    [Header("Properties tab ui time")]
    public Button assign;
    public Button upgrade;
    public Button _properties;
    public Button market;
    [Space(10)]
    [Tooltip("assign buttons from PropertiesTab")]
    [Header("Properties tab ui time")]
    public GameObject assignTab;
    public GameObject upgadeTab;
    public GameObject _propertiesTab;
    public GameObject marketTab;
    private void Awake()
    {
        properties.onClick.AddListener(() => { if (propertiesTab!= null) { propertiesTab.SetActive(true);  Debug.Log("successful1"); }; });
        employees.onClick.AddListener(() => { Debug.Log("successful2"); });
        debts.onClick.AddListener(() => { Debug.Log("successful3"); });
        boardRoom.onClick.AddListener(() => { Debug.Log("successful4"); });
        shareholderMeetings.onClick.AddListener(() => { SceneManager.LoadScene("shareholderMeetings"); Debug.Log("successful0"); });
    }

    void Start()
    {
        
    }

    void Update()
    {
        
    }
}
