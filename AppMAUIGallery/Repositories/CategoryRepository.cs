﻿using AppMAUIGallery.Models;
using AppMAUIGallery.Views.Components;
using AppMAUIGallery.Views.Components.Cells;
using AppMAUIGallery.Views.Components.Forms;
using AppMAUIGallery.Views.Components.Lists;
using AppMAUIGallery.Views.Components.Mains;
using AppMAUIGallery.Views.Components.Visuals;
using AppMAUIGallery.Views.Layouts;

namespace AppMAUIGallery.Repositories
{
    internal class CategoryRepository
    {
        public CategoryRepository() { }

        public List<Category> GetCategories()
        {
            List<Category> categories = new List<Category>();
            categories.Add(new Category
            {
                Name = "Layout",
                Components = new List<Component> {
                    new Component {
                        Title = "StackLayout",
                        Description = "Organização sequencial dos elementos.",
                        Page = typeof(StackLayoutPage)
                    },
                    new Component
                    {
                        Title = "Grid",
                        Description = "Organiza os elementos dentro de uma tabela.",
                        Page = typeof(GridLayoutPage)
                    },
                    new Component
                    {
                        Title = "AbsoluteLayout",
                        Description = "Liberdade total para posicionar e dimensionar os elementos na tela.",
                        Page = typeof(AbsoluteLayoutPage)
                    },
                    new Component
                    {
                        Title = "FlexLayout",
                        Description = "Organiza os elementos de forma sequencial com muitas opções de personalização.",
                        Page = typeof(FlexLayoutPage)
                    }
                }
            });

            categories.Add(new Category
            {
                Name = "Components",
                Components = new List<Component> {
                    new Component {
                        Title = "BoxView",
                        Description = "Diferentes formas de boxview.",
                        Page = typeof(BoxViewPage)
                    },
                     new Component {
                        Title = "Lable",
                        Description = "atributos do lable.",
                        Page = typeof(LabelPage)
                    }

                }
            });

            categories.Add(new Category
            {
                Name = "Visuais",
                Components = new List<Component> {
                    new Component {
                        Title = "Frame",
                        Description = "Caixa que envolve outros elementos.",
                        Page = typeof(FramePage)
                    },
                    new Component {
                        Title = "Border",
                        Description = "Caixa que envolve outros elementos.",
                        Page = typeof(BorderPage)
                    },
                     new Component {
                        Title = "Shadow",
                        Description = "Adiciona uma sombra ao elemento.",
                        Page = typeof(ShadowPage)
                    }

                }
            });

            categories.Add(new Category
            {
                Name = "Forms",
                Components = new List<Component> {
                    new Component {
                        Title = "Entry",
                        Description = "Cria uma caixa de entrada de texto.",
                        Page = typeof(EntryPage)
                    },
                    new Component {
                        Title = "Editor",
                        Description = "Cria uma caixa de entrada de texto grande",
                        Page = typeof(EditorPage)
                    },
                    new Component {
                        Title = "Checkbox",
                        Description = "Caixa de selecao",
                        Page = typeof(CheckBoxPage)
                    },
                    new Component {
                        Title = "Radio Button",
                        Description = "Grupo de Caixa de selecao",
                        Page = typeof(RadioButtonPage)
                    },
                    new Component {
                        Title = "Switch Button",
                        Description = "chave switch",
                        Page = typeof(SwitchPage)
                    },
                    new Component {
                        Title = "Stepper Button",
                        Description = "button stepper",
                        Page = typeof(StepperPage)
                    },
                    new Component {
                        Title = "Slider Button",
                        Description = "Barra de controle",
                        Page = typeof(SliderPage)
                    },
                    new Component {
                        Title = "Time Picker",
                        Description = "Component to get time from user",
                        Page = typeof(TimePickerPage)
                    },
                    new Component {
                        Title = "Date Picker",
                        Description = "Component to get date from user",
                        Page = typeof(DatePickerPage)
                    },
                    new Component {
                        Title = "Search Bar entry",
                        Description = "Component search entry",
                        Page = typeof(SearchBarPage)
                    },
                    new Component {
                        Title = "Picker - DropDown",
                        Description = "Picker Component = Dropdown",
                        Page = typeof(PickerPage)
                    }

                }
            });

            categories.Add(new Category
            {
                Name = "Cells",
                Components = new List<Component> {
                    new Component {
                        Title = "TextCell",
                        Description = "Apresenta até duas labels onde uma titulo e outra descricao",
                        Page = typeof(TextCellPage)
                    },
                    new Component {
                        Title = "Image Cell",
                        Description = "Imagem dentro de tabelas",
                        Page = typeof(ImageCellPage)
                    },
                    new Component {
                        Title = "Switch Cell",
                        Description = "switch dentro de tabelas",
                        Page = typeof(SwitchCellPage)
                    },
                    new Component {
                        Title = "Entry Cell",
                        Description = "Entry dentro de tabelas",
                        Page = typeof(EntryCellPage)
                    },
                    new Component {
                        Title = "View Cell",
                        Description = "Permite criar uma celula personalizada",
                        Page = typeof(ViewCellPage)
                    }
                }
            });

            categories.Add(new Category
            {
                Name = "Listas e Colecoes",
                Components = new List<Component> {
                    new Component {
                        Title = "TableView",
                        Description = "Apresenta células em listas separadas e permite agrupar",
                        Page = typeof(TableViewPage)
                    },
                    new Component {
                        Title = "PickerListPage",
                        Description = "Popular um dropdown com dados code behind",
                        Page = typeof(PickerListPage)
                    },
                    new Component {
                        Title = "ListViewtPage",
                        Description = "Forma mais popular de criar Listas simples. Menos opcoes que collectionview e mais antiga.",
                        Page = typeof(ListViewPage)
                    },
                    new Component {
                        Title = "CollectionViewPage",
                        Description = "Forma mais atual de criar listas com funcao virtualize e muitas funcionalidades. Para listas complexas",
                        Page = typeof(CollectionViewPage)
                    },
                    new Component {
                        Title = "CarouselViewPage",
                        Description = "Popular uma CarouselViewPage view",
                        Page = typeof(CarouselViewPage)
                    },
                    new Component {
                        Title = "BindableLayout (Atributo)",
                        Description = "Permitir que layouts possam apresentar listas",
                        Page = typeof(BindableLayoutPage)
                    },
                    new Component {
                        Title = "DataTemplateSelectorPage (Classe)",
                        Description = "Permitir que os itens possam apresentar layouts diferentes.",
                        Page = typeof(DataTemplateSelectorPage)
                    }
                }
            });

            categories.Add(new Category
            {
                Name = "Shell",
                Components = new List<Component> {
                    new Component {
                        Title = "Shell",
                        Description = "Cria uma caixa de entrada de texto.",
                        Page = typeof(EntryPage)
                    }
                    
                }
            });

            return categories;
        }
    }
}
