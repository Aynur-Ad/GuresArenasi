using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager_sc : MonoBehaviour
{
    public AudioSource uiSource;
    public AudioClip winSound;
    public AudioClip loseSound;

    public GameObject winPanel;
    public GameObject losePanel;

    public bool gameEnded = false;

    public void PlayerLost()
    {
        Object.FindFirstObjectByType<PlayerControl_sc>().powerText.gameObject.SetActive(false);

        if (gameEnded)
        {
            return;
        }
        gameEnded = true;

        uiSource.PlayOneShot(loseSound);
        losePanel.SetActive(true);
    }

    public void PlayerWon()
    {
        Object.FindFirstObjectByType<PlayerControl_sc>().powerText.gameObject.SetActive(false);

        if (gameEnded)
        {
            return;
        }
        gameEnded = true;

        uiSource.PlayOneShot(winSound);
        winPanel.SetActive(true);
    }

    public void RestartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    public void GoBackToMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }
}
