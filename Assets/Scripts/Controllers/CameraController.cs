using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public Define.CameraMode _mode = Define.CameraMode.QuarterView;
    
    [SerializeField]
    private GameObject _player = null;
    [SerializeField]
    private Vector3 _delta = new Vector3(0.0f, 0.6f, -0.5f);
    void Start()
    {
        
    }

    void LateUpdate()
    {
        if (_mode == Define.CameraMode.QuarterView)
        {
            transform.position = _player.transform.position + _delta;
            transform.LookAt(_player.transform);
        }
    }

    public void SetQuaterView(Vector3 delta)
    {
        _mode =  Define.CameraMode.QuarterView;
        _delta = delta;
        
    }
}
