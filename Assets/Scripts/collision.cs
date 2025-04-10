using Unity.VisualScripting;
using UnityEngine;

public class collision : MonoBehaviour
{
    public Player player;
    public Game game;
    public over overs;
    public AudioSource audio2;
    public GameObject congrats;
  

    private void OnTriggerEnter(Collider other)
    {
        Renderer playerRenderer = player.GetComponent<Renderer>();
        Renderer obstacleRenderer = other.GetComponent<Renderer>();

        if (playerRenderer != null && obstacleRenderer != null)
        {
            Color32 playerColor = playerRenderer.material.color;
            Color32 obstacleColor = obstacleRenderer.material.color;

            if (playerColor.Equals(obstacleColor))
            {
                Destroy(other.gameObject);
                game.Add(1);
                audio2.Play();
               
            }
            else
            {
                player.enabled = false;
                Time.timeScale = 0f;
                overs.gameover();
                overs.audio3.Pause();
                congrats.SetActive(false);
            }
        }

    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("END"))
        {
            congrats.SetActive(true);
        }
      
    }


}
