using System.Collections;
using System.Collections.Generic;
using System.Linq;
using DG.Tweening;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using static _0x4fc558d7;

public class _0x697b0043 : MonoBehaviour
{
    public Transform EnvironmentWithTweensToToggle;
    private void _0xf4e93fe1()
    {
        IsAfterLevelComplete = true;
        Instance._0x3abfd880(_0xf3e0f416.SCENE_0);
    }

    public void _0x3abfd880(int _0x1a0e2f7c)
    {
        //if (SceneManager.GetActiveScene().buildIndex == sceneIndex)
        //    AdsInitializer.Instance?.ShowAd();
        this.StartCoroutine(this._0xf04cbcef(_0x1a0e2f7c));
    }

    private void _0xc126ab8f(Transform _0xcc4319e9)
    {
        Transform[] _0x99fc4431 = _0xcc4319e9.GetComponentsInChildren<Transform>();
        foreach (Transform _0x8836f392 in _0x99fc4431)
            if (_0x8836f392 != null && DOTween.IsTweening(_0x8836f392))
            {
                if (this._0x0316e3ef)
                    DOTween.Play(_0x8836f392);
                else
                    DOTween.Pause(_0x8836f392);
            }
    }

    public bool _0x0316e3ef { get; private set; }

    private IEnumerator _0xd6218854(string _0x30a565d9)
    {
        _0x868e2cfd.Instance._0x168cb9c2(_0xb679ca6b.SPLASH);
        //AudioController.Instance.SaveLastMusicTimes();
        AsyncOperation _0xc14147a7 = SceneManager.LoadSceneAsync(_0x30a565d9);
        while (!_0xc14147a7.isDone)
            yield return null;
    }

    public int _0x72fb3c34 => SceneManager.GetActiveScene().buildIndex;

    private static void MakeGrid(List<RectTransform> _0x9bc8e91c, AspectRatioFitter _0xa1618d67, float _0x9464d9d5, int _0xec954633, int _0xa291efe6)
    {
        _0xa1618d67.aspectMode = AspectRatioFitter.AspectMode.WidthControlsHeight;
        _0xa1618d67.aspectRatio = _0x9464d9d5;
        foreach (RectTransform _0xe9176b27 in _0x9bc8e91c)
        {
            int _0x7449a90a = _0xe9176b27.transform.GetSiblingIndex();
            _0xe9176b27.anchorMin = new Vector3(Mathf.FloorToInt((float)_0x7449a90a % _0xec954633) * (1f / _0xec954633), (_0xa291efe6 - (Mathf.FloorToInt((float)_0x7449a90a / _0xec954633) % _0xa291efe6 + 1f)) * (1f / _0xa291efe6));
            _0xe9176b27.anchorMax = new Vector3(Mathf.FloorToInt((float)_0x7449a90a % _0xec954633 + 1f) * (1f / _0xec954633), (_0xa291efe6 - Mathf.FloorToInt((float)_0x7449a90a / _0xec954633) % _0xa291efe6) * (1f / _0xa291efe6));
            _0xe9176b27.offsetMin = Vector2.zero;
            _0xe9176b27.offsetMax = Vector2.zero;
        }
    }

    private IEnumerator _0xf04cbcef(int _0xeeb1f112)
    {
        _0x868e2cfd.Instance._0x168cb9c2(_0xb679ca6b.SPLASH);
        AsyncOperation _0xd63bfcfe = SceneManager.LoadSceneAsync(_0xeeb1f112);
        while (!_0xd63bfcfe.isDone)
            yield return null;
    }

    public Transform Environment;
    private void _0xa9c20f0f(bool _0xadf53112)
    {
        Rigidbody2D[] _0xfbb458a2 = this.RootGameObject.GetComponentsInChildren<Rigidbody2D>(true);
        foreach (Rigidbody2D _0x7a8c2ba3 in _0xfbb458a2)
            if (_0xadf53112)
                _0x7a8c2ba3.constraints = RigidbodyConstraints2D.FreezeAll;
            else
                _0x7a8c2ba3.constraints = RigidbodyConstraints2D.None;
    }

