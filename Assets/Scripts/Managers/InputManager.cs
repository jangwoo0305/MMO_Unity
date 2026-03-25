using System;
using UnityEngine;
using UnityEngine.EventSystems;

public class InputManager
{
    public Action KeyAction = null;
    public Action <Define.MouseEvent> MouseAction = null;
    
    bool _pressed = false;
    
    public void OnUpdate()
    {
        
        if(EventSystem.current.IsPointerOverGameObject()) // UI를 클릭하면 케릭터가 이동하지 않게 하는 부분
            return;
            
        if(Input.anyKey && KeyAction != null)
            KeyAction.Invoke();

        if (MouseAction != null)
        {
            if (Input.GetMouseButton(0))
            {
                MouseAction.Invoke(Define.MouseEvent.Press);
                _pressed = true;
            }
            else
            {
                if (_pressed)
                    MouseAction.Invoke(Define.MouseEvent.Click); // 마우스를 떼면 클릭으로 인정
                _pressed = false;
            }
        }
    }
}
