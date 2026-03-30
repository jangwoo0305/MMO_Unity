using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.EventSystems;


public class UI_Button : UI_Popup
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
        Init();
    }
    
    public override void Init()
    {
        base.Init();
        
        Bind<Button>(typeof(Buttons));
        Bind<TextMeshProUGUI>(typeof(Texts));
        Bind<GameObject>(typeof(GameObjects));
        Bind<Image>(typeof(Images));
        
        GetButton((int)Buttons.PointButton).gameObject.AddUIEvent(OnButtonClick);
        
        GameObject go = GetImage((int)Images.ItemIcon).gameObject;
        AddUIEvent(go,(PointerEventData data) => { go.transform.position = data.position;},Define.UIEvent.Drag);
    }
    
    int _score = 0;
    
    public void OnButtonClick(PointerEventData data)
    {
        _score++;
        GetText((int)Texts.ScoreText).text = $"score: {_score}";
    }
}
