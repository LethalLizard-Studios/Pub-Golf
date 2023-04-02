using UnityEngine;

/* All rights reserved to Leland T Carter of LethalLizard Studios
-- Last Change @date: 3/31/2023
*/

[System.Serializable]
public struct DrinkInfo
{
    public string name;
    public float par;
    public Sprite icon;

    // Constructor
    public DrinkInfo(string name, float par, Sprite icon)
    {
        this.name = name;
        this.par = par;
        this.icon = icon;
    }
}
