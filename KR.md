## (Magic) NavigationBar 컨트롤 소개
<img width="511" alt="스크린샷 2024-01-02 오후 11 32 08" src="https://github.com/vickyqu115/navigationbar/assets/101777355/93dc0aaf-d4ce-4d4e-abb2-8a1529019b07">

WPF 애플리케이션은 전통적으로 메뉴 구성을 통해 여러 화면을 연결하고, 이를 통합하여 제공하는 프로그램 방식을 선호합니다. 따라서 메뉴 또는 Navigation으로 불리는 이 기술은 WPF의 핵심 구현 중 하나입니다. 또한 프로젝트의 아키텍처(설계)와도 직접적인 연관이 있기 때문에 이를 좀 더 신경 써서 구현한다면 프로젝트의 품질 향상에도 긍정적인 효과를 기대할 수 있습니다.

이 컨트롤은 모바일에 특화된 디자인과 애니메이션을 구성하고 있지만, WPF에서 제공하는 ListBox와 Animation 기술을 사용한다면 구조적으로도 뛰어나고 우아하게 구현할 수 있습니다. 또한 AvaloniaUI, Uno, OpenSilver, MAUI와 같은 Cross-Platform에서도 이와 유사한 방식으로 구현할 수 있기 때문에 다양한 플랫폼을 통해 이 프로젝트가 연구, 응용되는 것을 기대합니다.

그리고 WPF 구현의 유연함과 우수성을 널리 알리고 또 기술을 공유하는 것에도 목적을 두고 있습니다. 이번 프로젝트를 통해 WPF의 매력을 한번 깊이 있게 경험해보시기 바랍니다. 



## Tutorial 영상과 CodeProject Article을 통한 학습 제공

이 컨트롤은 약 30분 분량의 Tutorial 영상을 제공하고 있습니다. 영어와 중국어 음성을 제공하고 있으며, 한국어 자막도 지원하고 있습니다. Tutorial 영상을 만드는 데에는 생각보다 많은 시간과 노력이 필요하며, 영상을 제작함에 있어 큰 어려움을 겪고 있지만 여러분의 응원과 격려가 큰 동기부여가 되어가고 있습니다.

아래 선호하는 플랫폼을 통해 추가적으로 학습할 수 있습니다.

- Youtube: 영어(한국어) Tutorial 영상
- BiliBili: 중국어 Tutorial 영상
- CodeProject: 영문 Article 개시

그 밖에도 ThemeSwitch, Lol-PlayButton 등의 Tutorial 영상이 있으니 함께 살펴보시길 바랍니다.



## 디자인과 구조의 철학

이 컨트롤 방식은 웹 또는 모바일을 통해 널리 사용되고 있는 Navigation 구성 중 하나입니다. 따라서 IOS, Android 또는 HTML/CSS 기술을 통해 구현하는 것을 주위에서도 흔히 볼 수 있습니다. CSS/HTML, Javascript 기술을 통해 이를 구현할 경우 구조와 Animation 동작 등의 기능을 상대적으로 손쉽게 구현할 수 있습니다. 그에 반면, WPF에서는 XAML을 통한 디자인부터 이벤트와 애니메이션 구현까지 비교적으로 좀 더 복잡하게 느껴 질 수 가 있습니다. 따라서 이번 컨트롤의 구현의 핵심은 WPF의 특성을 잘 살려, 구조적으로 우수한 WPF의 강점을 느낄 수 있도록 수준 높은 구현 방법을 제공합니다.

이 프로젝트는 Source code의 Refactoring을 통해 품질에 많은 신경을 쓰고 있습니다. 계층적인 XAML 구조를 최소화/최적화 하며, CustomControl 활용을 통해 XAML과 Behind code간의 상호작용을 통해 코드의 품질을 높이는 데에 중점을 두고 있습니다. 따라서 단순 기능을 포함한 컨트롤을 제공하는 것이 아니라, 기술의 영감을 전하고 다양하게 응용을 해 나아갈 수 있도록 구조적인 철학에 대해서도 설명하고 있습니다.



## 프로젝트 개요
#### MagicBar.cs

이번 프로젝트에서 핵심 컨트롤이 될 MagicBar는 ListBox 컨트롤을 상속 받는 CustomControl입니다. 대부분의 개발 상황에서는 UserControl을 선택하는 것이 일반적이지만, 지금과 같이 복합적인 기능과 애니메이션, 그리고 반복되는 요소들을 포함하게 되는 기능의 경우 UserControl보다 작은 규모의 Control(CustomControl) 단위로 나누어 구현하는 것이 효과적입니다.

CustomControl에 대한 준비가 되어있지 않은 경우 아래 내용을 잘 읽어보시기 바랍니다.

