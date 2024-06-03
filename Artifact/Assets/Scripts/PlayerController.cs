using UnityEngine;
using TMPro;

public class PlayerController : MonoBehaviour
{
    private Rigidbody playerRb; // Player rigid body

    public float speed = 3; // Player speed

    public TextMeshProUGUI scoreText;

    public TextMeshProUGUI keyText;

    private int score;

    private int walk;

    private bool foundKey;

    AudioSource deathSound;

    AudioSource walkSound;

    private GameObject key;

    public GameObject door;

    public GameObject doorText;

    public GameOver gameOver;

    // Start is called before the first frame update
    private void Start()
    {
        playerRb = GetComponent<Rigidbody>();
        score = 0;
        scoreText.text =  "Score: 0";
        keyText.text = "Key: <color=red>Not Found</color>";
        foundKey = false;
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
        if (other.gameObject.CompareTag("Lamp")) {
            other.gameObject.SetActive(false);
            score += 1;
            scoreText.text =  "Score: " + score.ToString();
            deathSound.Play();
        } else if (other.gameObject.CompareTag("Key")) {
            foundKey = true;
            key = other.gameObject;
            key.SetActive(false);
            keyText.text = "Key: <color=green>Found</color>";
            door.transform.localRotation = Quaternion.Euler(0, -35, 0); // open door
            doorText.SetActive(false);
        } else if (other.gameObject.CompareTag("Doormat") && foundKey) {
            gameOver.ShowResult("You win!");
        }
    }

    public void Reset()
    {
        score = 0;
        scoreText.text =  "Score: 0";
        transform.position = new Vector3(-3.9f, 0.5f, -1.8f);
        foundKey = false;
        keyText.text = "Key: <color=red>Not Found</color>";
        if (key) {
            key.SetActive(true);
        }
        door.transform.localRotation = Quaternion.Euler(0, 0, 0); // close door
        doorText.SetActive(true);
        walk = 0;
    }
}

