using System;
using System.ComponentModel;
using System.Collections.Generic;
using UnityRest;
using UnityEngine;

[Serializable]
[Description("character")]
public class Character
{
    public int[] ids;
    public List<ObjectId> charactersAvailable = new List<ObjectId>();

    public static Character actualCharacter;

    public Character(int[] ids)
    {
        this.ids = ids;
    }

    private void AddCharacters()
    {
        foreach (int id in ids)
        {
            charactersAvailable.Add(id.ToString());
        }
    }

    public string Print()
    {
        AddCharacters();

        string print = "";

        for (int i = 0; i < ids.Length; i++)
        {
            if (i == 0)
            {
                print = string.Format("{0}", ids[i]);
            }
            else
            {
                print = string.Format("{0}, {1}", print, ids[i]);
            }
        }

        return print;
    }
}
