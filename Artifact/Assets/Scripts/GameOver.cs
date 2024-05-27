using UnityEngine;
using TMPro;

public class GameOver : MonoBehaviour
{
    public Rigidbody player;

    public GameObject playerCam;

    public GameObject[] lamps;

    public TextMeshProUGUI resultText;

    public MainMenu mainMenu;

    // Start is called before the first frame update
    private void Start()
    {
        Reset();
    }

    // Update is called once per frame
    private void Update()
    {

    }

    public void ShowResult(string result)
    {
        gameObject.SetActive(true);
        resultText.text = result;

        // disable PlayerController & MouseRotator scripts to stop the player from moving
        player.gameObject.GetComponent<PlayerController>().enabled = false;
        playerCam.GetComponent<MouseRotator>().enabled = false;
    }

    public void Reset()
    {
        gameObject.SetActive(false);

        // allow player to move
        player.gameObject.GetComponent<PlayerController>().enabled = true;
        playerCam.GetComponent<MouseRotator>().enabled = true;

        // reset player to its start position & revive enemies
        player.transform.position = new Vector3(-2.5f, 0.5f, -1.5f);
        foreach (GameObject lamp in lamps) {
            lamp.SetActive(true);
        }
    }

    public void ReturnHome()
    {
        Reset();
        mainMenu.ShowMenu();
    }
}
