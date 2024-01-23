using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PopupStartMenu : MonoBehaviour
{
    [SerializeField] private InputField _inputField;
    [SerializeField] private Text playerName;

    public void OnClickJoin()
    {
        if(!(2 < _inputField.text.Length && _inputField.text.Length < 10))
        {
            return;
        }

        playerName.text = _inputField.text;

        Destroy(gameObject);
    }
}
