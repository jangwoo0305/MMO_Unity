using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Managers :  MonoBehaviour
{
    static Managers s_instance; // static이라는 특성상 유일성 보장

    public static Managers Instance // 유일한 매니저를 갖고 온다.
    {
        get
        {
            Init(); 
            return s_instance;
        }
    }
    
    void Start()
    {
        Init();
    }

    void Update()
    {
        
    }

    static void Init()
    {
        if (s_instance == null)
        {
            GameObject go = GameObject.Find("@Managers");
            if (go == null)
            {
                go = new GameObject {name = "@Managers"};
                go.AddComponent<Managers>();
            }
            DontDestroyOnLoad(go);
            s_instance = go.GetComponent<Managers>();
        }
    }
}
 