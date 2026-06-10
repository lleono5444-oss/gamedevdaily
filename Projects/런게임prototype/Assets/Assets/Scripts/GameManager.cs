using TMPro;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.SceneManagement;
public class GameManager : MonoBehaviour
{
    public static GameManager instance; 

    public bool isGameover = false; 
    public TextMeshProUGUI scoreText;
    public TextMeshProUGUI highestscoreText;
    public GameObject gameoverUI;

   
    private int score = 0;
    private int highestscore = 0;

    private void Awake()
    {
        if(instance == null)
        {
            instance = this;
        }
        else
        {
            Destroy(gameObject);
        }
    }

    private void Update()
    {
        if(isGameover && Mouse.current.leftButton.wasPressedThisFrame)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
        if (isGameover) return;
        
        
    }

    public void AddScore(int newScore) 
    {
        if (!isGameover)
        {
            score += newScore;
            scoreText.text = "Score : " + score;
            
        }
    }
    public void OnplayerDead()
    {
        isGameover = true;
        if(highestscore < score) highestscore = score;
        highestscoreText.text = "highest score : " + highestscore;
        gameoverUI.SetActive(true);
    }
}