using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class PauseScreenButtons : MonoBehaviour
{
    private PlayerScript playerScript;
    // Start is called before the first frame update
    void Start() {
        GameObject player = GameObject.FindWithTag("Player");
        playerScript = player.GetComponent<PlayerScript>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    public void retry()
    {
        playerScript.dead = true;
        Time.timeScale = 1;
        this.gameObject.SetActive(false);
    }

    public void mainMenu()
    {
        SceneManager.LoadScene("MainMenu");
        Time.timeScale = 1;
    }
}
