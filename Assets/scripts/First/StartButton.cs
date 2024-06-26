using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class NavigateSecondScreen : MonoBehaviour
{
    public Button StartButton;
    
    public void Start(){ 
        StartButton = GetComponent<Button>();

        if (StartButton != null)
        {
            StartButton.onClick.AddListener(GameStartFunction);
        }
        else
        {
            Debug.LogError("Button component not found on GameObject: ");
        }
    }

    public void GameStartFunction()
    {
        Debug.Log("New Game started.");
        SceneManager.LoadScene("Third");  // Present Disable Select Level Screen
    }
}
