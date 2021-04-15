using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpeciesSelectionUI : PanelBase
{
    public void StartGame(int speciesIndex)
    {
        GameManager.S.SelectedSpecies = speciesIndex switch
        {
            0 => AnimalSpeciesType.Rock,
            1 => AnimalSpeciesType.Paper,
            _ => AnimalSpeciesType.Cisor,
        };
        Hide();
        GameManager.S.StartGame();
    }
}
