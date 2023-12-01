using Jamesnet.Wpf.Animation;
using Jamesnet.Wpf.Controls;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media.Animation;

namespace NavigationMenu
{
    public class MagicBar : ListBox
    {
        private ValueItem _valueItem;
        private Storyboard _storyboard;

        static MagicBar()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(MagicBar), new FrameworkPropertyMetadata(typeof(MagicBar)));
        }

        public override void OnApplyTemplate()
        {
            base.OnApplyTemplate();

            Grid circle = (Grid)GetTemplateChild("circle");
            InitStoryboard(circle);
        }

        private void InitStoryboard(Grid circle)
        {
            _valueItem = new();
            _storyboard = new();

            _valueItem.Mode = EasingFunctionBaseMode.QuinticEaseInOut;
            _valueItem.Property = new PropertyPath(Canvas.LeftProperty);
            _valueItem.Duration = new Duration(new TimeSpan(0, 0, 0, 0, 500));

            Storyboard.SetTarget(_valueItem, circle);
            Storyboard.SetTargetProperty(_valueItem, _valueItem.Property);

            _storyboard.Children.Add(_valueItem);
        }

        protected override void OnSelectionChanged(SelectionChangedEventArgs e)
        {
            base.OnSelectionChanged(e);

            _valueItem.To = SelectedIndex * 80;
            _storyboard.Begin();
        }
    }
}