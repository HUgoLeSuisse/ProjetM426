using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;

/// <summary>
/// Classe permettant de posée une question de vérifier la réponse
/// </summary>
public class Question
{


    /// <summary>
    /// Question posée
    /// </summary>
    private string question;


    /// <summary>
    /// Ensemeble des propositions
    /// </summary>
    private string[] proposistion;


    /// <summary>
    /// Emplacement de la réponse
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

