using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class VictoryUI : PanelBase
{
    void Start()
    {
        GameManager.VictoryUI = this;
    }

    public void WinGame()
    {
        Show();
    }
}
