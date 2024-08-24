using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu]
public class Intdatascript : ScriptableObject
{
    public int value;

    public void UpdateValue(int num)
    {
        value += num;
    }

}
