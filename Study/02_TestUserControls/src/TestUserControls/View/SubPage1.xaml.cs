namespace TestUserControls.View;

public partial class SubPage1 : ContentPage
{
    public SubPage1()
    {
        InitializeComponent();
    }

    /// <summary>
    /// MainPage로 돌아가는 버튼 클릭 이벤트 핸들러입니다.
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private async void OnGoToMainPageClicked(object sender, EventArgs e)
    {
        // NavigationStack에 MainPage가 있으면 PopToRootAsync로 돌아감
        await Navigation.PopToRootAsync();
    }
}
