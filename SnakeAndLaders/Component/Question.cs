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
    private string[] proposition;


    /// <summary>
    /// Emplacement de la réponse
    /// </summary>
    private int reponse;

    public Question(string question, string[] proposition, int reponse)
    {
        this.question = question;
        this.proposition = proposition;
        this.reponse = reponse;
    }


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

