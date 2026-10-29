using TMPro;
using UnityEngine;
using UnityEngine.UI;

/// <summary>
/// Dresses the three result cards - WIN (7), LOSE (8) and PAUSE (6) - and silences every other
/// popup and panel the template ships but this game never opens.
///
/// Three things that are easy to get wrong on this template family, all handled here:
///
/// 1. <c>ContentMainText</c> arrives DEACTIVATED on the win and lose cards and active only on
///    pause. Writing a string into a deactivated label is invisible, so the object is switched
///    back on from code. A scene modification could not do it - Unity silently discards an
///    m_IsActive override written into the wrong prefab instance (C.2) - but the label is
///    reached here through the template's own serialized field, which always resolves.
///
/// 2. <c>ContentAdditionalText</c> is <c>{fileID: 0}</c> on all three, so the extra line is
///    folded into the main text behind an explicit \n rather than written to a null reference.
///
/// 3. The buttons already carry their drivers (a template <c>LoadSceneButton</c> on the action
///    buttons, a pop-hiding driver on the cross). NOT ONE listener is added to them: an added
///    onClick fires ALONGSIDE the driver and runs two scene loads from a single tap. Only the
///    captions are set - and each button gets its OWN, told apart by its driver rather than by
///    traversal order, because the first button a traversal returns is usually the cross
///    (C.17).
/// </summary>
public sealed class _0x60393d30 : MonoBehaviour
{
    /// <summary>
    /// The refill card. This game has no fail state: running short of coins hands the player
    /// more, so no screen other than the reels can ever become the resting state.
    /// </summary>
    public void _0xa90cab98(int _0x740e466f)
    {
        _0xdc687a8e _0x9b046e2c = _0xdc687a8e.Instance;
        if (_0x9b046e2c == null || _0x9b046e2c.Pops == null)
            return;
        this._0x06c0b099(_0x9b046e2c._0x8a61a0fe(_0x4fc558d7._0xaf9d58cd.LOSE), _0xf4e68246._0x4a9bb664(new byte[14] { 173, 186, 174, 183, 175, 219, 169, 190, 189, 178, 183, 183, 190, 191 }, 251), _0xf4e68246._0x4a9bb664(new byte[1] { 47 }, 4) + _0x999838f3.Money(_0x740e466f) + _0xf4e68246._0x4a9bb664(new byte[39] { 217, 191, 171, 188, 188, 217, 186, 182, 176, 183, 170, 243, 173, 177, 188, 217, 177, 182, 172, 170, 188, 217, 178, 188, 188, 169, 170, 217, 160, 182, 172, 217, 169, 181, 184, 160, 176, 183, 190 }, 249));
        _0x9b046e2c._0x9d1b4ae2(_0x4fc558d7._0xaf9d58cd.LOSE);
    }

    /// <summary>
    /// Recolours a card to the parlour palette and captions each of its buttons separately.
    /// The two groups are told apart by SHAPE, not by name: of the card body's children, the
    /// one holding the most buttons is the action row and the other is the corner cross. Both
    /// names are obfuscated in the shipped build, so nothing may be matched against them.
    /// </summary>
    private void _0x95ac2db0(_0x62964e65 _0x237f1bb0, string _0x96a0d7e2, string _0x408e153c, string _0x38599bf8)
    {
        if (_0x237f1bb0 == null || _0x237f1bb0.Content == null)
            return;
        Transform _0xca59a6d0 = _0x237f1bb0.Content.transform;
        Transform _0x52e2fc5b = null;
        Transform _0x221c0787 = null;
        int _0x95530b07 = 0;
        for (int _0x1beecd17 = 0; _0x1beecd17 < _0xca59a6d0.childCount; _0x1beecd17++)
        {
            Transform _0xb1192b60 = _0xca59a6d0.GetChild(_0x1beecd17);
            int _0xc3114e2f = _0xb1192b60.GetComponentsInChildren<Button>(true).Length;
            if (_0xc3114e2f <= 0)
                continue;
            if (_0xc3114e2f > _0x95530b07)
            {
                if (_0x52e2fc5b != null)
                    _0x221c0787 = _0x52e2fc5b;
                _0x95530b07 = _0xc3114e2f;
                _0x52e2fc5b = _0xb1192b60;
            }
            else if (_0x221c0787 == null)
            {
                _0x221c0787 = _0xb1192b60;
            }
        }

        if (_0x52e2fc5b != null)
        {
            Button[] _0xb8afa594 = _0x52e2fc5b.GetComponentsInChildren<Button>(false);
            for (int _0xc0ad919d = 0; _0xc0ad919d < _0xb8afa594.Length; _0xc0ad919d++)
                Caption(_0xb8afa594[_0xc0ad919d], CaptionFor(_0xb8afa594[_0xc0ad919d], _0x96a0d7e2, _0x408e153c, _0x38599bf8));
        }

        // The cross carries a glyph, not a word. A caption on it is the classic C.17 defect:
        // a pause card with three buttons all reading RESUME, the corner cross included.
        if (_0x221c0787 != null)
        {
            Button[] _0xa3a8f9d7 = _0x221c0787.GetComponentsInChildren<Button>(false);
            for (int _0x8f0748ed = 0; _0x8f0748ed < _0xa3a8f9d7.Length; _0x8f0748ed++)
                Caption(_0xa3a8f9d7[_0x8f0748ed], _0xf4e68246._0x4a9bb664(new byte[1] { 37 }, 125));
        }

        this._0x749e60f9(_0x237f1bb0);
    }

