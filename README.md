#  MagicNavigationBar

<br/>

<img width="511" alt="스크린샷 2024-01-02 오후 11 32 08" src="https://github.com/vickyqu115/navigationbar/assets/101777355/93dc0aaf-d4ce-4d4e-abb2-8a1529019b07">

### Introduction: Project Background and Overview
As a developer deeply passionate about WPF technology, I firmly believe in its potential far beyond what we usually perceive. WPF is not just a powerful UI framework; its diversity and superior performance offer developers a vast space for creativity. My goal is to gradually unveil these aspects of WPF through various projects, providing technical support and inspiration to those interested in or currently working with WPF technology.

### The Design Philosophy of Magic Navigation Bar:
The essence of this project is to create a simplistic yet vibrant Magic Navigation Bar. In the contemporary world of programming, similar navigation bars are typically implemented using HTML, CSS, and JavaScript. The advantage of these technologies lies in their widespread application and flexibility. HTML provides the structure, CSS handles the styling and layout, and JavaScript manages interaction and animation. Together, they create visually appealing and functionally robust web applications.

However, constructing such a project with WPF technology is often perceived as complex and challenging, especially in terms of project structure and animation presentation. This is where the challenge lies: with a deep understanding of the flexibility and powerful capabilities of WPF, not only can this process be simplified, but it can also be elegantly implemented through code.

## Project Overview
### The Power of WPF:
In this project, we leverage the formidable capabilities of WPF, particularly the rich combination of XAML and C# backend code, to construct a visually appealing and fully functional Magic Navigation Bar. WPF allows us to design UIs using a declarative language (XAML), while utilizing the strong typing and object-oriented features of C# to handle logic and behavior. This combination provides immense flexibility for creating complex and dynamic UIs.

### Structure and Implementation:
The project structure is divided into two parts: the frontend UI and the backend logic. In the UI segment, we utilize XAML to define the layout, style, and animations of the controls. This includes defining the appearance of controls, implementing animation effects, and responding to user interactions. In the C# backend code, we handle user interaction events, control the playback of animations, and manage the state changes of controls. This structure not only ensures clarity and maintainability of the code but also separates UI from logic, enhancing the reusability and scalability of the code.

Through this project, we can showcase the powerful capabilities of WPF in creating modern, dynamic, and responsive user interfaces. It also demonstrates that WPF can provide elegant and efficient solutions for projects traditionally considered within the realm of frontend development.

## XAML Code Explanation
### 1. Geometry and Layout
The core of the XAML code in the Magic Navigation Bar is centered around the customization of the ListBoxItem and the clever combination of various elements to create a navigation bar that is both aesthetically pleasing and fully functional.

- #### ListBoxItem Structure:

  - The ListBoxItem serves as the basic building block of the MagicBar. Each ListBoxItem includes an Icon (using JamesIcon) and text (using TextBlock). This structure provides each navigation item with an icon and a corresponding text label, offering an intuitive navigation experience for users.




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
    
- #### Use and Customization of Icons:

  - With the jamesnet.wpf library, it becomes easy to add and use a variety of icon materials. This greatly simplifies the process of using icons and allows for the customization of the icons' size and color through custom controls. Such flexibility ensures that each item in the MagicBar is unique yet maintains consistency.

    ```xaml
    <Style TargetType="{x:Type james:JamesIcon}" x:Key="Icon">
        <Setter Property="Icon" Value="{Binding ...}"/>
        <Setter Property="Width" Value="40"/>
        <Setter Property="Height" Value="40"/>
        <Setter Property="Fill" Value="#44333333"/>
    </Style>
    ```

- #### Application of RelativeSource Binding:

  - By employing RelativeSource Binding, we can move the TemplateBinding of Icons and Texts, initially defined within the ListBoxItem area, to the JamesIcon and TextBlock areas for individual management.
This approach allows each component (Icon and Text) to have its own definition and style, making the code more modular, easier to maintain, and reusable. Separating bindings and styles into their respective areas clarifies the overall code structure, making it easier to understand and modify. Furthermore, this separation also provides greater flexibility, as it allows for the individual styling and behavior adjustment of different components without affecting others.

    ```xaml
    Value="{Binding RelativeSource={RelativeSource AncestorType=ListBoxItem}, Path=Tag}"
    ```

### 2. Microsoft Blend: Accelerating WPF and XAML Development

In the process of project development, if developers can master certain design skills, it will greatly enhance the aesthetics of the project interface. However, not all developers have the time or interest to learn new technologies. In such cases, choosing tools that are easy to use and developer-friendly for simple graphic design and creation becomes particularly important.

