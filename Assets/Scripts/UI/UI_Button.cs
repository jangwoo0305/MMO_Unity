using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.EventSystems;


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

    enum Images
    {
        ItemIcon,
    }

    void Start()
    {
        Bind<Button>(typeof(Buttons));
        Bind<TextMeshProUGUI>(typeof(Texts));
        Bind<GameObject>(typeof(GameObjects));
        Bind<Image>(typeof(Images));

        GetText((int)Texts.ScoreText).text = "Bind Test";
        
        GameObject go = GetImage((int)Images.ItemIcon).gameObject;
        UI_EventHandler evt = go.GetComponent<UI_EventHandler>();
        evt.OnDragHandler += ((PointerEventData data) => { evt.gameObject.transform.position = data.position; });
    }
    
    int _score = 0;
    
    public void OnButtonClick()
    {
        _score++;
    }
}
