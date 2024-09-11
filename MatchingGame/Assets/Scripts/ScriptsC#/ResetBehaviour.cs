using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class ResetBehaviour : MonoBehaviour
{
    public void ResetTheGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
