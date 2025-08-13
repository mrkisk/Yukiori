namespace Yukiori
{
    public interface ISeManager
    {
        void Play(SeId seId);
        void PlayLoop(SeId seId);
        void StopLoop();
    }
}
