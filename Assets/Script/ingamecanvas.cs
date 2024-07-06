using UnityEngine;

public class PauseButton : MonoBehaviour
{
    private bool isPaused = false;

    public void TogglePause()
    {
        isPaused = !isPaused; // Toggle pause state

        if (isPaused)
        {
            PauseGame();
        }
        else
        {
            ResumeGame();
        }
    }

    void PauseGame()
    {
        Time.timeScale = 0f; // Pause the game by setting time scale to 0
        // Optionally, you can show a pause menu UI or perform other pause-related tasks
        Debug.Log("Game Paused");
    }

    void ResumeGame()
    {
        Time.timeScale = 1f; // Resume normal time scale
        // Optionally, you can hide the pause menu UI or perform tasks to resume gameplay
        Debug.Log("Game Resumed");
    }

    public void QuitGame()
    {
        // Quit the application
        Debug.Log("Game Quit");
        Application.Quit();

        // If running in the Unity editor, stop play mode (only works in the editor)
#if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
#endif
    }
}
