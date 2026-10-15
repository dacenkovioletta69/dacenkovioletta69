using UnityEngine;

public class _0x5a326faa : MonoBehaviour
{
    public bool IsStoryEnabled;
    private void _0x0490b6aa()
    {
    }

    public bool IsSkipSplashEnabled;
    public bool IsLevelSelectorEnabled;
    public static _0x5a326faa Instance;
    public bool IsBestScoreEnabled;
    public bool IsTutorialEnabled;
    public bool IsCheckScoreEnabled;
    public bool IsLevelIncrementOnWin;
    public bool IsTimerEnabled;
    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this.gameObject.GetComponent<_0x5a326faa>();
            DontDestroyOnLoad(this.gameObject);
            this._0x9552f4a9();
        }
        else
        {
            this._0x0490b6aa();
            Destroy(this.gameObject);
        }
    }

    private void _0x9552f4a9()
    {
        {
#if !B_LOGS
        {
            Debug.unityLogger.logEnabled = false;
            Application.SetStackTraceLogType(LogType.Assert, StackTraceLogType.None);
            Application.SetStackTraceLogType(LogType.Exception, StackTraceLogType.None);
            Application.SetStackTraceLogType(LogType.Warning, StackTraceLogType.None);
            Application.SetStackTraceLogType(LogType.Error, StackTraceLogType.None);
            Application.SetStackTraceLogType(LogType.Log, StackTraceLogType.None);
        }
#endif
        }

        QualitySettings.vSyncCount = 1;
        Application.runInBackground = true;
    //Application.targetFrameRate = 60;
    // Time.fixedDeltaTime = 0.03f; // USE CUSTOM PHYSICS TIME FOR OPTIMIZATION IF NEEDED
    // Add this once at startup to silence the specific assertion
    }

    public bool IsOnlyWinGameEndEnabled;
}