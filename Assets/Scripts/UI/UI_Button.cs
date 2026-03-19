using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class NewBehaviourScript : MonoBehaviour
{
    [SerializeField] 
    TextMeshProUGUI _text;

    private int _score = 0;
    
    public void OnButtonClick()
    {
        _score++;
        _text.text = $"Score : {_score} ";
    }
}
