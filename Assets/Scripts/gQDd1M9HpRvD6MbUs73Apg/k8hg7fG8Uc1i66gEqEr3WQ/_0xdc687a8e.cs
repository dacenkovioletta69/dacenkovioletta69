using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.UI;
using static _0x4fc558d7;

public class _0xdc687a8e : MonoBehaviour
{
    public List<int> LastPopIndexes = new();
    public void _0x9d1b4ae2(int _0xe5f2337a)
    {
        this.CurrentPopIndex = _0xe5f2337a;
        this.LastPopIndexes.Add(this.CurrentPopIndex);
        this._0x2116611a(true);
        this._0xb95cd81d();
        this.Pops[_0xe5f2337a].Show();
        foreach (GameObject _0x1f8494eb in this.GameObjectsToHide)
            _0x1f8494eb.SetActive(false);
    }

    public GameObject BlurBackground;
    public void _0xbb1af79f()
    {
        this.LastPopIndexes.RemoveAll(_0x0bb4f0e2 => _0x0bb4f0e2 == this.CurrentPopIndex);
        if (this.LastPopIndexes.Count <= 0)
            this._0x19fb78e1();
        else
            this._0x9d1b4ae2(this.LastPopIndexes.Last());
    }

    public void _0x19fb78e1()
    {
        this.LastPopIndexes.Clear();
        this._0x2116611a();
        foreach (GameObject _0x05089fa1 in this.GameObjectsToHide)
            if (_0x05089fa1 != null)
                _0x05089fa1.SetActive(true);
        this._0xb0922eef();
    }

    private void _0x2116611a(bool _0xec92df4d = false)
    {
        for (int _0x089e2e20 = 0; _0x089e2e20 < this.Pops.Count; ++_0x089e2e20)
            if (this.Pops[_0x089e2e20] != null && !(_0x089e2e20 == this.CurrentPopIndex && _0xec92df4d))
                this.Pops[_0x089e2e20]._0xe66846cd();
    }

    private void BackgroundHidden()
    {
        this.BlurBackground.gameObject.SetActive(false);
    }

    public List<GameObject> GameObjectsToHide;
    public List<_0x62964e65> Pops;
    public _0x62964e65 _0x8a61a0fe(int _0x80f3ac57)
    {
        return this.Pops[_0x80f3ac57];
    }

    private void _0xb95cd81d()
    {
        this.BlurBackground.gameObject.SetActive(true);
    }

    private void Start()
    {
        this.BackgroundHidden();
        foreach (_0x62964e65 _0x8de79af3 in this.Pops)
            if (_0x8de79af3 != null)
                _0x8de79af3.gameObject.SetActive(true);
    }

    public int CurrentPopIndex;
    public static _0xdc687a8e Instance;
    private void _0xb0922eef()
    {
        this.Invoke(nameof(this.BackgroundHidden), this.ScaleDuration);
    }

    public float ScaleDuration = 0.4f;
    private void Awake()
    {
        Instance = this.gameObject.GetComponent<_0xdc687a8e>();
    }
}