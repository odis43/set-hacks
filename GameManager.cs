
using UnityEngine;
using UnityEngine.SceneManagement;
public class GameManager : MonoBehaviour
{
    bool GamehasEnded = false;
    public float delay;
    public void EndGame()
    {
        if (GamehasEnded == true)
        {
            GamehasEnded = false;
            
            Debug.Log("GAME OVER");
            
        }

    }

   
    public void Math()
    {
        SceneManager.LoadScene("math");
        Invoke("math", delay);
        
    }
    public void Game()
    {
        SceneManager.LoadScene("THEGAME");
        Invoke("THEGAME", delay);
    }

    public void Endgame()
    {
        SceneManager.LoadScene("end");
        Invoke("end", delay);
    }

}
