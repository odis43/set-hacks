using System.Collections;
using UnityEngine.UI;
using UnityEngine;
using UnityEngine.SceneManagement;

public class timer : MonoBehaviour
{

    public float timeLeft = 10.0f;
    public Text startText; 


    void Update()
    {
        timeLeft -= Time.deltaTime;
        startText.text = (timeLeft).ToString("0");
        if (timeLeft <= 0)
        {
            FindObjectOfType<GameManager>().Endgame();
        }
    }
}