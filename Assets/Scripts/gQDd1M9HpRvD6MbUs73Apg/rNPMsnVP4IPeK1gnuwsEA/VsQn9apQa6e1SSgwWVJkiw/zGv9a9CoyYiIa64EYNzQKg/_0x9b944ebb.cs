using UnityEngine;
using UnityEngine.UI;

public class _0x9b944ebb : MonoBehaviour
{
    public bool IsTutorialEndPanel;
    public Button TutorialEndButton;
    public int NextTutorialPanelIndex;
    public int EndTutorialPanelIndex = 1;
    private void Start()
    {
        if (this.NextTutorialButton != null)
        {
            if (this.IsTutorialEndPanel)
            {
                this.NextTutorialButton.onClick.AddListener(() => _0x868e2cfd.Instance._0x168cb9c2(this.EndTutorialPanelIndex));
                this.NextTutorialButton.onClick.AddListener(() => _0x697b0043.Instance._0x2b4f99b0());
            }
            else
            {
                this.NextTutorialButton.onClick.AddListener(() => _0x868e2cfd.Instance._0x168cb9c2(this.NextTutorialPanelIndex));
            }
        }

        if (this.TutorialEndButton != null)
        {
            this.TutorialEndButton.onClick.AddListener(() => _0x868e2cfd.Instance._0x168cb9c2(this.EndTutorialPanelIndex));
            this.TutorialEndButton.onClick.AddListener(() => _0x697b0043.Instance._0x2b4f99b0());
        }
    }

    public Button NextTutorialButton;
}