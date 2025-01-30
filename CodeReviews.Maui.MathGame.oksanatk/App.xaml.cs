using CodeReviews.Maui.MathGame.oksanatk.Data;

namespace CodeReviews.Maui.MathGame.oksanatk
{
    public partial class App : Application
    {
        public static GameRepository GameRepository { get; set; }
        public App(GameRepository gameRepository)
        {
            InitializeComponent();

            GameRepository = gameRepository;
        }

        protected override Window CreateWindow(IActivationState? activationState)
        {
            return new Window(new AppShell());
        }

    }
}