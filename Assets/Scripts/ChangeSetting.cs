using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeSetting : MonoBehaviour
{
    bool isready=false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        GameDirector.lv = GameDirector.level.Hard;
        if (isready)
        {
            isready = false;
            SceneManager.LoadScene("Main Scene");
        }
        
    }
}
