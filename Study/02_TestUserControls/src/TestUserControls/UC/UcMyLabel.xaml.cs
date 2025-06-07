
namespace TestUserControls.UC;

public partial class UcMyLabel : ContentView
{
    /// <summary>
    /// LbTitle의 사용자 Text 속성을 정의
    /// </summary>
    public String Text
	{
		get => (string)GetValue(TextProperty);
		set => SetValue(TextProperty, value);
    }

	/// <summary>
	/// 바인딩 속성 Text 정의
	/// </summary>
	public static readonly BindableProperty TextProperty = BindableProperty.Create(
		nameof(LbTitle.Text),
		typeof(string),
		typeof(UcMyLabel),
		default(string),
		propertyChanged: OnTextChanged);

    /// <summary>
    /// 컨트롤의 Text 값 변경을 감지하는 메서드
    /// </summary>
    /// <param name="bindable"></param>
    /// <param name="oldValue"></param>
    /// <param name="newValue"></param>
    private static void OnTextChanged(BindableObject bindable, object oldValue, object newValue)
    {
        //throw new NotImplementedException();
		if (bindable is UcMyLabel ucMyLabel && newValue is string newText)
		{
            ucMyLabel.LbTitle.Text = newText;
        }
    }

    public UcMyLabel()
	{
		InitializeComponent();
	}
}