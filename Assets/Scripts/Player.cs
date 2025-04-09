using UnityEngine;

public class Player : MonoBehaviour
{
    public float speed;
    public float force;
    public Rigidbody rb;
    public float maxX;
    public float minX;
    private Renderer playerRenderer;
    private float colorTimer = 0f;
    private float colorChangeInterval = 3f;
    private int colorIndex = 0;
    public Color[] colors = new Color[3];
   
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb=GetComponent<Rigidbody>();
        playerRenderer = GetComponent<Renderer>();
        playerRenderer.material.color=colors[colorIndex];

    }

    // Update is called once per frame
    void Update()
    {
        Vector3 playerpo = transform.position;
        if (playerpo.x < minX)
        {
            playerpo.x = minX;
        }
        transform.position = playerpo;
        if (playerpo.x > maxX)
        {
            playerpo.x = maxX;
        }
        transform.position = playerpo;
        if (Input.GetKey(KeyCode.RightArrow) || (Input.GetKey(KeyCode.A)))
        {
            transform.position = transform.position + new Vector3(speed * Time.deltaTime, 0, 0);
        }
        if (Input.GetKey(KeyCode.LeftArrow) || (Input.GetKey(KeyCode.D))){
            transform.position = transform.position - new Vector3(speed * Time.deltaTime, 0, 0);
        }
        
          colorTimer += Time.deltaTime;
        if (colorTimer >= colorChangeInterval)
        {
            colorIndex = (colorIndex + 1) % colors.Length;
            playerRenderer.material.color = colors[colorIndex];
            colorTimer = 0f;
        }

    }
    private void FixedUpdate()
    {
        rb.AddForce(0,0,force*Time.deltaTime);  
    }
   
}
