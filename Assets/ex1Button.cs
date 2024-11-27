using UnityEngine;
using TMPro;

public class ex1Button : MonoBehaviour
{
    public TextMeshProUGUI buttonText;
    int counter = 0;

    public void buttonTextChange()
    {
        switch (counter)
        {
            case 0: buttonText.text = "Play"; break;
            case 1: buttonText.text = "Restart"; break;
            case 2: buttonText.text = "Quit"; break;
            case 3: buttonText.text = "Start"; break;

        }
        counter = (counter + 1) % 4;
    }
}
