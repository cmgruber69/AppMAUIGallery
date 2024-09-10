using AppMAUIGallery.Models;
using AppMAUIGallery.Views.Animations;
using AppMAUIGallery.Views.Components;
using AppMAUIGallery.Views.Components.Cells;
using AppMAUIGallery.Views.Components.Forms;
using AppMAUIGallery.Views.Components.Lists;
using AppMAUIGallery.Views.Components.Mains;
using AppMAUIGallery.Views.Components.Shells;
using AppMAUIGallery.Views.Components.Visuals;
using AppMAUIGallery.Views.Layouts;
using AppMAUIGallery.Views.Styles;


namespace AppMAUIGallery.Repositories
{
    public partial class GroupComponentRepository : IGroupComponentRepository
    {
        private void LoadData()
        {
            _components = new List<Component>();
            _groupComponents = new List<GroupComponent>();

            LoadLayouts();
            LoadControls();
            LoadVisuals();
            LoadForms();
            LoadCells();
            LoadCollections();
            LoadStyles();
            LoadAnimations();
            //LoadUtils();
            //LoadCommunityMaui();
            LoadShell();
            //LoadAccessability();
        }

        private void LoadShell()
        {
            var components = new List<Component> {
                new Component {
                    Title = "Shell",
                    Description = "A new way to structure our navigation project pages",
                    Page = typeof(AppShell),
                    IsReplaceMainPage = true
                },
            };

            var group = new GroupComponent() { Name = "Shell" };
            group.AddRange(components);

            _components.AddRange(components);
            _groupComponents.Add(group);
        }
        //private void LoadAccessability()
        //{
        //    var components = new List<Component> {
        //        new Component {
        //            Title = "Semantic",
        //            Description = "Elemento que torna nosso aplicativo visível para quem tem necessidades especiais.",
        //            Page = typeof(AccessabilityPage),
        //        },
        //    };

        //    var group = new GroupComponent() { Name = "Accessability" };
        //    group.AddRange(components);

        //    _components.AddRange(components);
        //    _groupComponents.Add(group);
        //}
        private void LoadLayouts()
        {
            var components = new List<Component> {
                new Component {
                    Title = "StackLayout",
                    Description = "Sequential organization of elements.",
                    Page = typeof(StackLayoutPage)
                },
                new Component
                {
                    Title = "Grid",
                    Description = "Organizes elements within a table.",
                    Page = typeof(GridLayoutPage)
                },
                new Component
                {
                    Title = "AbsoluteLayout",
                    Description = "Complete freedom to position and size elements on the screen.",
                    Page = typeof(AbsoluteLayoutPage)
                },
                new Component
                {
                    Title = "FlexLayout",
                    Description = "Organizes elements sequentially with many customization options.",
                    Page = typeof(FlexLayoutPage)
                }
            };

            var group = new GroupComponent() { Name = "Layout" };
            group.AddRange(components);

            _components.AddRange(components);
            _groupComponents.Add(group);
        }

        private void LoadControls()
        {
            var components = new List<Component>
            {
                new Component
                {
                    Title = "BoxView",
                    Description = "A component that creates a box to be displayed.",
                    Page = typeof(BoxViewPage)
                },
                new Component
                {
                    Title = "Label",
                    Description = "Displays text on the screen.",
                    Page = typeof(LabelPage)
                },
                new Component
                {
                    Title = "Button",
                    Description = "Displays a button on the screen.",
                    Page = typeof(ButtonPage)
                },
                new Component
                {
                    Title = "Image",
                    Description = "Displays an image on the screen.",
                    Page = typeof(ImagePage)
                },
                new Component
                {
                    Title = "ImageButton",
                    Description = "Displays an image with button behavior.",
                    Page = typeof(ImageButtonPage)
                }
            };

            var group = new GroupComponent() { Name = "Controls (Views)" };
            group.AddRange(components);

            _components.AddRange(components);
            _groupComponents.Add(group);
        }

        private void LoadVisuals()
        {
            var components = new List<Component> {
                new Component {
                    Title = "Frame",
                    Description = "Box that surrounds other elements.",
                    Page = typeof(FramePage)
                },
                new Component {
                    Title = "Border",
                    Description = "Box that surrounds other elements..",
                    Page = typeof(BorderPage)
                },
                new Component {
                    Title = "Shadow",
                    Description = "Adds a shadow to the element.",
                    Page = typeof(ShadowPage)
                }
            };

            var group = new GroupComponent() { Name = "Visuals" };
            group.AddRange(components);

            _components.AddRange(components);
            _groupComponents.Add(group);
        }

