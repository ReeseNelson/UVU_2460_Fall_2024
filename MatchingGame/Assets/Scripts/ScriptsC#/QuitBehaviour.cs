using UnityEngine.SceneManagement;
using System.Collections;
using UnityEngine;

public class QuitBehaviour : MonoBehaviour
{
    public void QuitGame()
    {
       Application.Quit();
       Debug.Log("Quit!");
    }
}
