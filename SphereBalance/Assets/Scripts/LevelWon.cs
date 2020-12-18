using UnityEngine;

public class LevelWon : MonoBehaviour
{
    void OnCollisionEnter()
    {
        FindObjectOfType<GameManager>().LevelComplete();
    }
}
