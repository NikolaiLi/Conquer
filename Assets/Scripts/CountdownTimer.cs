using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class CountdownTimer : MonoBehaviour
{
    public float countdownTime = 59f; // Set your countdown time here
    private float currentTime;
    public Text countdownText;

    void Start()
    {
        currentTime = countdownTime;
        UpdateCountdownText();
    }

    void Update()
    {
        currentTime -= Time.deltaTime;

        if (currentTime <= 0f)
        {
            currentTime = 0f;
            UpdateCountdownText();
            ChangeScene();
        }
        else
        {
            UpdateCountdownText();
        }
    }

    void UpdateCountdownText()
    {
        int seconds = Mathf.FloorToInt(currentTime % 60);
        countdownText.text = seconds.ToString();
    }

    void ChangeScene()
    {
        // Change 'YourNextSceneName' to the name of your next scene
        SceneManager.LoadScene("Main Menu");
    }
}
