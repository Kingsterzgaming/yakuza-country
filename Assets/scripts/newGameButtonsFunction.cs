using TMPro;
using Unity.VisualScripting;
using Unity.VisualScripting.Antlr3.Runtime.Tree;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class newGameButtonsFunction : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
    [Space(10)]
    [Header("employees ui time")]
    private GameObject btn;
    private string desname = "abra ka dabra , soon going to update via json ";
    public GameObject description;
    public TMP_Text title;
    void Awake()
    {
        btn = this.gameObject;
    }

    [Tooltip("assign buttons from action panel")]
    [Header("properties ui time")]
    public Button properties;
    [Space(10)]
    [Header("employees ui time")]
    public Button employees;
    [Space(10)]
    [Header("debts ui time")]
    public Button debts;
    [Space(10)]
    [Header("Boardroom ui time")]
    public Button boardRoom;
    [Space(10)]
    [Header("ShareHolder Meeting scene time")]
    public Button shareholderMeetings;
    public void OnPointerEnter(PointerEventData eventData) 
    { 
        if (description != null)
        {
           description.SetActive(true);
            title.text = desname;
            
        }
    }

   

    public void OnPointerExit(PointerEventData eventData) 
    {
        description.SetActive(false);
    }
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
