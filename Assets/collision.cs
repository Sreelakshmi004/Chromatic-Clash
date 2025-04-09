using Unity.VisualScripting;
using UnityEngine;

public class collision : MonoBehaviour
{
    public Player player;
    public Game game;
    public over overs;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "no")
        {
            player.enabled = false;
            Time.timeScale = 0f;
            overs.gameover();
        }
    }
    private void OnTriggerEnter(Collider collision)
    {
          if (collision.gameObject.CompareTag("collectable")){
            Destroy(collision.gameObject);
            game.Add(1);
        }
    }
 
}
