using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;

/// <summary>
/// Classe permettant de pos�e une question de v�rifier la r�ponse
/// </summary>
public class Question
{


    /// <summary>
    /// Question pos�e
    /// </summary>
    private string question;


    /// <summary>
    /// Ensemeble des propositions
    /// </summary>
    private string[] proposistion;


    /// <summary>
    /// Emplacement de la r�ponse
    /// </summary>
    private int reponse;

    /// <summary>
    /// 
    /// </summary>
    /// <param name="choix"></param>
    /// <returns></returns>
    public bool checkReponse(int choix)
    {
        return choix == reponse;
    }

}

