using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimalSelection : MonoBehaviour
{
    private bool _isFollowed;

    public void OnSelect()
    {
        _isFollowed = true;
        CamerasManager.S.FollowTarget(transform);
        GameManager.AnimalDetailsUI.ShowAnimalDetails(GetComponent<AnimalBehaviour>().ChildGenome);
    }

    private void OnDestroy()
    {
        if (!_isFollowed) return;
        //CamerasManager.S.UnfollowTarget();
        GameManager.AnimalDetailsUI.HideAnimalDetails();
        _isFollowed = false;    
    }
}
