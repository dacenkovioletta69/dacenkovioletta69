using UnityEngine;
using UnityEngine.UI;

public class _0xe97a2ca5 : MonoBehaviour
{
    private void Start()
    {
        this.Button.onClick.AddListener(() => _0x697b0043.Instance._0x08427db9(this.IsPhysicsRunOnClick));
    }

    private void Awake()
    {
        if (this.Button == null)
            if (!this.TryGetComponent(out this.Button))
                this.Button = this.GetComponentInChildren<Button>();
    }

    public bool IsPhysicsRunOnClick;
    public Button Button;
}