Microsoft Blend is exactly such a tool. It is designed specifically for WPF and other applications based on XAML, providing a full suite of professional UI design tools. This enables developers and designers to efficiently create complex and appealing user interfaces.

<img width="511" alt="스크린샷 2024-01-02 오후 11 32 08" src="https://github.com/vickyqu115/navigationbar/assets/101777355/be831284-153d-46dc-889f-46068a98a692">

<br/>

#### For WPF developers and programmers using XAML, the main advantages of Blend include:

- #### Intuitive Visual Design Tools:
  - Blend offers a WYSIWYG interface, enabling developers to intuitively create and edit user interfaces. This is particularly useful for designing complex layouts and animations.

- #### Support for UI Component and Style Editing:
  - Blend supports the creation and editing of advanced UI elements, including custom controls, styles, and templates. Its powerful styling and resource management capabilities help maintain clean and organized code.

- #### Path Tools and Shape Editing:
  - Blend's path tools and shape editing capabilities simplify the creation of complex graphics.

- #### Integrated Code Editing and Visual Studio Integration:
  - Blend focuses not only on visual design but also provides a code editor, allowing direct editing and debugging of code within the application. Its seamless integration with Visual Studio offers developers a complete development and design environment.

- #### Animation and Visual State Management:
  - With Blend, developers can easily design complex animations and visual states. Its intuitive timeline and animation tools simplify the process of creating and adjusting animations.

- #### Rapid Prototyping and Iteration:
  - Blend enables rapid prototyping, allowing designers and developers to quickly create and test UI concepts and iterate based on feedback.

- #### Cross-Platform Support:
  - Besides WPF, Blend also supports other XAML-based platforms such as UWP and Silverlight, facilitating cross-platform development.

<br/>

In conclusion, Blend is a powerful and accessible tool that enables developers to create professional and attractive user interfaces without extensive design learning, thereby enhancing the overall quality and user experience of the project.


<br/>

### 3. 🔵Visual Design Analysis of the Circle Section

In the Magic Navigation Bar project, the Circle section is a visual highlight, enhancing the appeal of the entire navigation bar through clever design and technical implementation.

<img width="1156" alt="스크린샷 2023-12-20 오후 8 43 15" src="https://github.com/vickyqu115/navigationbar/assets/101777355/0526a9ef-8d77-4d8c-b62c-91deebb7ea8d"></img>

We created a sense of space and hierarchy visually by adding two circles with different positions and colors. Additionally, to make the transition from the Circle section to the MagicBar area more natural, we designed a smoothly transitioning multi-arc shape. In WPF, there are several ways to implement such a shape, including using pre-drawn images or drawing directly in the project using the Path property. Given the uniqueness and computational complexity of the shape, we sought a simpler and more convenient method.

This is where Microsoft Blend comes in handy for easily drawing this special shape.

- #### Drawing Method:

  The design process involves drawing a large circle with a downward bulging arc at the bottom, then adding a smaller circle at the same height on both sides of the large circle. By adjusting the diameter of the large circle, the large and small circles intersect perfectly.

<img width="1838" alt="스크린샷 2024-01-02 오후 6 26 25" src="https://github.com/vickyqu115/navigationbar/assets/101777355/c59a7f7c-b6eb-4b13-95ff-a700eee8ebcf"></img>

Next, using the merge function, we first cut out the unnecessary parts of the large circle, then use the subtract function to remove the unwanted parts of the small circles, leaving only the arc shapes at the junction.
Finally, by adding a rectangle and removing the unnecessary parts, we can create a unique and natural arc shape.

This innovative design method not only demonstrates the powerful capabilities of WPF and Blend in handling complex graphics but also offers a new perspective in thinking about and solving design challenges. With this approach, the design of the Circle section is not only aesthetically pleasing but also innovative and flexible in technical implementation, adding a unique charm to the entire Magic Navigation Bar.