    /// <summary>Writes one button's caption and keeps it inside the readability floor.</summary>
    private static void Caption(Button _0x63f1bc70, string _0x75e02cb8)
    {
        if (_0x63f1bc70 == null)
            return;
        TMP_Text _0x794b5bc0 = _0x63f1bc70.GetComponentInChildren<TMP_Text>(true);
        if (_0x794b5bc0 == null)
            return;
        _0x794b5bc0.text = _0x75e02cb8;
        _0x794b5bc0.color = _0xe058d175.TextPrimary;
        _0x794b5bc0.textWrappingMode = TextWrappingModes.NoWrap;
        _0x794b5bc0.enableAutoSizing = true;
        _0x794b5bc0.fontSizeMin = _0xcecf7be6.MinFont;
        if (_0x794b5bc0.fontSizeMax < _0xcecf7be6.MinFont)
            _0x794b5bc0.fontSizeMax = 44f;
        _0x77b5335c.ApplyOutline(_0x794b5bc0, _0xe058d175.TextPrimary);
    }

    /// <summary>
    /// Empties every popup and panel this game never opens. The template defines far more of
    /// both than any one game uses, and whatever is left undressed ships with its placeholder
    /// wording - "Lorem Ipsum" on the tutorial panels, somebody else's result text on the
    /// spare cards (C.15).
    ///
    /// They are emptied, never deactivated: the controllers address panels and popups by
    /// index, and pulling one out of the list breaks the navigation of the ones that remain.
    /// </summary>
    private void _0x0fb404ae(_0xdc687a8e _0xd826c117)
    {
        for (int _0x2f1eb5f2 = 0; _0x2f1eb5f2 < _0xd826c117.Pops.Count; _0x2f1eb5f2++)
        {
            if (_0x2f1eb5f2 == _0x4fc558d7._0xaf9d58cd.WIN || _0x2f1eb5f2 == _0x4fc558d7._0xaf9d58cd.LOSE || _0x2f1eb5f2 == _0x4fc558d7._0xaf9d58cd.PAUSE)
                continue;
            _0x62964e65 _0xd8410d0d = _0xd826c117.Pops[_0x2f1eb5f2];
            if (_0xd8410d0d == null)
                continue;
            Blank(_0xd8410d0d.Content != null ? _0xd8410d0d.Content : _0xd8410d0d.gameObject);
        }

        _0x868e2cfd _0x9be7167f = _0x868e2cfd.Instance;
        if (_0x9be7167f == null || _0x9be7167f.Panels == null)
            return;
        for (int _0x8f4d0ec7 = 0; _0x8f4d0ec7 < _0x9be7167f.Panels.Count; _0x8f4d0ec7++)
        {
            if (_0x8f4d0ec7 == _0x4fc558d7._0xb679ca6b.SPLASH || _0x8f4d0ec7 == _0x4fc558d7._0xb679ca6b.DEFAULT)
                continue;
            _0x39e04600 _0xad63ca45 = _0x9be7167f.Panels[_0x8f4d0ec7];
            if (_0xad63ca45 == null)
                continue;
            // Content is a serialized reference the template leaves UNASSIGNED on some panels
            // and pops of this family. Skipping those would leave exactly the placeholder
            // C.15 is about, so sweep from the object itself instead. The loop runs over every
            // index, so the whole tutorial group (TUTORIAL0..TUTORIAL6 = 13..19) is covered
            // without addressing a single one of them by name.
            Blank(_0xad63ca45.Content != null ? _0xad63ca45.Content : _0xad63ca45.gameObject);
        }
    }

