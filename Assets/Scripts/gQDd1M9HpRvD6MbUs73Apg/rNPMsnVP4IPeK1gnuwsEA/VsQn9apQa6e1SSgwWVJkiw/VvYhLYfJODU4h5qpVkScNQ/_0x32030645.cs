using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class _0x32030645 : MonoBehaviour
{
    public int LoadSceneId;
    public Button Button;
    private void Start()
    {
        if (this.IsLoadCurrentScene)
            this.Button.onClick.AddListener(() =>
            {
                _0x697b0043.Instance._0x3abfd880(SceneManager.GetActiveScene().buildIndex);
            });
        else
            this.Button.onClick.AddListener(() => _0x697b0043.Instance._0x3abfd880(this.LoadSceneId));
    }

    public bool IsLoadCurrentScene;
    private void Awake()
    {
        if (this.Button == null)
            if (!this.TryGetComponent(out this.Button))
                this.Button = this.GetComponentInChildren<Button>();
    }
}