using UnityEngine;

/// <summary>
/// The whole app's colour vocabulary, preset CASINO_GOLD with this brief's hex values.
///
/// Every field is built from its OWN literal and reads no other field. String encryption turns
/// constants into runtime-initialised fields and the obfuscator may reorder declarations, so a
/// field that depends on a neighbour can be constructed before it and kill the entire type for
/// the process with a TypeInitializationException no compiler and no gate ever sees
/// (CLAUDE-unity.md C.52).
///
/// There is ONE font material for the whole app and its outline is <see cref = "Ink"/>, so a dark
/// face merges with its own outline into a blot. The fields marked "backing only" are measured
/// below 4.5:1 against that outline and must never be passed into a parameter that becomes a
/// text colour (C.14).
/// </summary>
public static class _0xe058d175
{
    /// <summary>#7C3AED - secondary accent, the joker, the splash aura. Backing only.</summary>
    public static readonly Color Violet = new Color(0.486274510f, 0.227450980f, 0.929411765f, 1f);
    /// <summary>#451825 - tiles, tracks, inactive chips. Backing only.</summary>
    public static readonly Color SurfaceRaise = new Color(0.270588235f, 0.094117647f, 0.145098039f, 1f);
    /// <summary>#FDE68A - highlights, sheen and sparkle. Safe as a text colour.</summary>
    public static readonly Color GoldSoft = new Color(0.992156863f, 0.901960784f, 0.541176471f, 1f);
    /// <summary>#1A0710 - the shared TMP outline and the deepest shadow. Backing only.</summary>
    public static readonly Color Ink = new Color(0.101960784f, 0.02745098f, 0.062745098f, 1f);
    /// <summary>#FCA5A5 - the destructive confirm line. 10.2:1 on the outline.</summary>
    public static readonly Color Alarm = new Color(0.988235294f, 0.647058824f, 0.647058824f, 1f);
    /// <summary>#A78BFA - secondary chips and progress tint. 7.1:1 on the outline.</summary>
    public static readonly Color VioletSoft = new Color(0.654901961f, 0.545098039f, 0.980392157f, 1f);
    /// <summary>#FFFFFF - the brightest caption weight.</summary>
    public static readonly Color White = new Color(1f, 1f, 1f, 1f);
    /// <summary>The same hue at another alpha, so a tint never needs a second literal.</summary>
    public static Color Alpha(Color _0xf4ce6e67, float _0xc1581cee)
    {
        return new Color(_0xf4ce6e67.r, _0xf4ce6e67.g, _0xf4ce6e67.b, _0xc1581cee);
    }

    /// <summary>#E7C9A9 - body copy. 11:1 on the outline.</summary>
    public static readonly Color TextSecondary = new Color(0.905882353f, 0.788235294f, 0.662745098f, 1f);
    /// <summary>#34121C - cards, pop bodies, the top bar. Backing only.</summary>
    public static readonly Color Surface = new Color(0.203921569f, 0.070588235f, 0.109803922f, 1f);
    /// <summary>#B91C1C - primary button faces and win bars. 2.99:1 on the outline: backing only.</summary>
    public static readonly Color Ruby = new Color(0.725490196f, 0.109803922f, 0.109803922f, 1f);
    /// <summary>#FFF7E8 - headings and button captions. 18:1 on the outline.</summary>
    public static readonly Color TextPrimary = new Color(1f, 0.968627451f, 0.909803922f, 1f);
    /// <summary>#140509 - splash wash, scrims, vignette. Backing only.</summary>
    public static readonly Color Abyss = new Color(0.078431373f, 0.019607843f, 0.035294118f, 1f);
    /// <summary>#FACC15 - the accent. 12.7:1 on the outline, so it is also a text colour.</summary>
    public static readonly Color Gold = new Color(0.980392157f, 0.800000000f, 0.082352941f, 1f);
    /// <summary>#C9A98C - disclaimers and hints. 8.9:1 on the outline.</summary>
    public static readonly Color TextMuted = new Color(0.788235294f, 0.662745098f, 0.549019608f, 1f);
    /// <summary>#230B13 - scene ground and panel fill. Backing only.</summary>
    public static readonly Color Ground = new Color(0.137254902f, 0.043137255f, 0.074509804f, 1f);
    /// <summary>#7F1316 - pressed state and ruby shading. Backing only.</summary>
    public static readonly Color RubyDeep = new Color(0.498039216f, 0.074509804f, 0.086274510f, 1f);
}