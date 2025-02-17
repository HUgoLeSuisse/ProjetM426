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
    private string[] proposition;


    /// <summary>
    /// Emplacement de la r�ponse
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

