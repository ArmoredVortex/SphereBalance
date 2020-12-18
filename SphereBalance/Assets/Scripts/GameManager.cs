using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    bool GameRunning = true ;
    // public GameObject levelCompleteUI;
    public void LevelComplete()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
    public void EndGame(){
        if(GameRunning)
        {
            // Debug.Log("Level Lost");
            GameRunning = false;
            Invoke("restart",1f);
        }
    }
    void restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
