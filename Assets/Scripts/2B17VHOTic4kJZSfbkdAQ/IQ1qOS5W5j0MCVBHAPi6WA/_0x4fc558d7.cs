using System;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public static class _0x4fc558d7
{
    public static class _0xb679ca6b
    {
        public static readonly int SPLASH = 0;
        public static readonly int DEFAULT = 1;
        public static readonly int EMPTY = 2;
        public static readonly int TUTORIAL0 = 13;
        public static readonly int TUTORIAL1 = 14;
        public static readonly int TUTORIAL2 = 15;
        public static readonly int TUTORIAL3 = 16;
        public static readonly int TUTORIAL4 = 17;
        public static readonly int TUTORIAL5 = 18;
        public static readonly int TUTORIAL6 = 19;
    }

    public class _0x8b06afc1
    {
        private static readonly _0x8b06afc1 _0xe4089016 = new();
        public static readonly _0x8b06afc1[] ALL_SCENES_SETTING_SINGLETONS =
        {
            _0xe4089016,
            _0xe4089016,
            _0xe4089016,
        };
        private int _0x080e5043 => 0;
        private int _0xe05efc47 => 10;
        private string _0xc1463f37 => _0x31a4fb77._0xba48d024(new byte[4] { 4, 44, 39, 60 }, 73);
        private string _0x83e0df2c => _0x31a4fb77._0xba48d024(new byte[8] { 124, 117, 102, 117, 124, 75, 0, 77 }, 48);

        private int _0x8d32e2ba
        {
            get
            {
                if (!PlayerPrefs.HasKey(_0x31a4fb77._0xba48d024(new byte[25] { 71, 113, 118, 118, 97, 106, 112, 67, 104, 107, 102, 101, 104, 71, 108, 101, 116, 112, 97, 118, 77, 106, 96, 97, 124 }, 4)))
                    PlayerPrefs.SetInt(_0x31a4fb77._0xba48d024(new byte[25] { 249, 207, 200, 200, 223, 212, 206, 253, 214, 213, 216, 219, 214, 249, 210, 219, 202, 206, 223, 200, 243, 212, 222, 223, 194 }, 186), 0);
                return PlayerPrefs.GetInt(_0x31a4fb77._0xba48d024(new byte[25] { 170, 156, 155, 155, 140, 135, 157, 174, 133, 134, 139, 136, 133, 170, 129, 136, 153, 157, 140, 155, 160, 135, 141, 140, 145 }, 233));
            }

            set => PlayerPrefs.SetInt(_0x31a4fb77._0xba48d024(new byte[25] { 210, 228, 227, 227, 244, 255, 229, 214, 253, 254, 243, 240, 253, 210, 249, 240, 225, 229, 244, 227, 216, 255, 245, 244, 233 }, 145), value);
        }

        public int _0xd7ba320b
        {
            get
            {
                if (!PlayerPrefs.HasKey($"{this._0xc1463f37}CurrentLevelIndex"))
                    PlayerPrefs.SetInt($"{this._0xc1463f37}CurrentLevelIndex", 0);
                return PlayerPrefs.GetInt($"{this._0xc1463f37}CurrentLevelIndex");
            }

            set => PlayerPrefs.SetInt($"{this._0xc1463f37}CurrentLevelIndex", value);
        }

        public int _0x64eb2b6b
        {
            get
            {
                if (!PlayerPrefs.HasKey($"{this._0xc1463f37}BestScore"))
                    this._0x64eb2b6b = 0;
                return PlayerPrefs.GetInt($"{this._0xc1463f37}BestScore");
            }

            set => PlayerPrefs.SetInt($"{this._0xc1463f37}BestScore", value);
        }

        public bool _0xf2fbedf8
        {
            get
            {
                if (!PlayerPrefs.HasKey($"{this._0xc1463f37}IsGameTutorPassed"))
                    PlayerPrefs.SetInt($"{this._0xc1463f37}IsGameTutorPassed", Convert.ToInt32(false));
                return PlayerPrefs.GetInt($"{this._0xc1463f37}IsGameTutorPassed") == 1;
            }

            set => PlayerPrefs.SetInt($"{this._0xc1463f37}IsGameTutorPassed", Convert.ToInt32(value));
        }
    }

    public static class _0xaf9d58cd
    {
        public static readonly int PAUSE = 6;
        public static readonly int WIN = 7;
        public static readonly int LOSE = 8;
    }

    public static class _0x566e4cde
    {
        public static int _0xd0203e80
        {
            get
            {
                if (!PlayerPrefs.HasKey(_0x31a4fb77._0xba48d024(new byte[5] { 137, 165, 163, 164, 185 }, 202)))
                    PlayerPrefs.SetInt(_0x31a4fb77._0xba48d024(new byte[5] { 200, 228, 226, 229, 248 }, 139), 0);
                return PlayerPrefs.GetInt(_0x31a4fb77._0xba48d024(new byte[5] { 219, 247, 241, 246, 235 }, 152));
            }

            set
            {
                PlayerPrefs.SetInt(_0x31a4fb77._0xba48d024(new byte[5] { 35, 15, 9, 14, 19 }, 96), value);
                _0x697b0043.Instance._0x55c2d321();
            }
        }
    }

    public static class _0xf3e0f416
    {
        public static readonly int SCENE_0 = 0;
        public static readonly int SCENE_1 = 1;
    }
}

internal static class _0x31a4fb77
{
    internal static string _0xba48d024(byte[] data, byte key)
    {
        var buffer = new byte[data.Length];
        for (var i = 0; i < data.Length; i++)
            buffer[i] = (byte)(data[i] ^ key);
        return System.Text.Encoding.UTF8.GetString(buffer);
    }
}