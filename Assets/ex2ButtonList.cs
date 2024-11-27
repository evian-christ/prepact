using UnityEngine;
using TMPro;
using System.Collections.Generic;

public class ex2ButtonList : MonoBehaviour
{
    public TextMeshProUGUI buttonText;
    public List<string> textList;

    int counter = 0;

    public void textChange()
    {
        buttonText.text = textList[counter % textList.Count];
        counter++;
    }
}