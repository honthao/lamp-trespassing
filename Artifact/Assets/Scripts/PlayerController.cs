using UnityEngine;
using TMPro;

public class PlayerController : MonoBehaviour
{
    private Rigidbody playerRb; // Player rigid body

    public float speed = 3; // Player speed

    public TextMeshProUGUI scoreText;

    private int score;
    private int walk;
    AudioSource deathSound;
    AudioSource walkSound;

    // Start is called before the first frame update
    private void Start()
    {
        playerRb = GetComponent<Rigidbody>();
        score = 0;
        scoreText.text =  "Score: 0";
        AudioSource[] audios = GetComponents<AudioSource>();
        deathSound = audios[0];
        walkSound = audios[1];
        walk = 0;
    }

    private void FixedUpdate()
    {
        Vector3 oldPosition = playerRb.transform.position;
        Vector3 moveDir = transform.right * Input.GetAxis("Horizontal") + transform.forward * Input.GetAxis("Vertical");
        playerRb.transform.position += moveDir * speed * Time.deltaTime;
        if((oldPosition - playerRb.transform.position).magnitude >= 0.02f){
            walk += 1;
            if(walk % 20 == 0)
            {
                walkSound.Play();
            }
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Lamp"))
        {
            other.gameObject.SetActive(false);
            score += 1;
            scoreText.text =  "Score: " + score.ToString();
            deathSound.Play();
            
        }
    }

    public void Reset()
    {
        score = 0;
        scoreText.text =  "Score: 0";
        transform.position = new Vector3(-2.5f, 0.5f, -1.5f);
    }
}