        private void LoadForms()
        {
            var components = new List<Component> {
                new Component {
                    Title = "Entry",
                    Description = "Creates a text input box.",
                    Page = typeof(EntryPage)
                },
                new Component {
                    Title = "Editor",
                    Description = "Creates a multi-line text input box.",
                    Page = typeof(EditorPage)
                },
                new Component {
                    Title = "Checkbox",
                    Description = "Creates a checkbox.",
                    Page = typeof(CheckBoxPage)
                },
                new Component {
                    Title = "RadioButton",
                    Description = "Creates a single choice checkbox.",
                    Page = typeof(RadioButtonPage)
                },
                new Component {
                    Title = "Switch",
                    Description = "Boolean checkbox. Switch On-Off",
                    Page = typeof(SwitchPage)
                },
                new Component {
                    Title = "Stepper",
                    Description = "Creates options to increment or decrement a number.",
                    Page = typeof(StepperPage)
                },
                new Component {
                    Title = "Slider",
                    Description = "Creates a bar that increments or decrements a number.",
                    Page = typeof(SliderPage)
                },
                new Component {
                    Title = "TimePicker",
                    Description = "Hour and Minute Selection.",
                    Page = typeof(TimePickerPage)
                },
                new Component {
                    Title = "DatePicker",
                    Description = "Date Selection.",
                    Page = typeof(DatePickerPage)
                },
                new Component {
                    Title = "SearchBar",
                    Description = "Text input field for search function.",
                    Page = typeof(SearchBarPage)
                },
                new Component {
                    Title = "Picker",
                    Description = "Select an item from the list.",
                    Page = typeof(PickerPage)
                },
            };

            var group = new GroupComponent() { Name = "Formulários" };
            group.AddRange(components);

            _components.AddRange(components);
            _groupComponents.Add(group);
        }

        private void LoadCells()
        {
            var components = new List<Component> {
                new Component {
                    Title = "TextCell",
                    Description = "It presents up to two labels, one for the title and the other for the description.",
                    Page = typeof(TextCellPage)
                },
                new Component {
                    Title = "ImageCell",
                    Description = "It presents an image with two labels, one for the title and the other for the description.",
                    Page = typeof(ImageCellPage)
                },
                new Component {
                    Title = "SwitchCell",
                    Description = "It presents a label together with a switch.",
                    Page = typeof(SwitchCellPage)
                },
                new Component {
                    Title = "EntryCell",
                    Description = "Displays a label together with an entry.",
                    Page = typeof(EntryCellPage)
                },
                new Component {
                    Title = "ViewCell",
                    Description = "Allows you to create your own cell with a custom layout.",
                    Page = typeof(ViewCellPage)
                },
            };

            var group = new GroupComponent() { Name = "Cells" };
            group.AddRange(components);

            _components.AddRange(components);
            _groupComponents.Add(group);
        }

        private void LoadCollections()
        {
            var components = new List<Component> {
                new Component {
                    Title = "TableView",
                    Description = "Displays cells in separate rows and allows grouping by section",
                    Page = typeof(TableViewPage)
                },
                new Component {
                    Title = "Picker",
                    Description = "Presents a single selection list",
                    Page = typeof(PickerListPage)
                },
                new Component {
                    Title = "ListView",
                    Description = "Displays a list of items. Most common list.",
                    Page = typeof(ListViewPage)
                },
                new Component {
                    Title = "CollectionView",
                    Description = "Displays a list of items. New approach, more performance and designed for android and IOS",
                    Page = typeof(CollectionViewPage)
                },
                new Component {
                    Title = "CarouselView",
                    Description = "Presents a horizontal list of items with side navigation. Good tool for image galleries",
                    Page = typeof(CarouselViewPage)
                },
                new Component {
                    Title = "BindableLayout (Atributo)",
                    Description = "Allows layouts to present our lists and collections.",
                    Page = typeof(BindableLayoutPage)
                },
                new Component {
                    Title = "DataTemplateSelector (Classe)",
                    Description = "Allow items to be presented with different layouts.",
                    Page = typeof(DataTemplateSelectorPage)
                }
            };

            var group = new GroupComponent() { Name = "Lists and Collections" };
            group.AddRange(components);

            _components.AddRange(components);
            _groupComponents.Add(group);
        }

