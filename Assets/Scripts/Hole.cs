using TMPro;
using UnityEngine;

public class Hole : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI number;
    [SerializeField] private TextMeshProUGUI par;
    [SerializeField] private TextMeshProUGUI p1Score;
    [SerializeField] private TextMeshProUGUI p2Score;
    [SerializeField] private TextMeshProUGUI teamPar;

    public void Initialize(HoleInfo holeInfo, int index)
    {
        number.text = index.ToString();
        par.text = holeInfo.drinkType.par.ToString();

        p1Score.text = "";
        p2Score.text = "";
        teamPar.text = "";
    }
}
