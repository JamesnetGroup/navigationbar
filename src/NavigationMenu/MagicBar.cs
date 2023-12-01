using Jamesnet.Wpf.Animation;
using Jamesnet.Wpf.Controls;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media.Animation;

namespace NavigationMenu
{
    public class MagicBar : ListBox
    {
        private Border panel;

        static MagicBar()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(MagicBar), new FrameworkPropertyMetadata(typeof(MagicBar)));
        }

        public override void OnApplyTemplate()
        {
            base.OnApplyTemplate();

            panel = GetTemplateChild("circle") as Border;
        }

        protected override void OnSelectionChanged(SelectionChangedEventArgs e)
        {
            base.OnSelectionChanged(e);

            ValueItem vi = new();
            vi.Mode = EasingFunctionBaseMode.CubicEaseInOut;
            vi.TargetName = "circle";
            vi.Property = new PropertyPath(Canvas.LeftProperty);
            vi.Duration = new Duration(new TimeSpan(0, 0, 0, 0, 500));
            vi.To = SelectedIndex * 80;

            // Storyboard 생성 및 설정
            Storyboard storyboard = new Storyboard();
            Storyboard.SetTarget(vi, panel);
            Storyboard.SetTargetProperty(vi, vi.Property);

            // Storyboard에 애니메이션 추가
            storyboard.Children.Add(vi);

            // 애니메이션 시작
            storyboard.Begin();
        }
    }
}
