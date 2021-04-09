using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    [SerializeField] GameObject pauseMenu;
    [SerializeField] PlayerCollison playerCollision;
    [SerializeField] EndTrigger endTrigger;
    [SerializeField] PlayerMovement playerMovement;
    [SerializeField] GameObject levelCompletePanel;
    private float restartDelay = 2f;

    private void Awake()
    {
        playerCollision.GameOver += GameOver;
        endTrigger.LevelComplete += LevelComplete;
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape) && !levelCompletePanel.activeInHierarchy) PauseMenu();
    }

    private void GameOver()
    {
        Invoke(nameof(RestartGame), restartDelay);
    }

    private void LevelComplete()
    {
        levelCompletePanel.SetActive(true);
    }

    private void RestartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    private void PauseMenu()
    {
        if (pauseMenu.activeInHierarchy)
        {
            pauseMenu.SetActive(false);
            Cursor.lockState = CursorLockMode.Locked;
            Cursor.visible = false;
            playerMovement.enabled = true;
        }
        else
        {
            pauseMenu.SetActive(true);
            Cursor.lockState = CursorLockMode.None;
            Cursor.visible = true;
            playerMovement.enabled = false;
        } 
    }
}