    /// <summary>The pause card.</summary>
    public void _0x270d6bd3()
    {
        _0xdc687a8e _0xbd4f093e = _0xdc687a8e.Instance;
        if (_0xbd4f093e == null || _0xbd4f093e.Pops == null)
            return;
        this._0x06c0b099(_0xbd4f093e._0x8a61a0fe(_0x4fc558d7._0xaf9d58cd.PAUSE), _0xf4e68246._0x4a9bb664(new byte[6] { 193, 208, 196, 194, 212, 213 }, 145), _0xf4e68246._0x4a9bb664(new byte[12] { 246, 227, 233, 231, 130, 227, 130, 224, 240, 231, 227, 233 }, 162));
        _0xbd4f093e._0x9d1b4ae2(_0x4fc558d7._0xaf9d58cd.PAUSE);
    }

    /// <summary>Set once the three cards have been given their look and their captions.</summary>
    private bool _0xa1beffdc;
    /// <summary>Sets a card's two lines, switching the body label on if the template left it off.</summary>
    private void _0x06c0b099(_0x62964e65 _0x2c845ad7, string _0xed1d28b5, string _0x178ef03a)
    {
        if (_0x2c845ad7 == null)
            return;
        if (_0x2c845ad7.ContentHeaderText != null)
        {
            _0x2c845ad7.ContentHeaderText.text = _0xed1d28b5;
            _0x2c845ad7.ContentHeaderText.color = _0xe058d175.Gold;
            _0x2c845ad7.ContentHeaderText.textWrappingMode = TextWrappingModes.NoWrap;
            _0x2c845ad7.ContentHeaderText.enableAutoSizing = true;
            _0x2c845ad7.ContentHeaderText.fontSizeMin = _0xcecf7be6.MinFont;
            _0x2c845ad7.ContentHeaderText.fontSizeMax = 64f;
            _0x77b5335c.ApplyOutline(_0x2c845ad7.ContentHeaderText, _0xe058d175.Gold);
            _0x2c845ad7.ContentHeaderText.gameObject.SetActive(true);
        }

        if (_0x2c845ad7.ContentMainText != null)
        {
            _0x2c845ad7.ContentMainText.text = _0x178ef03a;
            _0x2c845ad7.ContentMainText.color = _0xe058d175.TextPrimary;
            _0x2c845ad7.ContentMainText.textWrappingMode = TextWrappingModes.NoWrap;
            _0x2c845ad7.ContentMainText.enableAutoSizing = true;
            _0x2c845ad7.ContentMainText.fontSizeMin = _0xcecf7be6.MinFont;
            _0x2c845ad7.ContentMainText.fontSizeMax = 44f;
            _0x2c845ad7.ContentMainText.alignment = TextAlignmentOptions.Center;
            _0x77b5335c.ApplyOutline(_0x2c845ad7.ContentMainText, _0xe058d175.TextPrimary);
            _0x2c845ad7.ContentMainText.gameObject.SetActive(true);
        }

        // The field is {fileID: 0} on every card of this family; guarded rather than assumed.
        if (_0x2c845ad7.ContentAdditionalText != null)
        {
            _0x2c845ad7.ContentAdditionalText.color = _0xe058d175.TextSecondary;
            _0x77b5335c.ApplyOutline(_0x2c845ad7.ContentAdditionalText, _0xe058d175.TextSecondary);
        }
    }

    /// <summary>True while any of the three cards is on screen.</summary>
    public bool _0x5b11844c()
    {
        _0xdc687a8e _0x71201f67 = _0xdc687a8e.Instance;
        if (_0x71201f67 == null || _0x71201f67.Pops == null)
            return false;
        return IsOpen(_0x71201f67._0x8a61a0fe(_0x4fc558d7._0xaf9d58cd.WIN)) || IsOpen(_0x71201f67._0x8a61a0fe(_0x4fc558d7._0xaf9d58cd.LOSE)) || IsOpen(_0x71201f67._0x8a61a0fe(_0x4fc558d7._0xaf9d58cd.PAUSE));
    }