![IMG_8875](https://github.com/vickyqu115/navigationbar/assets/101777355/b6e81e05-2215-45a8-883e-1efa5aac8513)


This innovative design method not only showcases the powerful capabilities of WPF and Blend in handling complex graphics but also offers a new perspective in thinking about and solving design challenges. Through this approach, the Circle component's design is not only aesthetically pleasing but also innovative and flexible in its technical execution, adding unique charm to the entire Magic Navigation Bar.

## 3.Animation Creation
### ✨ ListBoxItem Area Icon and Text Movement Animation:

<br/>

![20240103002407247](https://github.com/vickyqu115/navigationbar/assets/101777355/2fe0d794-6c3b-432c-ae5e-aad8038311dc)

  - We can implement the animation of the icon and text moving up and down in the ListBoxItem area by adding an IsSelected property trigger in XAML. This allows us to define the behavior when a ListBoxItem is selected or deselected.

#### Storyboard Concept:

A Storyboard in WPF is a container used to define a series of animations. It can contain multiple animation elements that play sequentially or simultaneously on a timeline, creating complex animation sequences.
Here, by adding Selected and UnSelected Storyboards, we display the animation effect of the icon and text moving positions while simultaneously changing colors.

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
#### ⚙️ Animation Properties:

- #### Mode: 
  - CubicEaseInOut is an easing function used to control the acceleration and deceleration of the animation, making it appear more natural.
- #### TargetName: 
  - Specifies the name of the element to which the animation is applied.
- #### Duration:
  - The total duration of the animation.
- #### Property:
  - Defines the property to be animated, such as Margin or Fill.Color.

    ```xaml
    <Storyboard x:Key="Selected">
        <james:ThickItem Mode="CubicEaseInOut" TargetName="icon"
                         Duration="0:0:0.5" Property="Margin" To="0 -80 0 0"/>
        <james:ThickItem Mode="CubicEaseInOut" TargetName="name"
                         Duration="0:0:0.5" Property="Margin" To="0 45 0 0"/>
        <james:ColorItem Mode="CubicEaseInOut" TargetName="icon"
                         Duration="0:0:0.5" Property="Fill.Color" To="#333333"/>
        <james:ColorItem Mode="CubicEaseInOut" TargetName="name"
                         Duration="0:0:0.5" Property="Foreground.Color" To="#333333"/>
    </Storyboard>
    
    <Storyboard x:Key="UnSelected">
        <james:ThickItem Mode="CubicEaseInOut" TargetName="icon"
                         Duration="0:0:0.5" Property="Margin" To="0 0 0 0"/>
        <james:ThickItem Mode="CubicEaseInOut" TargetName="name"
                         Duration="0:0:0.5" Property="Margin" To="0 60 0 0"/>
        <james:ColorItem Mode="CubicEaseInOut" TargetName="icon"
                         Duration="0:0:0.5" Property="Fill.Color" To="#44333333"/>
        <james:ColorItem Mode="CubicEaseInOut" TargetName="name"
                         Duration="0:0:0.5" Property="Foreground.Color" To="#00000000"/>
    </Storyboard>
    ```
    
<br/>

### ✨ Circle Component Movement:

<br/>

![20240103001946785](https://github.com/vickyqu115/navigationbar/assets/101777355/d9264b98-f7fb-434b-b78c-1671ac8b531a)


The movement of the circle component needs to be precisely calculated based on the clicked position, and therefore cannot be implemented in XAML but needs to be done in C# code.

- #### OnApplyTemplate Method:

  This is an important method in the lifecycle of the MagicBar control. It is called when the control’s template is applied.
Inside the method, we first call the base class’s OnApplyTemplate method to ensure all standard initialization steps are executed.
Then, using the GetTemplateChild method, we retrieve the Grid element named "PART_Circle". This Grid is likely the target element for the animation, displaying the animation effect during user interaction.

  ```csharp
  public override void OnApplyTemplate()
  {
      base.OnApplyTemplate();
      Grid grid = (Grid)GetTemplateChild("PART_Circle");
  
      InitStoryboard(grid);
  }
  ```

- #### InitStoryboard Method:

  This method is responsible for initializing the animation. It first creates instances of ValueItem (_vi) and Storyboard (_sb).
The easing function set for ValueItem is QuinticEaseInOut, which slows down at the start and end of the animation and accelerates in the middle, making the animation appear smooth and natural.
The animation affects the property Canvas.LeftProperty, indicating that the animation will change the horizontal position of the target element.
The duration of the animation is set to 0.5 seconds. Finally, the animation target is set to the passed circle (Grid) element, and the animation is added to the storyboard.

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

- #### OnSelectionChanged Method:
  
  This overridden method is triggered when the selected item in MagicBar changes.
The method first calls the base class’s OnSelectionChanged method to ensure standard behavior is executed.
Then, it sets the _vi’s To property based on the index of the selected item, determining the value of Canvas.LeftProperty at the end of the animation. The animation moves the element to a position proportional to the SelectedIndex.
Lastly, by calling _sb.Begin(), the storyboard is started, and the animation is played.

  ```csharp
  protected override void OnSelectionChanged(SelectionChangedEventArgs e)
  {
      base.OnSelectionChanged(e);
  
      _vi.To = SelectedIndex * 80;
      _sb.Begin();
  }
  ```