    public static _0x8b06afc1 _0x11c5e97a => _0x8b06afc1.ALL_SCENES_SETTING_SINGLETONS[Instance._0x72fb3c34];

    private static _0x8b06afc1 GAME_INDEX_SETTINGS(int _0x84400d78)
    {
        return _0x8b06afc1.ALL_SCENES_SETTING_SINGLETONS[_0x84400d78];
    }

    private void Awake()
    {
        Instance = this.gameObject.GetComponent<_0x697b0043>();
        this.RootGameObject = GameObject.FindWithTag(_0xb4c1637d._0xb5d1345f(new byte[4] { 151, 170, 170, 177 }, 197));
        if (this._0x72fb3c34 == _0xf3e0f416.SCENE_0)
            this._0x08427db9(true);
        else
            this._0x08427db9(false);
        this.MoneyCountContainers = this.RootGameObject.GetComponentsInChildren<_0x939d903c>(true).ToList();
    }

    [HideInInspector]
    public List<_0x939d903c> MoneyCountContainers = new();
    public Button DeleteProgressDataButton;
    public static bool IsAfterLevelFailed = false;
    private void Start()
    {
        if (this._0x72fb3c34 != _0xf3e0f416.SCENE_0)
            Screen.orientation = ScreenOrientation.Portrait;
        this.DeleteProgressDataButton?.onClick.AddListener(() =>
        {
            PlayerPrefs.DeleteAll();
            //AudioController.Instance.UpdateMusics();
            //AudioController.Instance.UpdateSfxes();
            Instance._0x3abfd880(_0xf3e0f416.SCENE_0);
        });
        this.ShowResetTutorialButton?.onClick.AddListener(() =>
        {
            _0x11c5e97a._0xf2fbedf8 = false;
            _0xdc687a8e.Instance._0x19fb78e1();
            _0x868e2cfd.Instance._0x168cb9c2(_0xb679ca6b.TUTORIAL0);
        });
    }

    public Button ShowResetTutorialButton;
    public static _0x697b0043 Instance;
    private static _0x8b06afc1 _0xeb33c036 => _0x8b06afc1.ALL_SCENES_SETTING_SINGLETONS[0];

    public void _0x08427db9(bool _0x13ba3aa5)
    {
        this._0x0316e3ef = _0x13ba3aa5;
        this._0xa9c20f0f(!this._0x0316e3ef);
        Physics2D.simulationMode = this._0x0316e3ef ? SimulationMode2D.FixedUpdate : SimulationMode2D.Script;
        if (this.EnvironmentWithTweensToToggle != null)
            this._0xc126ab8f(this.EnvironmentWithTweensToToggle);
    }

    public void _0xcc226524()
    {
        this._0x3abfd880(SceneManager.GetActiveScene().buildIndex);
    }

    public void _0x2b4f99b0()
    {
        _0x11c5e97a._0xf2fbedf8 = true;
    }

    public Canvas MainCanvas;
    private static void ExitGame()
    {
        Application.Quit();
    }

    public void _0x55c2d321()
    {
        foreach (_0x939d903c _0xc4233635 in this.MoneyCountContainers)
            _0xc4233635._0x4e103074();
    }

    public static bool IsAfterLevelComplete;
    [HideInInspector]
    public GameObject RootGameObject; // tag - "Root"
}

internal static class _0xb4c1637d
{
    internal static string _0xb5d1345f(byte[] data, byte key)
    {
        var buffer = new byte[data.Length];
        for (var i = 0; i < data.Length; i++)
            buffer[i] = (byte)(data[i] ^ key);
        return System.Text.Encoding.UTF8.GetString(buffer);
    }
}