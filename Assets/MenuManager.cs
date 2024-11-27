using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class MenuManager : MonoBehaviour
{
    public TextMeshProUGUI menuTitle;
    public Button startButton;

    public void UpdateMenuTitle()
    {
        menuTitle.text = "PressedConfirmed";
    }

    public void OnStartButtonClick()
    {
        UpdateMenuTitle();
        startButton.GetComponent<Image>().color = Color.blue;
    }
}