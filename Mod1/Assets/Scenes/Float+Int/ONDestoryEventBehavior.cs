using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;

public class ONDestoryEventBehavior : MonoBehaviour
{
    
    void Start()
    {
        Debug.Log("Start2");
    }

    void OnEnable()
    {
        Debug.Log("OnEnable2");
    }

    // generate a message when the game shuts down
    void OnDestroy()
    {
        Debug.Log("OnDestroy2");
    }
}