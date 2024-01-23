using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PopupStartMenu : MonoBehaviour
{
    [SerializeField] private Image characterSprite;
    [SerializeField] private InputField _inputField;
    [SerializeField] private GameObject information;
    [SerializeField] private GameObject selectCharacter;

    private CharacterType characterType;

    public void OnClickCharacter()
    {
        information.SetActive(false);
        selectCharacter.SetActive(true);
    }

    public void OnClickSelectCharacter(int index)
    {
        characterType = (CharacterType)index;
        var character = GameManager.Instance.CharacterList.Find(item => item.CharacterType == characterType);
        characterSprite.sprite = character.CharacterSprite;
        characterSprite.SetNativeSize();
   
        selectCharacter.SetActive(false);
        information.SetActive(true);
    }

    public void OnClickJoin()
    {
        if(!(2 < _inputField.text.Length && _inputField.text.Length < 10))
        {
            return;
        }

        GameManager.Instance.SetCharacter(characterType, _inputField.text);

        Destroy(gameObject);
    }
}
