using UnityEngine;

public class ex3dynamicScript : MonoBehaviour
{
    public GameObject buttonPrefab;
    public Transform parentCanvas;

    void Start()
    {
        Debug.Log("asdf");
        for (int i = 0; i < 5; i++)
        {
            GameObject newButton = Instantiate(buttonPrefab, parentCanvas);
            newButton.name = "Button " + (i + 1);
        }
    }
}