using UnityEngine;

/* All rights reserved to Leland T Carter of LethalLizard Studios
-- Last Change @date: 4/2/2023
*/

public class TestBuildingScorecard : MonoBehaviour
{
    [SerializeField] private CourseInfo course;

    void Start()
    {
        Scorecard.Instance.Build(course);
    }
}
