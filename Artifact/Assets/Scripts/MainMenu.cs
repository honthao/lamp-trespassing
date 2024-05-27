using UnityEngine;

public class MainMenu : MonoBehaviour
{
    public Rigidbody player;

    public GameObject playerCam;

    public GameObject helpPanel;

    // Start is called before the first frame update
    private void Start()
    {
        ShowMenu();
    }

    private void FixedUpdate()
    {
        // disable PlayerController & MouseRotator scripts to stop the player from moving
        player.gameObject.GetComponent<PlayerController>().enabled = false;
        playerCam.GetComponent<MouseRotator>().enabled = false;
    }

    public void Play()
    {
        gameObject.SetActive(false);

        // allow player to move
        player.gameObject.GetComponent<PlayerController>().enabled = true;
        playerCam.GetComponent<MouseRotator>().enabled = true;
    }

    public void ShowHelpPanel()
    {
        helpPanel.SetActive(true);
    }

    public void ShowMenu()
    {
        gameObject.SetActive(true);
        helpPanel.SetActive(false);
    }
}
