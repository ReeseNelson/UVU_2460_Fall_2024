using System.Collections;
using UnityEngine;
using UnityEngine.Events;

public class MatchBehaviour : MonoBehaviour
{
    public ID idObj;
    public UnityEvent matchEvent, noMatchEvent, noMatchDelayedEvent;
    
    private IEnumerator OnTriggerEnter(Collider other)
    {
        var tempObj = other.GetComponent<IDContainerBehaviour>();
        if (tempObj == null)
            yield break;
        
        var otherID = tempObj.idObj;
        if (otherID == idObj)
        {
            Debug.Log("Match");
            matchEvent.Invoke();
            

        }
        else
        {
           Debug.Log("NO Match");
           noMatchEvent.Invoke();
           yield return new WaitForSeconds(0.5f);
           noMatchDelayedEvent.Invoke();

        }
    } 
}
