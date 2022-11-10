using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public GameObject aboutScreen;
    public GameObject creditScreen;
    public GameObject controlScreen;
    public GameObject optionScreen;
    public GameObject mainScreen;
    internal Animator animator;

    // Start is called before the first frame update
    void Start()
    {
        aboutScreen.SetActive(false);
        creditScreen.SetActive(false);
        controlScreen.SetActive(false);
        optionScreen.SetActive(false);
        mainScreen.SetActive(true);
        animator = GetComponent<Animator>();
    }

    public void StartGame()
    {
        SceneManager.LoadScene("Final Level");
    }

    public void LoadAboutScreen()
    {
        animator.SetTrigger("MainToAbout");
    }

    public void LoadCreditScreen()
    {
        animator.SetTrigger("AboutToCredits");
    }

    public void LoadControlsScreen()
    {
        animator.SetTrigger("AboutToControls");
    }

    public void LoadOptionsScreen()
    {
        animator.SetTrigger("MainToOptions");
    }

    public void CreditstoAbout()
    {
        animator.SetTrigger("CreditsToAbout");
    }

    public void ControlstoAbout()
    {
        animator.SetTrigger("ControlsToAbout");
    }

    public void AbouttoMainScreen()
    {
        animator.SetTrigger("AboutToMain");
    }

    public void OptionstoMainScreen()
    {
        animator.SetTrigger("OptionsToMain");
    }

    public void QuitGame()
    {
        Debug.Log("Quit Game");
        Application.Quit();
    }
}
