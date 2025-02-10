using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;


/// <summary>
/// 
/// </summary>
public class CaseQuestion : Case
{


    /// <summary>
    /// Question qui sera posé au joueur qui marche sur cette case
    /// </summary>
    private Question question;

    public CaseQuestion(Question question)
    {
        this.question = question;
    }

}

