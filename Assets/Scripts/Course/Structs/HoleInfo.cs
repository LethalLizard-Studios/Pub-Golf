/* All rights reserved to Leland T Carter of LethalLizard Studios
-- Last Change @date: 3/31/2023
*/

[System.Serializable]
public struct HoleInfo
{
    public string locationName;

    // Event which takes place on hole, can be null
    public SpecialEvents eventType;

    public DrinkInfo drinkType;

    // Constructor
    public HoleInfo(SpecialEvents eventType, DrinkInfo drinkType, string locationName)
    {
        this.eventType = eventType;
        this.drinkType = drinkType;
        this.locationName = locationName;
    }
}