        private void LoadStyles()
        {
            var components = new List<Component> {
                new Component {
                    Title = "Implicit & Explicit Styles",
                    Description = "Explain how styles work.",
                    Page = typeof(ImplicitExplicitStyles)
                },
                new Component {
                    Title = "Global Style",
                    Description = "How to create styles for your entire project.",
                    Page = typeof(GlobalStyle)
                },
                new Component {
                    Title = "ApplyToDerivedTypes",
                    Description = "Apply a style to elements derived from the current class/component.",
                    Page = typeof(ApplyDerivedTypes)
                },
                new Component {
                    Title = "Inheritance Style",
                    Description = "How to create styles derived from others.",
                    Page = typeof(InheritanceStyle)
                },
                new Component {
                    Title = "Style Class",
                    Description = "Creates style classes to be applied to components.",
                    Page = typeof(StyleClassPage)
                },
                new Component {
                    Title = "StaticResource/DynamicResource",
                    Description = "Defines whether the style can be changed in real time.",
                    Page = typeof(StaticDynamicResource)
                },
                new Component {
                    Title = "Theme",
                    Description = "Sets a default theme for our project.",
                    Page = typeof(Theme)
                },
                new Component {
                    Title = "AppThemeBinding",
                    Description = "Adapts the theme to the light/dark mode of the Operating System.",
                    Page = typeof(AppThemeBindingPage)
                },
                new Component {
                    Title = "Visual State Manager (VSM)",
                    Description = "Customizes the presentation according to the state of the component.",
                    Page = typeof(VisualStateManagerPage)
                },
            };

            var group = new GroupComponent() { Name = "Styles" };
            group.AddRange(components);

            _components.AddRange(components);
            _groupComponents.Add(group);
        }

        private void LoadAnimations()
        {
            var components = new List<Component> {
                new Component {
                    Title = "Basic Animation",
                    Description = "Basic .NET MAUI animation.",
                    Page = typeof(BasicAnimation)
                },
            };

            var group = new GroupComponent() { Name = "Animation" };
            group.AddRange(components);

            _components.AddRange(components);
            _groupComponents.Add(group);
        }

        //private void LoadUtils()
        //{
        //    var components = new List<Component> {
        //        new Component {
        //            Title = "Behavior",
        //            Description = "Lógica que pode ser associada a um componente da tela.",
        //            Page = typeof(BehaviorPage)
        //        },
        //        new Component {
        //            Title = "Trigger",
        //            Description = "Gatilho que dispara uma alteração visual no componente.",
        //            Page = typeof(TriggerPage)
        //        },
        //        new Component {
        //            Title = "OnPlatform/OnIdiom",
        //            Description = "Define valores diferentes entre o S.O. e também pelo tipo de dispositivo.",
        //            Page = typeof(PlatformIdiomPage)
        //        },
        //        new Component {
        //            Title = "Fontes",
        //            Description = "Como usar fontes diferentes no nosso aplicativo.",
        //            Page = typeof(FontPage)
        //        },
        //        new Component {
        //            Title = "Color/Brush",
        //            Description = "Como colocar as cores nos seus componentes.",
        //            Page = typeof(ColorPage)
        //        },
        //    };

        //    var group = new GroupComponent() { Name = "Útils" };
        //    group.AddRange(components);

        //    _components.AddRange(components);
        //    _groupComponents.Add(group);
        //}

        //private void LoadCommunityMaui()
        //{
        //    var components = new List<Component> {
        //        new Component {
        //            Title = "Snackbar e Toast",
        //            Description = "Formas de emitir mensagens para o usuário.",
        //            Page = typeof(AlertsPage)
        //        },
        //        new Component {
        //            Title = "Behaviors",
        //            Description = "Apresenta alguns behaviors que são: Masked, StatusBar e EventToCommand(MVVM).",
        //            Page = typeof(CommunityBehaviorPage)
        //        },
        //        new Component {
        //            Title = "Expander",
        //            Description = "Um componente que oculta/apresenta um conteúdo associado a ele.",
        //            Page = typeof(ExpanderPage)
        //        },
        //        new Component {
        //            Title = "Pop-up",
        //            Description = "Apresenta um modal(Pop-up) na tela",
        //            Page = typeof(PopupPage)
        //        },
        //        new Component {
        //            Title = "MediaElement",
        //            Description = "Player de mídia (Áudio/Vídeo)",
        //            Page = typeof(MediaElementPage)
        //        },
        //    };

        //    var group = new GroupComponent() { Name = ".NET MAUI Community Toolkit" };
        //    group.AddRange(components);

        //    _components.AddRange(components);
        //    _groupComponents.Add(group);
        //}
    }
}
