using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class NameInput : MonoBehaviour
{
    public TextMeshProUGUI playerNameInput;
    private string playerName;

    public string GetName()
    {
        playerName = playerNameInput.text;
        return playerName;
    }
}
