using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class CoroutineBehviour : MonoBehaviour
{
    public UnityEvent startEvent,startCountEvent, repeatCountEvent, endCountEvent, repeatUntilFalseEvent;

    public bool CanRun { get; set; }
    public IntData counterNum;
    public float seconds = 3.0f;
    private WaitForSeconds wfsObj; 
    private WaitForFixedUpdate wffuObj;
    
    private void Start()
    {
        wfsObj = new WaitForSeconds(seconds);
        wffuObj = new WaitForFixedUpdate();
        startEvent.Invoke();
    }
    
    public void StartCounting()
    {
        StartCoroutine(Counting());
    }
    
    private IEnumerator Counting()
    {

        yield return wfsObj;
        
        startCountEvent.Invoke();
        yield return wfsObj; 
        
        while(counterNum.value > 0)
        {
            repeatCountEvent.Invoke();
            counterNum.value--;
            yield return wfsObj;
        }    
        
        endCountEvent.Invoke();
    }
    
    public void StartRepeatUntilFalse()
    {
        CanRun = true;
        StartCoroutine(RepeatUntilFalse());
    }
    
    private IEnumerator RepeatUntilFalse () 
    {
        while (CanRun)
        {
            yield return wfsObj;
            repeatUntilFalseEvent.Invoke();
        } 
    }
}