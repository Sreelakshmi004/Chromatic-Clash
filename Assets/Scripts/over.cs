using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class over : MonoBehaviour
{
    public GameObject panel;
    public GameObject restart;
    public TextMeshProUGUI finish;
    public GameObject quit;
    public GameObject tap;
    public GameObject score;
    public TextMeshProUGUI fscore;
    private int currentscore;
    public TextMeshProUGUI large;
    private int lscore;
    public AudioSource audio1;
    public AudioSource audio3;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        panel.SetActive(false);
        score.SetActive(true);
        tap.SetActive(true);
        Time.timeScale = 0f;
        fscore.enabled = false;
        large .enabled = false;
        audio3.loop = true;
       
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Mouse0))
        {
            startgame();  
        }
    }
    public void gameover()
    {

        Time.timeScale = 0f;
        panel.SetActive(true);
        score.SetActive(true);
        currentscore=FindFirstObjectByType<Game>().GetScore();
        fscore.text = "Current:" + currentscore;
        fscore.enabled = true;
        updatescore();
        large.enabled = true;
        audio1.Play();
    
    }

    public void startgame()
    {
        score.SetActive(true);
        tap.SetActive(false);
        Time.timeScale = 1f;
        audio3.Play();
    }
    public void restarts()
    {
        SceneManager.LoadScene("SampleScene");

    }
    public void quits()
    {
        Application.Quit();
        Time.timeScale = 0f;
    }

    public void updatescore()
    {
        lscore = PlayerPrefs.GetInt("Top", 0);
        if (currentscore > lscore)
        {
            lscore = currentscore;
            PlayerPrefs.SetInt("Top", lscore);
            PlayerPrefs.Save();
           
            
        }
        large.text = "Top:" + lscore;
    }
}
