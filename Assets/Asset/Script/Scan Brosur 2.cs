using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ObjectSwitcher : MonoBehaviour
{
    public GameObject[] objects; // Array of 3D objects
    public GameObject[] infoPanels; // Array of info panels
    public Button nextButton;
    public Button previousButton;
    public Button infoButton;
    public Button closeButton;
    public Button backButton;

    private int currentIndex = 0;

    void Start()
    {
        // Initialize buttons
        nextButton.onClick.AddListener(ShowNextObject);
        previousButton.onClick.AddListener(ShowPreviousObject);
        infoButton.onClick.AddListener(ToggleInfoPanel);
        closeButton.onClick.AddListener(HideInfoPanel);
        backButton.onClick.AddListener(GoBack);

        // Initialize objects and panels
        UpdateObjects();
        HideAllInfoPanels();
    }

    void ShowNextObject()
    {
        objects[currentIndex].SetActive(false);
        currentIndex = (currentIndex + 1) % objects.Length;
        UpdateObjects();
    }

    void ShowPreviousObject()
    {
        objects[currentIndex].SetActive(false);
        currentIndex = (currentIndex - 1 + objects.Length) % objects.Length;
        UpdateObjects();
    }

    void UpdateObjects()
    {
        objects[currentIndex].SetActive(true);
        HideAllInfoPanels();
    }

    void ToggleInfoPanel()
    {
        if (infoPanels[currentIndex].activeSelf)
        {
            infoPanels[currentIndex].SetActive(false);
        }
        else
        {
            HideAllInfoPanels();
            infoPanels[currentIndex].SetActive(true);
        }
    }

    void HideInfoPanel()
    {
        infoPanels[currentIndex].SetActive(false);
    }

    void HideAllInfoPanels()
    {
        foreach (GameObject panel in infoPanels)
        {
            panel.SetActive(false);
        }
    }

    void GoBack()
    {
        SceneManager.LoadScene("Cara Scan Brosur");
    }
}
