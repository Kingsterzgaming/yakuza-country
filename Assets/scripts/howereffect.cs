using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;
using UnityEngine.UIElements;

public class howereffect : MonoBehaviour , IPointerEnterHandler, IPointerExitHandler

{
    
    public GameObject description;
 
 
public void OnPointerEnter(PointerEventData eventData)

{
        if (description != null) { description.SetActive(true); }
       
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
        if (description == null)
        {
            Debug.Log("not defined");
        }
    }
}
