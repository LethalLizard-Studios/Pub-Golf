/* All rights reserved to Leland T Carter of LethalLizard Studios
-- Last Change @date: 3/31/2023
*/

[System.Serializable]
public struct CourseInfo
{
    // Courses custom name provided by user
    public string name;

    // Data attached to hole, array size is course size
    public HoleInfo[] holeInfos;

    // Constructor
    public CourseInfo(string name, HoleInfo[] holeInfos)
    {
        this.name = name;
        this.holeInfos = holeInfos;
    }
}
