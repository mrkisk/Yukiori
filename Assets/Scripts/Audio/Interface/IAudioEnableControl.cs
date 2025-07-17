namespace Yukiori
{
    public interface IAudioEnableControl
    {
        bool IsAudioEnabled { get; }
        void SetAudioEnabled(bool enabled);
    }
}
