using Unity.VisualScripting;
using UnityEngine;

public class collision : MonoBehaviour
{
    public Player player;
    public Game game;
    public over overs;

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
            }
            else
            {
                player.enabled = false;
                Time.timeScale = 0f;
                overs.gameover();
            }
        }
    }


}
