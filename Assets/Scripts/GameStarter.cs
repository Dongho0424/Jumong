using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameStarter : MonoBehaviour
{
    void Start()
    {
        // ���� ���� �� AudioManager�� PlayIntroAndMainMusic �޼��� ȣ��
        AudioManager.instance.PlayIntroAndMainMusic();
    }
}
