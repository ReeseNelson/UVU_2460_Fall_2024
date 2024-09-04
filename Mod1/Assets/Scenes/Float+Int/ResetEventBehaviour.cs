using UnityEngine;
using UnityEngine.Events;

public class ResetEventBehaviour : MonoBehaviour
{
    public GameObject target;

    void Reset()
    {
        //Output the message to the Console
        Debug.Log("Reset");
        if (!target)
            target = GameObject.FindWithTag("Player");
    }
}