> 단 CustomControl의 방식 자체는 기술적으로 난이도가 높으며, Windows Forms 환경과 같은 기존의 전통적인 데스크톱 방식과도 개념적으로 많이 차이가 있기 때문에 이를 쉽게 접근하기에는 다소 어려운 것이 현실입니다.  또한 참고를 위한 References 자료를 찾는 데도 어려움이 많습니다. 하지만 이는 WPF 기술력을 한 단계 더 끌어올리기 위해 거쳐야 할 중요한 과정 중 하나입니다. 이번 기회에 CustomControl 구현 방식에 대해 열린 마음으로 도전해보는 것을 기대합니다.

#### Generic.xaml

CustomControl은 XAML Design 영역을 분리하여 관리하는 것이 특징입니다. 따라서 XAML 영역과 컨트롤(Class)간의 직접적인 상호작용을 제공하지 않습니다. 따라서 두 영역 간의 상호작용을 또 다른 우회적인 방법을 통해 지원합니다. 첫 번째 방법으로는 OnApplyTemplate 시점을 통한 Template 영역을 탐색하는 방식입니다. 두 번째 방법으로는 DependencyProperty 선언을 통해 바인딩을 확장하는 방식입니다.

이러한 구조적인 특성을 통해 디자인과 코드를 완벽하게 분리하여 코드의 재 사용성과 확장성을 향상 시키고 WPF 본연의 전통적인 구조를 제대로 이해할 수 있게 됩니다. 우리가 사용하는 WPF의 모든 컨트롤 또한 이와 동일한 방식을 가지고 있습니다. 이를 확인하기 위해서는 GitHub Repository 저장소를 통해 무료로 공개하고 있는 [dotnet/wpf](https://github.com/dotnet/wpf) 오픈소스를 직접 살펴보는 것이 가능합니다.




## 1. XAML 구성

#### Geometry 소개

Geometry는 WPF에서 제공하는 디자인 요소 중 하나이며,  Vector 기반의 디자인을 사용하기 위해 제공되는 요소입니다. 과거 전통적인  개발 방식에서는 png, jpeg와 같은 비트맵 이미지를 선호했었다면, 현재는 Vector 기반의 디자인을 점차 선호하고 있는 것이 현실입니다. 이는 컴퓨터 성능 향상과 모니터 해상도의 발전, 그리고 디자인 트렌드의 변화를 이유로 생각할 수 있습니다. 따라서 이번 컨트롤에서도 Geometry 요소가 차지하는 비중이 큽니다. 후반부의 Circle 구현 과정에서 이를 더 자세하게 설명하고 있습니다.

#### Animation 요소와 ItemsPresenter 분리

MagicBar는 ListBox 컨트롤을 상속 받고, ItemsControl 특성을 통해 제공되는 ItemsPresenter 요소를 사용하는 것이 특징입니다.  하지만 ItemsPresenter 요소에 포함된 하위 자식 항목 간의 상호작용은 불가능합니다. 이는 자식 항목 간의 Animation 동작을 이어 가는 것 또한 불가능하다는 의미입니다.

ItemsPresenter 요소는 ItemsPanelTemplate을 통해 지정된 Panel 종류에 따라 ListBoxItem의 동작 방식이 결정됩니다. 따라서 어떠한 Panel 레이아웃을 선택하는지에 따라 ListBoxItem 동작 방식에 영향을 주게 됩니다. StackPanel의 경우에는 Children 컬렉션을 통해 추가된 자식 요소의 순서를 통해 위치가 결정되며, Grid의 경우에는 Row/Column 설정에 따라 배치가 결정됩니다. 

따라서 자식 요소 간의 Animation 동작을 연계하는 것이 구조적으로 불가능합니다.

> 단 예외도 존재합니다. Canvas의 경우에는 좌표 개념을 사용하기 때문에, 이 좌표를 통해 Animation의 상호작용을 하는 것이 가능하나, 모든 컨트롤에 대한 처리가 필요하기 때문에 복잡한 계산과 함께 정교한 구현이 필요합니다. 그러나 이보다도 더 좋은 구현 방법이 있기 때문에 이번 내용에서는 Canvas 컨트롤에 대한 내용은 배제합니다.

#### ListBox ControlTemplate 계층 구조

보통 ListBox 컨트롤을 구현할 때, 하위 자식 요소인 ListBoxItem 컨트롤을 더 비중 있게 활용하는 것이 일반적이지만, 이번 컨트롤의 핵심 기능인 Circle 구조가 ItemsPresenter 요소의 영역 바깥에 자리해야 하기 때문에 ListBox 컨트롤에서 복합적인 Template을 구성하는 것이 핵심입니다. 

따라서 ControlTemplate의 계층 구조는 다음과 같습니다.

> 아래는 실제 Source code 내용과는 다르며, 핵심 내용과 개념을 보기 쉽게 단순화한 것입니다. Circle 부분은 본문에서 "PART_Circle"을 통해 쉽게 찾을 수 있습니다.

```xaml
<ControlTemplate TargetType="{x:Type ListBox}">
    <Grid>
        <Circle/>
    	<ItemsPresenter/>
    </Grid>
</ControlTemplate>
```

위에서 보는 것과 같이 ItemsPresenter와 Circle의 위치가 계층적으로 동일한 레벨에 위치하도록 하는 것이 핵심입니다. 이를 통해 Circle 요소의 Animiation 범위를 마치 ItemsPresenter 자식 요소를 자유롭게 넘나드는 것처럼 배치하는 것이 핵심 포인트입니다. 또한 ListBoxItem 요소의 아이콘과 텍스트가 시각적으로 Circle을 가리지 않도록 해야 하기 때문에 ItemsPresenter 요소를 Circle 보다 앞(Front)으로 배치하는 것입니다.

이론적인 이야기를 나누었으니, 실제 구현된 소스코드를 통해 자세하게 비교해보겠습니다.
> x:Name="PART_Circle" 영역이 바로 Circle에 해당됩니다.
```xaml
<Style TargetType="{x:Type local:MagicBar}">
<Setter Property="ItemContainerStyle" Value="{StaticResource MagicBarItem}"/>
<Setter Property="SnapsToDevicePixels" Value="True"/>
<Setter Property="UseLayoutRounding" Value="True"/>
<Setter Property="Background" Value="Transparent"/>
<Setter Property="Width" Value="440"/>
<Setter Property="Height" Value="120"/>
<Setter Property="Template">
    <Setter.Value>
	<ControlTemplate TargetType="{x:Type local:MagicBar}">
	    <Grid Background="{TemplateBinding Background}">
		<Grid.Clip>
		    <RectangleGeometry Rect="0 0 440 120"/>
		</Grid.Clip>
		<Border Style="{StaticResource Bar}"/>
		<Canvas Margin="20 0 20 0">
		    <Grid x:Name="PART_Circle" Style="{StaticResource Circle}">
			<Path Style="{StaticResource Arc}"/>
			<Ellipse Fill="#222222"/>
			<Ellipse Fill="CadetBlue" Margin="6"/>
		    </Grid>
		</Canvas>
		<ItemsPresenter Margin="20 40 20 0"/>
	    </Grid>
	</ControlTemplate>
    </Setter.Value>
</Setter>
<Setter Property="ItemsPanel">
    <Setter.Value>
	<ItemsPanelTemplate>
	    <UniformGrid Columns="5"/>
	</ItemsPanelTemplate>
    </Setter.Value>
</Setter>
</Style>
```

#### ListBoxItem Template 구성

앞서 살펴봤던 ListBox 컨트롤의 Template과는 달리 ListBoxItem 구성은 비교적 간단합니다. 또한 Circle Animation 요소와도 전혀 관련이 없기 때문에 단순하게 메뉴 항목의 아이콘과 텍스트 만을 구성하게 됩니다. 

```xaml
<Style TargetType="{x:Type ListBoxItem}" x:Key="MagicBarItem">
    <Setter Property="FocusVisualStyle" Value="{x:Null}"/>
    <Setter Property="Background" Value="Transparent"/>
    <Setter Property="Template">
        <Setter.Value>
            <ControlTemplate TargetType="{x:Type ListBoxItem}">
                <Grid Background="{TemplateBinding Background}">
                    <james:JamesIcon x:Name="icon" Style="{StaticResource Icon}"/>
                    <TextBlock x:Name="name" Style="{StaticResource Name}"/>
                </Grid>
            </ControlTemplate>
        </Setter.Value>
    </Setter>
</Style>
```

이 외에도, 아이콘과 텍스트의 위치와 색상을 변경하는 Animation이 추가로 포함되게 됩니다. 그리고 앞서 언급을 한 것처럼, 실제로 이번 ListBoxItem 요소에서는 특별한 기능을 구현할 필요가 없습니다.

> JamesIcon은 NuGet을 통해 제공하는 Jamesnet.Wpf 라이브러리를 통해 제공하는 컨트롤이며, 기본적으로 다양한 아이콘을 제공하고 있습니다. 이를 대체하기 위해서는 Path 컨트롤을 사용하여 Geometry 디자인을 직접 구현하거나, 배경이 투명(Transparent)한 이미지를 사용하는 것이 가능합니다.

#### JamesIcon 스타일

JamesIcon은 내부적으로 Path 컨트롤을 포함하고 있으며, 외부에서도 유연하게 디자인을 정의할 수 있도록 다양한 DependencyProperty 속성을 제공합니다. 대표적으로는 Icon, Width, Height, Fill 등의 속성을 찾아볼 수 있습니다.

> Vector 기반의 Geometry 아이콘은 일관성 있는 디자인을 제공하기 때문에 컨트롤의 품질을 높일 수 있는 방법 중 하나입니다. 따라서 이러한 차이를 한번 잘 살펴보시길 바랍니다.

```xaml
<Style TargetType="{x:Type james:JamesIcon}" x:Key="Icon">
    <Setter Property="Icon" Value="{TemplateBinding Tag}"/>
    <Setter Property="Width" Value="40"/>
    <Setter Property="Height" Value="40"/>
    <Setter Property="Fill" Value="#44333333"/>
</Style>
```

#### RelativeSource 바인딩

JamesIcon 스타일은 Template으로부터 분리되기 때문에 위와 같이 TemplateBinding Tag 바인딩을 활용하는 것이 불가능합니다.

```xaml
// 불가능한 바인딩 방식
<Setter Property="Icon" Value="{TemplateBinding Tag}"/>
```

따라서 아래와 같이 RelativeSource 바인딩을 통해 상위 부모 요소인 ListBoxItem을 탐색하여 Tag 속성을 바인딩을 합니다.

```xaml
<... Value="{Binding RelativeSource={RelativeSource AncestorType=ListBoxItem}, Path=Tag}"/>
```

RelativeSource 바인딩을 사용함으로써, ListBoxItem 영역 내에 처음 정의된 아이콘의 TemplateBinding을 JamesIcon 영역으로 개별적으로 이동시킬 수 있습니다. 이 접근법은 각 구성 요소(JamesIcon)가 자체 정의와 스타일을 가질 수 있게 하여, 코드를 더 모듈화하고 유지 관리하기 쉽고 재사용 가능하게 만듭니다. 바인딩과 스타일을 각각의 영역으로 분리함으로써 전체 코드 구조를 명확하게 하여 이해하고 수정하기 쉽게 만듭니다. 또한, 이러한 분리는 더 큰 유연성을 제공하여, 다른 구성 요소에 영향을 주지 않고 개별 구성 요소의 스타일과 행동을 조정할 수 있습니다.



## 2. Microsoft Blend: Geometry 디자인
<img width="511" alt="스크린샷 2024-01-02 오후 11 32 08" src="https://github.com/vickyqu115/navigationbar/assets/101777355/be831284-153d-46dc-889f-46068a98a692">

Microsoft Blend는 과거 Expression Blend의 후속 버전입니다. 특정 기능들은 축소되었지만, 계속해서 명목을 이어오고 있습니다. 이 프로그램은 Visual Studio 설치 과정을 통해 추가할 수 있습니다. 만약 이 프로그램을 찾을 수 없는 경우 Visual Studio Installer 프로그램을 통해 항목을 추가하는 것이 가능합니다.

Microsoft Blend는 Visual Studio와 거의 대부분의 기능이 유사하지만 디자인에 특화된 몇 몇의 기능들을 추가로 포함하고 있습니다. 그 중에서도 Geometry 관련 기능들을 제공하고 있는데 이는 Adobe 사의 Illustrator 프로그램과도 부분적으로 유사함을 지니고 있는 것이 특징입니다.

WPF 개발 과정에서 Microsoft Blend 활용이 꼭 필수적인 요소는 아닙니다. 또한 개발자가 아닌 디자이너의 전유물도 아닙니다. 이 프로그램은 오히려 개발자들이 광범위한 디자인 학습 없이도 전문적이고 매력적인 디자인 요소를 생성 가능한 도구로써 활용 가치가 있습니다.

> 다만 Microsoft Blend 프로그램을 통해 제공하는 디자인 기능을 Figma, Illustrator 환경에서 대부분 더 강력하게 사용할 수 있기 때문에 굳이 이를 배우고자 할 필요는 없습니다. 하지만 Geometry와 관련된 몇 몇 기능들은 별도의 학습 없이도 손쉽게 사용할 수 있으므로 유심히 살펴보시기를 바랍니다.

#### 서클(🔵) 디자인 분석 

MagicBar 컨트롤의 Circle은 메뉴가 변경될 때 시각적으로 동작하는 이 프로젝트의 중요한 포인트입니다. 부드러운 Animation 구현을 통해 현대적이고 트렌디한 디자인 요소를  포함하고 있습니다.

Circle 요소를 반드시 Geometry 기반으로 구현할 필요는 없습니다. 이미지를 사용할 경우 좀 더 손쉽게 구현하는 것이 가능합니다. 하지만 Quality 적인 측면에서 보면 사이즈 변화에 따른 해상도 변화에 영향 받지 않고 섬세한 부분을 더욱 디테일하게 구현하는 것이 가능하기 때문에 Geometry 디자인 요소의 수요가 점점 늘어나고 있는 것입니다.

> 아래의 이미지처럼 사이즈를 변경하거나 아무리 키우고 줄여도 선명한 결과를 얻을 수 있는 것이 특징입니다.

<img width="1156" alt="스크린샷 2023-12-20 오후 8 43 15" src="https://github.com/vickyqu115/navigationbar/assets/101777355/0526a9ef-8d77-4d8c-b62c-91deebb7ea8d" style="zoom:60%;" ></img>

Circle 디자인을 유심히 살펴보면 검정색 원과 녹색 원을 겹쳐서 시각적인 공간감을 표현하고 있습니다. 또한 MagicBar 영역으로 자연스럽게 연출 되도록 양 쪽 라인을 곡선으로 Round 처리를 한 것을 볼 수 있습니다. 이것은 시각적으로도 부드럽게 보이며 Animation 동작을 통해 더욱 우아하게 보일 수 있습니다. 하지만 이(Arc)를 구현하는 것은 생각보다 쉽지 않는 작업이기 때문에 실전 도입 과정에서 폐기되는 경우를 종종 볼 수 있습니다.  

그러나 이때 Microsoft Blend가 이 특별한 모양을 쉽게 그리는 데 유용합니다.

#### 그리기 방법:

디자인 과정은 아래쪽에 볼록한 아크가 있는 큰 원을 그린 다음, 큰 원의 양쪽에 같은 높이에 작은 원을 추가하는 것을 포함합니다. 큰 원의 지름을 조정함으로써 큰 원과 작은 원이 완벽하게 교차하게 합니다.

<img width="1838" alt="스크린샷 2024-01-02 오후 6 26 25" src="https://github.com/vickyqu115/navigationbar/assets/101777355/c59a7f7c-b6eb-4b13-95ff-a700eee8ebcf"></img>

다음으로, 병합 기능을 사용하여 먼저 큰 원의 필요 없는 부분을 잘라내고, 빼기 기능을 사용하여 작은 원의 원하지 않는 부분을 제거하여, 교차점에서 아크 모양만 남깁니다. 마지막으로 사각형을 추가하고 필요 없는 부분을 제거하여 독특하고 자연스러운 아크 모양을 만듭니다.

![IMG_8875](https://github.com/vickyqu115/navigationbar/assets/101777355/b6e81e05-2215-45a8-883e-1efa5aac8513)

이러한 디자인 요소를 구현하는 방법은 복잡한 그래픽을 처리할 때 Microsoft Blend의 사용 방법 뿐만이 아니라, 디자인 문제를 생각하고 해결하는데 있어서 새로운 관점을 제공합니다. 이 접근 방식을 통해 서클은 미적으로 매력적일 뿐만 아니라 기술적으로도 혁신적인 품질 향상을 이루게 됩니다.



## 3. Animation: ListBoxItem

아이콘과 텍스트를 구성하는 ListBoxItem 영역의 Animation 동작은 비교적 간단합니다. IsSelected=true 시점에 구성 요소들을 상단으로 이동함과 동시에 Opacity 투명도를 조정하는 것이 특징입니다. 

> 아래 이미지를 통해 Animation 동작 경로와 효과를 잘 살펴보시기 바랍니다.

<img src="https://github.com/vickyqu115/navigationbar/assets/101777355/2fe0d794-6c3b-432c-ae5e-aad8038311dc" alt="20240103002407247"/>

위의 이미지 처럼 ListBox 컨트롤의 IsSelected 값이 변경될 때마다 Animation이 동작하는 것을 확인할 수 있습니다. 또한 아이콘과 텍스트의 동작 범위가 ListBoxItem 영역을 벗어나지 않기 때문에 XAML 안에서 직접 정적인 Storyboard 요소를 구현하여 사용하는 것이 좋습니다. 

>  이 때 동작에 대한 제어는 Trigger 또는 VisualStateManager 모듈을 통해 사용하는 것이 가능하며, 이 컨트롤에서는 단순 IsSelected 처리에 대한 동작만을 처리할 것이므로 간단하게 사용하기에 편한 Trigger 모듈 방식을 사용합니다.

#### Storyboard

ListBoxItem 영역에서의 Animation 동작 방식은 IsSelected 값이 true일 때와 false일 때 두 가지 경우의 수에 대한 시나리오를 준비해야 합니다. 

```xaml
<Storyboard x:Key="Selected">
	<james:ThickItem Mode="CubicEaseInOut" TargetName="icon" Duration="0:0:0.5" Property="Margin" To="0 -80 0 0"/>
	<james:ThickItem Mode="CubicEaseInOut" TargetName="name" Duration="0:0:0.5" Property="Margin" To="0 45 0 0"/>
	<james:ColorItem Mode="CubicEaseInOut" TargetName="icon" Duration="0:0:0.5" Property="Fill.Color" To="#333333"/>
	<james:ColorItem Mode="CubicEaseInOut" TargetName="name" Duration="0:0:0.5" Property="Foreground.Color" To="#333333"/>
</Storyboard>

<Storyboard x:Key="UnSelected">
	<james:ThickItem Mode="CubicEaseInOut" TargetName="icon" Duration="0:0:0.5" Property="Margin" To="0 0 0 0"/>
	<james:ThickItem Mode="CubicEaseInOut" TargetName="name" Duration="0:0:0.5" Property="Margin" To="0 60 0 0"/>
	<james:ColorItem Mode="CubicEaseInOut" TargetName="icon" Duration="0:0:0.5" Property="Fill.Color" To="#44333333"/>
	<james:ColorItem Mode="CubicEaseInOut" TargetName="name" Duration="0:0:0.5" Property="Foreground.Color" To="#00000000"/>
</Storyboard>
```

> Selected에서는 이동 경로를, UnSelected에서는 되돌아오는 경로를 지정하는 것이 포인트입니다.

#### Trigger

최종적으로 (Selected/UnSelected) Storyboard를 각각 동작 시키기 위한 BeginStoryboard를 Trigger 방식을 통해 선언하는 것으로 ListBoxItem 영역에서의 Animation 구현을 마무리합니다.

> 일반적인 Trigger 속성 변경과는 다르게 애니메이션은 복귀 시나리오가 함께 존재해야 합니다.

```xaml
<ControlTemplate.Triggers>
    <Trigger Property="IsSelected" Value="True">
        <Trigger.EnterActions>
            <BeginStoryboard Storyboard="{StaticResource Selected}"/>
        </Trigger.EnterActions>
        <Trigger.ExitActions>
            <BeginStoryboard Storyboard="{StaticResource UnSelected}"/>
        </Trigger.ExitActions>
    </Trigger>
</ControlTemplate.Triggers>
```
ListBoxItem 영역에서의 Animation을 구성하는 방법은 비교적 간단하게 구현됩니다. 하지만 다음으로 소개하는 Circle 원형 요소의 움직임을 구현하는 Animation에서는 동적인 계산이 필요하기 때문에 좀 더 복잡한 구현이 필요합니다.



### 4. Circle (원형) 구성 요소의 움직임

이번에는 Circle 원형 구성요소의 움직임을 Animation으로 구현할 차례입니다. 아래는 동적인 Circle 위치 이동을 보여주는 영상입니다.

![20240103001946785](https://github.com/vickyqu115/navigationbar/assets/101777355/d9264b98-f7fb-434b-b78c-1671ac8b531a)


Circle (원형) 구성 요소의 움직임은 클릭된 위치에 따라 정확하게 계산되어야 하므로 XAML에서 구현할 수 없으며 C# 코드에서 동적인 움직임을 처리해야 합니다. 따라서 XAML과 Code Behind 간의 연결을 위한 방법이 필요합니다.

#### OnApplyTemplate

이 메서드는 MagicBar 컨트롤 내부에 있는 Circle 영역을 가져오기 위한 메서드입니다. 이 메서드는 컨트롤과 Template 간의 연결 시점에 내부에서 호출이 됩니다. 따라서 MagicBar 클래스에서 미리 override를 통해 기능을 구현합니다.

그런 다음 GetTemplateChild 메소드를 사용하여 "PART_Circle"이라는 이름의 약속된 Circle 요소를 검색합니다. 이 Grid는 상호작용 중에 Animation 효과를 표시하는 대상 요소가 됩니다.

```csharp
public override void OnApplyTemplate()
{
    base.OnApplyTemplate();
    Grid grid = (Grid)GetTemplateChild("PART_Circle");

    InitStoryboard(grid);
}
```

#### InitStoryboard

이 메서드는 애니메이션을 초기화하는 역할을 합니다. ValueItem (_vi) 및 Storyboard (_sb)의 인스턴스를 먼저 생성합니다. ValueItem에 설정된 Animation 효과는 QuinticEaseInOut으로, 애니메이션의 시작과 끝에서 느려지고 중간에 가속되어 애니메이션을 부드럽고 자연스럽게 보이게 합니다. 

그리고 Circle의 이동 경로를 위해 Canvas.LeftProperty을 타겟 속성으로 지정합니다. 이는 대상 요소의 수평 위치를 변경한다는 것을 의미합니다. 애니메이션의 지속 시간은 0.5초로 설정됩니다. 마지막으로, 애니메이션 대상은 Circle 원형 (Grid) 요소로 설정되며, 정의된 애니메이션은 최종적으로 스토리보드에 추가됩니다.

```csharp
private void InitStoryboard(Grid circle)
{
    _vi = new();
    _sb = new();

    _vi.Mode = EasingFunctionBaseMode.QuinticEaseInOut;
    _vi.Property = new PropertyPath(Canvas.LeftProperty);
    _vi.Duration = new Duration(new TimeSpan(0, 0, 0, 0, 500));

    Storyboard.SetTarget(_vi, circle);
    Storyboard.SetTargetProperty(_vi, _vi.Property);

    _sb.Children.Add(_vi);
}
```
#### OnSelectionChanged

이제 Circle 원형을 움직이기 위한 시나리오를 구현해야 합니다. 따라서 "PART_Circle" (Grid) 요소를 핸들링 하기 위해 MagicBar 클래스에서 OnSelectionChanged 이벤트 메서드를 구현하고 스토리보드를 동작(Begin)하기 위한 코드를 구현할 차례입니다.

>  MagicBar 컨트롤은 CustomControl 형태로써 ListBox로부터 파생된 override 기능을 유연하게 구현할 수 있는 구조를 지니고 있는 것이 장점입니다.

```csharp
protected override void OnSelectionChanged(SelectionChangedEventArgs e)
{
    base.OnSelectionChanged(e);

    _vi.To = SelectedIndex * 80;
    _sb.Begin();
}
```

이 메서드에서는 선택된 메뉴가 변경될 떄마다 SelectedIndex 값을 통해 위치를 동적으로 계산하여 To 값을 변경하는 로직을 구현합니다.

### 5. 마무리: CustomControl 전체 소스코드 확인
마지막으로, MagicBar 컨트롤의 XAML/Csharp 코드의 전체 구성을 살펴볼 차례입니다. 이 컨트롤이 CustomControl 구조하에 얼마나 간결하고 우아하게 구현되어 있는지 한눈에 볼 시간입니다.

#### Generic.xaml
> 다양한 기능이 구현되었지만, XAML 구조를 최대한 간결화시킨 모습을 살펴볼 수 있습니다. 특히 MagicBar에 포함된 ControlTemplate 구조는 복잡한 레이어 계층을 단순화 하여 한 눈에 볼 수 있도록 구성한 것이 특징입니다. 그 외에도 Storyboard, Geometry, TextBlock, JamesIcon과 같은 작은 요소들 까지도 규칙적으로 정리된 모습입니다. 

```xaml
<ResourceDictionary
    xmlns="http://schemas.microsoft.com/winfx/2006/xaml/presentation"
    xmlns:x="http://schemas.microsoft.com/winfx/2006/xaml"
    xmlns:james="https://jamesnet.dev/xaml/presentation"
    xmlns:local="clr-namespace:NavigationBar">

    <Storyboard x:Key="Selected">
        <james:ThickItem Mode="CubicEaseInOut" TargetName="icon" Duration="0:0:0.5" Property="Margin" To="0 -80 0 0"/>
        <james:ThickItem Mode="CubicEaseInOut" TargetName="name" Duration="0:0:0.5" Property="Margin" To="0 45 0 0"/>
        <james:ColorItem Mode="CubicEaseInOut" TargetName="icon" Duration="0:0:0.5" Property="Fill.Color" To="#333333"/>
        <james:ColorItem Mode="CubicEaseInOut" TargetName="name" Duration="0:0:0.5" Property="Foreground.Color" To="#333333"/>
    </Storyboard>

    <Storyboard x:Key="UnSelected">
        <james:ThickItem Mode="CubicEaseInOut" TargetName="icon" Duration="0:0:0.5" Property="Margin" To="0 0 0 0"/>
        <james:ThickItem Mode="CubicEaseInOut" TargetName="name" Duration="0:0:0.5" Property="Margin" To="0 60 0 0"/>
        <james:ColorItem Mode="CubicEaseInOut" TargetName="icon" Duration="0:0:0.5" Property="Fill.Color" To="#44333333"/>
        <james:ColorItem Mode="CubicEaseInOut" TargetName="name" Duration="0:0:0.5" Property="Foreground.Color" To="#00000000"/>
    </Storyboard>
    
    <Style TargetType="{x:Type james:JamesIcon}" x:Key="Icon">
        <Setter Property="Icon" Value="{Binding RelativeSource={RelativeSource AncestorType=ListBoxItem},Path=Tag}"/>
        <Setter Property="Width" Value="40"/>
        <Setter Property="Height" Value="40"/>
        <Setter Property="Fill" Value="#44333333"/>
    </Style>

    <Style TargetType="{x:Type TextBlock}" x:Key="Name">
        <Setter Property="Text" Value="{Binding RelativeSource={RelativeSource AncestorType=ListBoxItem},Path=Content}"/>
        <Setter Property="HorizontalAlignment" Value="Center"/>
        <Setter Property="FontWeight" Value="Bold"/>
        <Setter Property="FontSize" Value="14"/>
        <Setter Property="Foreground" Value="#00000000"/>
        <Setter Property="Margin" Value="0 60 0 0"/>
    </Style>
    
    <Style TargetType="{x:Type ListBoxItem}" x:Key="MagicBarItem">
        <Setter Property="FocusVisualStyle" Value="{x:Null}"/>
        <Setter Property="Background" Value="Transparent"/>
        <Setter Property="Template">
            <Setter.Value>
                <ControlTemplate TargetType="{x:Type ListBoxItem}">
                    <Grid Background="{TemplateBinding Background}">
                        <james:JamesIcon x:Name="icon" Style="{StaticResource Icon}"/>
                        <TextBlock x:Name="name" Style="{StaticResource Name}"/>
                    </Grid>
                    <ControlTemplate.Triggers>
                        <Trigger Property="IsSelected" Value="True">
                            <Trigger.EnterActions>
                                <BeginStoryboard Storyboard="{StaticResource Selected}"/>
                            </Trigger.EnterActions>
                            <Trigger.ExitActions>
                                <BeginStoryboard Storyboard="{StaticResource UnSelected}"/>
                            </Trigger.ExitActions>
                        </Trigger>
                    </ControlTemplate.Triggers>
                </ControlTemplate>
            </Setter.Value>
        </Setter>
    </Style>
    
    <Geometry x:Key="ArcData">
        M0,0 L100,0 C95.167503,0 91.135628,3.4278221 90.203163,7.9846497 L90.152122,8.2704506 89.963921,9.1416779 C85.813438,27.384438 69.496498,41 50,41 30.5035,41 14.186564,27.384438 10.036079,9.1416779 L9.8478823,8.2704926 9.7968359,7.9846497 C8.8643732,3.4278221 4.8324914,0 0,0 z
    </Geometry>

    <Style TargetType="{x:Type Path}" x:Key="Arc">
        <Setter Property="Data" Value="{StaticResource ArcData}"/>
        <Setter Property="Width" Value="100"/>
        <Setter Property="Height" Value="100"/>
        <Setter Property="Fill" Value="#222222"/>
        <Setter Property="Margin" Value="-10 40 -10 -1"/>
    </Style>
    
    <Style TargetType="{x:Type Border}" x:Key="Bar">
        <Setter Property="Background" Value="#DDDDDD"/>
        <Setter Property="Margin" Value="0 40 0 0"/>
        <Setter Property="CornerRadius" Value="10"/>
    </Style>

    <Style TargetType="{x:Type Grid}" x:Key="Circle">
        <Setter Property="Width" Value="80"/>
        <Setter Property="Height" Value="80"/>
        <Setter Property="Canvas.Left" Value="-100"/>
    </Style>
    
    <Style TargetType="{x:Type local:MagicBar}">
        <Setter Property="ItemContainerStyle" Value="{StaticResource MagicBarItem}"/>
        <Setter Property="SnapsToDevicePixels" Value="True"/>
        <Setter Property="UseLayoutRounding" Value="True"/>
        <Setter Property="Background" Value="Transparent"/>
        <Setter Property="Width" Value="440"/>
        <Setter Property="Height" Value="120"/>
        <Setter Property="Template">
            <Setter.Value>
                <ControlTemplate TargetType="{x:Type local:MagicBar}">
                    <Grid Background="{TemplateBinding Background}">
                        <Grid.Clip>
                            <RectangleGeometry Rect="0 0 440 120"/>
                        </Grid.Clip>
                        <Border Style="{StaticResource Bar}"/>
                        <Canvas Margin="20 0 20 0">
                            <Grid x:Name="PART_Circle" Style="{StaticResource Circle}">
                                <Path Style="{StaticResource Arc}"/>
                                <Ellipse Fill="#222222"/>
                                <Ellipse Fill="CadetBlue" Margin="6"/>
                            </Grid>
                        </Canvas>
                        <ItemsPresenter Margin="20 40 20 0"/>
                    </Grid>
                </ControlTemplate>
            </Setter.Value>
        </Setter>
        <Setter Property="ItemsPanel">
            <Setter.Value>
                <ItemsPanelTemplate>
                    <UniformGrid Columns="5"/>
                </ItemsPanelTemplate>
            </Setter.Value>
        </Setter>
    </Style>
</ResourceDictionary>
```

#### MagicBar.cs
> OnApplyTemplate을 통해 단절되어 있는 Controltemplate 요소를 찾아내는 과정은 WPF의 상징과도 같은 매우 중요하고 근본적인 작업입니다. 약속된 PART_Circle 객체(Grid)를 찾아와서, 메뉴가 변경될 때마다 Circle의 이동(Move) 애니메이션을 동적으로 구성하여 동작시키는 행위는 WPF의 생명력을 매우 활동적으로 보일 수 있도록 하게 됩니다.

```csharp
﻿using Jamesnet.Wpf.Animation;
using Jamesnet.Wpf.Controls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
namespace NavigationBar
{

    public class MagicBar : ListBox
    {
        private ValueItem _vi;
        private Storyboard _sb;

        static MagicBar()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(MagicBar), new FrameworkPropertyMetadata(typeof(MagicBar)));
        }

        public override void OnApplyTemplate()
        {
            base.OnApplyTemplate();
            Grid grid = (Grid)GetTemplateChild("PART_Circle");

            InitStoryboard(grid);
        }

        private void InitStoryboard(Grid circle)
        {
            _vi = new();
            _sb = new();

            _vi.Mode = EasingFunctionBaseMode.QuinticEaseInOut;
            _vi.Property = new PropertyPath(Canvas.LeftProperty);
            _vi.Duration = new Duration(new TimeSpan(0, 0, 0, 0, 500));

            Storyboard.SetTarget(_vi, circle);
            Storyboard.SetTargetProperty(_vi, _vi.Property);

            _sb.Children.Add(_vi);
        }

        protected override void OnSelectionChanged(SelectionChangedEventArgs e)
        {
            base.OnSelectionChanged(e);

            _vi.To = SelectedIndex * 80;
            _sb.Begin();
        }
    }
}
```

이처럼, 평소에는 UserControl을 통해 구현할 만한 규모의 기능을 컨트롤 단위의 CustomControl 방식으로 구현한다면 더욱 세련되고 효율적인 모듈화를 이뤄낼 수 있습니다.

이로써 주요 기능들에 대한 설명을 마칩니다.  이 컨트롤의 자세한 내용은 GitHub 소스코드를 통해서도 무료로 다운로드할 수 있으며, [유튜브](https://youtube.com/@jamesnet214) 또는 [빌리빌리](https://bil)를 통해 각각 영어/중국어로 상세하게 제공되고 있으니 XAML 기반의 플랫폼에서 다양하게 연구되고 활용되기를 기대합니다.

