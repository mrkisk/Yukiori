namespace Yukiori
{
    public interface ISePlayer
    {
        void Play(SeId seId);
        void PlayLoop(SeId seId);
        void StopLoop();
    }
}
