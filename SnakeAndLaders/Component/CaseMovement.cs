using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;


/// <summary>
/// Echelle ou Serpent : Case faisant déplacement à la case Sortie
/// </summary>
public class CaseMovement : Case
{


    private int sortie;

    /// <summary>
    /// Case de Sortie : Case au le joueur sera emener s'il marche sur cette case
    /// </summary>
    public int Sortie { get { return sortie; } }

    public CaseMovement(int sortie)
    {
        this.sortie = sortie;
    }


}

