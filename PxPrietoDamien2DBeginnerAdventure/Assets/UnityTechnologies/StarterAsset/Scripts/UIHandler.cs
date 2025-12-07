using System.Collections;
using System.Collections.Generic;
using System.Xml.Linq;
using UnityEngine;
using UnityEngine.UIElements;

public class UIHandler : MonoBehaviour
{
    private VisualElement m_Healthbar;
    public float displayTime = 4.0f;
    private VisualElement m_NonPlayerDialogue;
    private float m_TimerDisplay;
    public static UIHandler instance { get; private set; }
    //-------------------------------------------------
    private void Awake()
    {
        instance = this;
    }
    // Start is called before the first frame update
    void Start()
    {
        UIDocument uiDocument = GetComponent<UIDocument>();
        m_Healthbar = uiDocument.rootVisualElement.Q<VisualElement>("HealthB");
        SetHealthValue(1.0f);
        m_NonPlayerDialogue = uiDocument.rootVisualElement.Q<VisualElement>("NPCDialogue");
        m_NonPlayerDialogue.style.display = DisplayStyle.None;
        m_TimerDisplay = -1.0f;
    }

    // Update is called once per frame
    public void SetHealthValue(float percentage)
    {
        m_Healthbar.style.width = Length.Percent(100 * percentage); 
    }
    private void Update()
    {
        if (m_TimerDisplay > 0)
        {
            m_TimerDisplay -= Time.deltaTime;
            if (m_TimerDisplay < 0)
            {
                m_NonPlayerDialogue.style.display = DisplayStyle.None;
            }
        }
    }
    public void DisplayDialogue()
    {
        m_NonPlayerDialogue.style.display = DisplayStyle.Flex;
        m_TimerDisplay = displayTime;
    }
}

//Explanations :
//The root of the UI Hierarchy is accessed through rootVisualElement.
//As you’ve encountered previously, the VisualElement is accessed using the dot operator.
//The Q function is short for Query. You can use this function to find a particular VisualElement in the Hierarchy window that matches multiple search parameters — in this case you are using the element name.
//Query is a generic function, because you can use it to query lots of different types. The specific type you are looking for is provided in angle brackets — in this case, it’s a VisualElement named “HealthBar”.
