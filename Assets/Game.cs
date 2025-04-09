using UnityEngine;
using UnityEngine.UI;
using TMPro;
public class Game : MonoBehaviour
{
    public TextMeshProUGUI score;
    int myscore = 0;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        score.text = myscore.ToString();
    }
    public void Add(int scores)
    {
        myscore = myscore + scores;
    }
   public int GetScore()
    {
        return myscore;
    }
}