    /// <summary>Clears every label under a host.</summary>
    private static void Blank(GameObject _0xa3f2a379)
    {
        TMP_Text[] _0x2e6ad306 = _0xa3f2a379.GetComponentsInChildren<TMP_Text>(true);
        for (int _0x1cd5abcb = 0; _0x1cd5abcb < _0x2e6ad306.Length; _0x1cd5abcb++)
            if (_0x2e6ad306[_0x1cd5abcb] != null)
                _0x2e6ad306[_0x1cd5abcb].text = string.Empty;
    }

    /// <summary>
    /// Pulls the card off the template grey and onto the parlour palette. Images are found by
    /// COMPONENT TYPE; the one that fills the card is the largest, which is a measurement
    /// rather than a name (C.3).
    /// </summary>
    private void _0x749e60f9(_0x62964e65 _0xe2e3d2b1)
    {
        if (_0xe2e3d2b1 == null || _0xe2e3d2b1.Content == null)
            return;
        Image[] _0xda728349 = _0xe2e3d2b1.Content.GetComponentsInChildren<Image>(true);
        Image _0x57e098c5 = null;
        float _0x1931e331 = 0f;
        for (int _0x0dca923f = 0; _0x0dca923f < _0xda728349.Length; _0x0dca923f++)
        {
            Image _0x8e64e31d = _0xda728349[_0x0dca923f];
            if (_0x8e64e31d == null || _0x8e64e31d.rectTransform == null)
                continue;
            Rect _0x9928c89d = _0x8e64e31d.rectTransform.rect;
            float _0xf2bd83e5 = Mathf.Abs(_0x9928c89d.width * _0x9928c89d.height);
            if (_0xf2bd83e5 <= _0x1931e331)
                continue;
            _0x1931e331 = _0xf2bd83e5;
            _0x57e098c5 = _0x8e64e31d;
        }

        if (_0x57e098c5 != null)
            _0x57e098c5.color = _0xe058d175.Alpha(_0xe058d175.Surface, 0.98f);
    }

    /// <summary>Builds the cards if nobody has yet, so no component depends on Start order.</summary>
    public void _0xcb550624()
    {
        if (!this._0xa1beffdc)
            this._0xf3372c07();
    }

    /// <summary>The win card, with the payout and the line that produced it.</summary>
    public void _0x10cf7326(int _0x1b75d6c3, string _0xd5adcd8d)
    {
        _0xdc687a8e _0x837128a2 = _0xdc687a8e.Instance;
        if (_0x837128a2 == null || _0x837128a2.Pops == null)
            return;
        this._0x06c0b099(_0x837128a2._0x8a61a0fe(_0x4fc558d7._0xaf9d58cd.WIN), _0xf4e68246._0x4a9bb664(new byte[7] { 68, 79, 65, 38, 81, 79, 72 }, 6), _0xf4e68246._0x4a9bb664(new byte[1] { 36 }, 15) + _0x999838f3.Money(_0x1b75d6c3) + _0xf4e68246._0x4a9bb664(new byte[7] { 142, 237, 225, 231, 224, 253, 164 }, 174) + _0xd5adcd8d);
        _0x837128a2._0x9d1b4ae2(_0x4fc558d7._0xaf9d58cd.WIN);
    }

