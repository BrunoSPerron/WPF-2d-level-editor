﻿using System;
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
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using ProjetJeuxVideo_LevelEditor_Metroidvania.ViewModels;

namespace ProjetJeuxVideo_LevelEditor_Metroidvania.Views
{
    /// <summary>
    /// Logique d'interaction pour AnimationMakerWindow.xaml
    /// </summary>
    public partial class AnimationMakerWindow : Window
    {
        public AnimationMakerWindow(EditorViewModel evm)
        {
            InitializeComponent();
            DataContext = new AnimationMakerViewModel(evm);
        }
    }
}
