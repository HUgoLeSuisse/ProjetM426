using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;

/// <summary>
/// Plateau de jeu
/// </summary>
public class Plateau
{

    /// <summary>
    /// Ensemble des joueurs
    /// </summary>
    private Joueur[] joueurs;


    /// <summary>
    /// Ensemble des cases
    /// </summary>
    private Case[] cases;

    public Plateau(Joueur[] joueurs) 
    {
        this.joueurs = joueurs;



        cases = new Case[] { 
        new Case(),
        new Case(),
        new Case(),
        new Case(),
        new Case(),
        new CaseQuestion(new Question("Quel est le plus grand oc�an du monde ?", new string[]{"Atlantique", "Arctique", "Indien", "Pacifique"}, 3)),
        new Case(),
        new CaseQuestion(new Question("Qui a peint la Joconde ?", new string[]{"Vincent van Gogh", "Claude Monet", "L�onard de Vinci", "Pablo Picasso"}, 2)),
        new Case(),
        new Case(),
        new Case(),
        new CaseQuestion(new Question("Quelle est la capitale de l'Australie ?", new string[]{"Sydney", "Canberra", "Melbourne", "Brisbane"}, 1)),
        new Case(),
        new CaseQuestion(new Question("Combien de plan�tes composent notre syst�me solaire ?", new string[]{"7", "8", "9", "10"}, 1)),
        new Case(),
        new Case(),
        new Case(),
        new CaseQuestion(new Question("Quelle est la langue la plus parl�e dans le monde ?", new string[]{"Anglais", "Espagnol", "Chinois mandarin", "Fran�ais"}, 2)),
        new Case(),
        new CaseQuestion(new Question("En quelle ann�e a eu lieu la R�volution fran�aise ?", new string[]{"1492", "1789", "1815", "1914"}, 1)),
        new Case(),
        new Case(),
        new Case(),
        new CaseQuestion(new Question("Quel est l'�l�ment chimique dont le symbole est 'O' ?", new string[]{"Osmium", "Or", "Oxyg�ne", "Ozone"}, 2)),
        new Case(),
        new Case(),
        new Case(),
        new Case(),
        new Case(),
        new CaseQuestion(new Question("Quel est le plus haut sommet du monde ?", new string[]{"Mont Blanc", "Kilimandjaro", "Everest", "K2"}, 2)),
        new Case(),
        new CaseQuestion(new Question("Quel est le plus haut sommet du monde ?", new string[]{"Mont Blanc", "Kilimandjaro", "Everest", "K2"}, 2)),
        new Case(),
        new Case(),
        new Case()
        };
    }


}

