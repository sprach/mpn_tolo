namespace TestUserControls.View;

public partial class MainPage : ContentPage
{
    public MainPage()
    {
        InitializeComponent();
    }

    /// <summary>
    /// SubPage1로 이동하는 버튼 클릭 이벤트 핸들러
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private async void OnGoToSubPage1Clicked(object sender, EventArgs e)
    {
        // SubPage1로 이동하는 코드 예시
        await Navigation.PushAsync(new SubPage1());
    }
}