    /// <summary>Dresses all three cards and blanks everything else. Safe to call twice.</summary>
    public void _0xf3372c07()
    {
        _0xdc687a8e _0x2f18f12a = _0xdc687a8e.Instance;
        if (_0x2f18f12a == null || _0x2f18f12a.Pops == null)
            return;
        this._0x95ac2db0(_0x2f18f12a._0x8a61a0fe(_0x4fc558d7._0xaf9d58cd.WIN), _0xf4e68246._0x4a9bb664(new byte[7] { 183, 180, 173, 170, 196, 171, 170 }, 228), _0xf4e68246._0x4a9bb664(new byte[5] { 239, 236, 225, 225, 250 }, 163), _0xf4e68246._0x4a9bb664(new byte[7] { 240, 243, 234, 237, 131, 236, 237 }, 163));
        this._0x95ac2db0(_0x2f18f12a._0x8a61a0fe(_0x4fc558d7._0xaf9d58cd.LOSE), _0xf4e68246._0x4a9bb664(new byte[13] { 27, 21, 21, 0, 112, 3, 0, 25, 30, 30, 25, 30, 23 }, 80), _0xf4e68246._0x4a9bb664(new byte[5] { 248, 251, 246, 246, 237 }, 180), _0xf4e68246._0x4a9bb664(new byte[13] { 124, 114, 114, 103, 23, 100, 103, 126, 121, 121, 126, 121, 112 }, 55));
        this._0x95ac2db0(_0x2f18f12a._0x8a61a0fe(_0x4fc558d7._0xaf9d58cd.PAUSE), _0xf4e68246._0x4a9bb664(new byte[6] { 113, 102, 112, 118, 110, 102 }, 35), _0xf4e68246._0x4a9bb664(new byte[5] { 167, 164, 169, 169, 178 }, 235), _0xf4e68246._0x4a9bb664(new byte[6] { 160, 183, 161, 167, 191, 183 }, 242));
        this._0x06c0b099(_0x2f18f12a._0x8a61a0fe(_0x4fc558d7._0xaf9d58cd.WIN), _0xf4e68246._0x4a9bb664(new byte[7] { 236, 231, 233, 142, 249, 231, 224 }, 174), _0xf4e68246._0x4a9bb664(new byte[18] { 23, 11, 6, 99, 17, 6, 6, 15, 16, 99, 2, 17, 6, 99, 20, 2, 17, 14 }, 67));
        this._0x06c0b099(_0x2f18f12a._0x8a61a0fe(_0x4fc558d7._0xaf9d58cd.LOSE), _0xf4e68246._0x4a9bb664(new byte[14] { 28, 11, 31, 6, 30, 106, 24, 15, 12, 3, 6, 6, 15, 14 }, 74), _0xf4e68246._0x4a9bb664(new byte[27] { 239, 243, 254, 155, 243, 244, 238, 232, 254, 155, 240, 254, 254, 235, 232, 155, 226, 244, 238, 155, 235, 247, 250, 226, 242, 245, 252 }, 187));
        this._0x06c0b099(_0x2f18f12a._0x8a61a0fe(_0x4fc558d7._0xaf9d58cd.PAUSE), _0xf4e68246._0x4a9bb664(new byte[6] { 225, 240, 228, 226, 244, 245 }, 177), _0xf4e68246._0x4a9bb664(new byte[12] { 130, 151, 157, 147, 246, 151, 246, 148, 132, 147, 151, 157 }, 214));
        this._0x0fb404ae(_0x2f18f12a);
        this._0xa1beffdc = true;
    }

    /// <summary>
    /// Which word a button gets, decided by the driver sitting on it. A button that reloads
    /// this scene is the "go again" action; one that loads another scene is the way out; one
    /// with no scene driver at all only closes the card, which is what RESUME means.
    /// </summary>
    private static string CaptionFor(Button _0x27bdec60, string _0x277ca214, string _0x4e0ac4ac, string _0x3c05dc9e)
    {
        if (_0x27bdec60 == null)
            return _0x3c05dc9e;
        _0x32030645 _0xc65bf4a8 = _0x27bdec60.GetComponent<_0x32030645>();
        if (_0xc65bf4a8 == null)
            _0xc65bf4a8 = _0x27bdec60.GetComponentInParent<_0x32030645>();
        if (_0xc65bf4a8 == null)
            return _0x3c05dc9e;
        return _0xc65bf4a8.IsLoadCurrentScene ? _0x277ca214 : _0x4e0ac4ac;
    }

    private static bool IsOpen(_0x62964e65 _0x0e4e45c6)
    {
        return _0x0e4e45c6 != null && _0x0e4e45c6.Content != null && _0x0e4e45c6.Content.activeInHierarchy;
    }
}

internal static class _0xf4e68246
{
    internal static string _0x4a9bb664(byte[] data, byte key)
    {
        var buffer = new byte[data.Length];
        for (var i = 0; i < data.Length; i++)
            buffer[i] = (byte)(data[i] ^ key);
        return System.Text.Encoding.UTF8.GetString(buffer);
    }
}