using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using Unity.VisualScripting.Antlr3.Runtime.Tree;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
[System.Serializable]
public class Data
{
    int plan;
    public List<string> name = new List<string>();
    public List<string> planPrice = new List<string>();

}
public class newGameButtonsFunction : MonoBehaviour
{
    public Data data;
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
    public GameObject upgradeTab;
    public GameObject _propertiesTab;
    public GameObject marketTab;

    [Space(10)]
    [Tooltip("assign buttons from PropertiesTab")]
    [Header("Properties tab ui time")]
    public Button buttonPrefab;
    public Transform parentpannel;
  
    //data variables 
     //int plan;

    private void Awake()

    {
        //properties main logic 
        properties.onClick.AddListener(() => { if (propertiesTab!= null) { propertiesTab.SetActive(true);  Debug.Log("successful1"); }; });
        //properties sub logic
        assign.onClick.AddListener(()=> {
                                         assignTab.SetActive(true); 
                                         
                                          
                                        });
        upgrade.onClick.AddListener(()=> { });
        _properties.onClick.AddListener(()=> { });
        market.onClick.AddListener(()=> { });


        //employees main logic 
        employees.onClick.AddListener(() => { Debug.Log("successful2"); });
        // employees sub logic 


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
