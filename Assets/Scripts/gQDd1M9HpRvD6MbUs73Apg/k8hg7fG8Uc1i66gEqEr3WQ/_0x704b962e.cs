using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class _0x704b962e : MonoBehaviour
{
    public List<TMP_Text> ScoreText = new();
    private int _0x1ecbcf24 => this.CustomTimeInitial + _0x697b0043._0x11c5e97a._0xd7ba320b * 10;

    private IEnumerator _0xc8364c71()
    {
        this._0x0e935e12();
        while (!this.IsGameEnd && this.TimeLeft > 0 && _0x697b0043.Instance._0x72fb3c34 == this.CurrentGameIndex)
        {
            yield return new WaitForSeconds(1f);
            if (_0x697b0043.Instance._0x0316e3ef)
            {
                if (this.IsGameEnd)
                    break;
                this.TimeLeft--;
                this._0x0e935e12();
            }
        }

        if (!this.IsGameEnd)
            this._0xc6909a7e();
    }

    private void _0xfcdc4927()
    {
        this.IsGameEnd = true;
        _0x697b0043.IsAfterLevelComplete = true;
    }

    private static _0x704b962e _0x69751c0b;
    [HideInInspector]
    public int CurrentGameIndex;
    private int _0xb3493a86 => this.CustomTargetScore + _0x697b0043._0x11c5e97a._0xd7ba320b * 10;

    public int CustomTimeInitial = 30;
    private void Start()
    {
        this.IsGameEnd = false;
        this.TimeLeft = this._0x1ecbcf24;
        this.CurrentGameIndex = _0x697b0043.Instance._0x72fb3c34;
        foreach (Button _0x7e0fff33 in this.HomeButtons)
            _0x7e0fff33.onClick.AddListener(() =>
            {
                this._0x3d8cb21b();
            });
        foreach (Button _0x190f108b in this.PauseButtons)
            _0x190f108b.onClick.AddListener(() =>
            {
                _0x697b0043.Instance._0x08427db9(false);
                _0xdc687a8e.Instance._0x9d1b4ae2(_0x4fc558d7._0xaf9d58cd.PAUSE);
            });
        this._0xaa2a3a20();
        this.LevelNumberText.ForEach(_0x3b79c43b => _0x3b79c43b.text = $"LVL {_0x697b0043._0x11c5e97a._0xd7ba320b + 1}");
        if (_0x5a326faa.Instance.IsTimerEnabled)
        {
            this._0x0e935e12();
            this.StartCoroutine(this._0xc8364c71());
        }
    }

    public int CustomTargetScore = 10;
    public List<Button> PauseButtons = new();
    public void _0x3d8cb21b()
    {
        _0x697b0043.Instance._0x08427db9(true);
        _0x697b0043.Instance._0x3abfd880(_0x4fc558d7._0xf3e0f416.SCENE_0);
    }

    [HideInInspector]
    public int ScoreCurrent;
    public List<Button> HomeButtons = new();
    public void _0xc6909a7e()
    {
        if (_0x5a326faa.Instance.IsOnlyWinGameEndEnabled)
            this._0xcbe449bb();
        if (!this.IsGameEnd)
        {
            this._0xfcdc4927();
            _0x697b0043.IsAfterLevelComplete = false;
            _0x697b0043.IsAfterLevelFailed = true;
            _0x62964e65 _0xbe74cd9c = _0xdc687a8e.Instance._0x8a61a0fe(_0x4fc558d7._0xaf9d58cd.LOSE).GetComponent<_0x62964e65>();
            if (_0x5a326faa.Instance.IsCheckScoreEnabled)
                _0xbe74cd9c.ContentMainText.text = $"{this.ScoreCurrent}/{this._0xb3493a86}";
            else
                _0xbe74cd9c.ContentMainText.text = $"{this.ScoreCurrent}";
            _0xbe74cd9c.ContentAdditionalText.text = $"{0}";
            _0x4fc558d7._0x566e4cde._0xd0203e80 += 0;
            _0xdc687a8e.Instance._0x9d1b4ae2(_0x4fc558d7._0xaf9d58cd.LOSE);
        }
    }

    private void _0xc88e1f00()
    {
        if (this.ScoreCurrent > _0x697b0043._0x11c5e97a._0x64eb2b6b)
            _0x697b0043._0x11c5e97a._0x64eb2b6b = this.ScoreCurrent;
        if (_0x5a326faa.Instance.IsCheckScoreEnabled)
            if (this.ScoreCurrent >= this._0xb3493a86)
                this._0xcbe449bb();
    }

    private void _0x0ab40a02()
    {
        if (this.ScoreCurrent >= this._0xb3493a86)
            this._0xcbe449bb();
        else
            this._0xc6909a7e();
    }

    private int _0xf98c4560 => this.ScoreCurrent;

    private void _0xaa2a3a20()
    {
        if (_0x5a326faa.Instance.IsCheckScoreEnabled)
            this.ScoreText.ForEach(_0x3b79c43b => _0x3b79c43b.text = $"{this.ScoreCurrent}/{this._0xb3493a86}");
        else
            this.ScoreText.ForEach(_0x3b79c43b => _0x3b79c43b.text = $"{this.ScoreCurrent}");
    }

    public void _0xcbe449bb()
    {
        if (!this.IsGameEnd)
        {
            this._0xfcdc4927();
            _0x697b0043.IsAfterLevelComplete = true;
            _0x697b0043.IsAfterLevelFailed = false;
            _0x62964e65 _0x7cb2364e = _0xdc687a8e.Instance._0x8a61a0fe(_0x4fc558d7._0xaf9d58cd.WIN).GetComponent<_0x62964e65>();
            if (_0x5a326faa.Instance.IsCheckScoreEnabled)
                _0x7cb2364e.ContentMainText.text = $"{this.ScoreCurrent}/{this._0xb3493a86}";
            else
                _0x7cb2364e.ContentMainText.text = $"{this.ScoreCurrent}";
            if (_0x5a326faa.Instance.IsBestScoreEnabled)
            {
                if (this.ScoreCurrent > _0x4fc558d7._0x566e4cde._0xd0203e80)
                    _0x4fc558d7._0x566e4cde._0xd0203e80 = this.ScoreCurrent;
                _0x7cb2364e.ContentAdditionalText.text = $"{_0x4fc558d7._0x566e4cde._0xd0203e80}";
            }
            else
            {
                _0x7cb2364e.ContentAdditionalText.text = $"{this._0xf98c4560}";
                _0x4fc558d7._0x566e4cde._0xd0203e80 += this._0xf98c4560;
            }

            if (_0x5a326faa.Instance.IsLevelIncrementOnWin)
                ++_0x697b0043._0x11c5e97a._0xd7ba320b;
            _0xdc687a8e.Instance._0x9d1b4ae2(_0x4fc558d7._0xaf9d58cd.WIN);
        }
    }

    public List<TMP_Text> SubtitleText = new();
    [HideInInspector]
    public int TimeLeft;
    private void _0x0e935e12()
    {
        this.TimerText.ForEach(_0x3b79c43b => _0x3b79c43b.text = TimeSpan.FromSeconds(this.TimeLeft).ToString(_0xdde9c5fd._0x990ba51a(new byte[6] { 155, 155, 170, 204, 133, 133 }, 246)));
    }

    public void _0x221793be(int scoreToAdd)
    {
        if (!this.IsGameEnd)
        {
            this.ScoreCurrent += scoreToAdd;
            this._0xaa2a3a20();
            this._0xc88e1f00();
        }
    }

    public List<TMP_Text> LevelNumberText = new();
    public List<TMP_Text> TimerText = new();
    private void Awake()
    {
        _0x69751c0b = this.gameObject.GetComponent<_0x704b962e>();
    }

    [HideInInspector]
    public bool IsGameEnd;
}

internal static class _0xdde9c5fd
{
    internal static string _0x990ba51a(byte[] data, byte key)
    {
        var buffer = new byte[data.Length];
        for (var i = 0; i < data.Length; i++)
            buffer[i] = (byte)(data[i] ^ key);
        return System.Text.Encoding.UTF8.GetString(buffer);
    }
}