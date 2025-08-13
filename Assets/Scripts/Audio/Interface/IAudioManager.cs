namespace Yukiori
{
    public interface IAudioManager
    {
        bool IsAudioEnabled { get; }
        void SetAudioEnabled(bool enabled);
    }
}
