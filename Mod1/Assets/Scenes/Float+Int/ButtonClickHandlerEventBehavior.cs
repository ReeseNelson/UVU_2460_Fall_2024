using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

public class ButtonClickHandler : MonoBehaviour
{
    // Define a UnityEvent
    [System.Serializable]
    public class ClickEvent : UnityEvent { }

    // Create an instance of the UnityEvent
    public ClickEvent onButtonClick;

    // Reference to the Button component
    public Button myButton;

    void Start()
    {
        if (myButton != null)
        {
            // Add the event listener to the button's onClick event
            myButton.onClick.AddListener(HandleButtonClick);
        }
    }

    void HandleButtonClick()
    {
        // Invoke the UnityEvent when the button is clicked
        if (onButtonClick != null)
        {
            onButtonClick.Invoke();
        }
    }
}

