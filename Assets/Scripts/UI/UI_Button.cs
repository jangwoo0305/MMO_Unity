using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using System;
using Unity.VisualScripting;
using UnityEngine.EventSystems;
using Object = UnityEngine.Object;

public class NewBehaviourScript : UI_Base
{
    
    enum Buttons
    {
        PointButton,
    }
    
    enum Texts
    {
        PointText,
        ScoreText,
    }

    enum GameObjects
    {
        TestObject,
    }

    void Start()
    {
        Bind<Button>(typeof(Buttons));
        Bind<TextMeshProUGUI>(typeof(Texts));
        Bind<GameObject>(typeof(GameObjects));

        GetText((int)Texts.ScoreText).text = "Bind Test";
    }
    
    int _score = 0;
    
    public void OnButtonClick()
    {
        _score++;
    }
}
