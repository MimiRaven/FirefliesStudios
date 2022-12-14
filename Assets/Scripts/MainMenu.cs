using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public GameObject aboutScreen;
    public GameObject creditScreen;
    public GameObject controlScreen;
    public GameObject optionScreen;
    public GameObject mainScreen;
    public AudioMixer audioMixer;
    public TMPro.TMP_Dropdown resolutionDropdown;
    Resolution[] resolutions;
    internal Animator animator;

    // Start is called before the first frame update
    void Start()
    {
        resolutions = Screen.resolutions;

        resolutionDropdown.ClearOptions();

        List<string> options = new List<string>();

        int currentResolutionIndex = 0;

        for (int i = 0; i < resolutions.Length; i++)
        {
            string option = resolutions[i].width + " x " + resolutions[i].height;
            options.Add(option);

            if (resolutions[i].width == Screen.currentResolution.width && resolutions[i].height == Screen.currentResolution.height)
            {
                currentResolutionIndex = i;
            }
        }

        resolutionDropdown.AddOptions(options);
        resolutionDropdown.value = currentResolutionIndex;
        resolutionDropdown.RefreshShownValue();

        aboutScreen.SetActive(false);
        creditScreen.SetActive(false);
        controlScreen.SetActive(false);
        optionScreen.SetActive(false);
        mainScreen.SetActive(true);
        animator = GetComponent<Animator>();
    }

    public void StartGame()
    {
        SceneManager.LoadScene("UpdateLevel");
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

    public void SetVolume (float volume)
    {
        audioMixer.SetFloat("Volume", volume);
    }

    public void SetResolution(int resolutionIndex)
    {
        Resolution resolution = resolutions[resolutionIndex];
        Screen.SetResolution(resolution.width, resolution.height, Screen.fullScreen);
    }

    public void SetFullScreen(bool isFullScreen)
    {
        Screen.fullScreen = isFullScreen;
    }

    public void QuitGame()
    {
        Debug.Log("Quit Game");
        Application.Quit();
    }
}
