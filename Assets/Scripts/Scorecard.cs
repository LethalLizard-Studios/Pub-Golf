using UnityEngine;

/* All rights reserved to Leland T Carter of LethalLizard Studios
-- Last Change @date: 4/2/2023
*/

public class Scorecard : MonoBehaviour
{
    public static Scorecard Instance { get; private set; }

    private CourseInfo course;

    [SerializeField] private Transform holePrefab;

    private const int HOLE_SPACING = 75;

    public void Awake()
    {
        if (Instance == null || Instance != this)
        {
            Instance = this;
        }
    }

    public void Build(CourseInfo course)
    {
        this.course = course;

        Initialize();
    }

    private void Initialize()
    {
        for (int i = 0; i < course.holeInfos.Length; i++)
        {
            Transform newHole = Instantiate(holePrefab, holePrefab.parent);

            // Move next hole over slightly
            newHole.localPosition = new Vector3(newHole.localPosition.x + (i * HOLE_SPACING)
                , newHole.localPosition.y);

            // Sets the holes par, number and other info
            newHole.GetComponent<Hole>().Initialize(course.holeInfos[i], i+1);

            newHole.gameObject.SetActive(true);
        }
    }
}
