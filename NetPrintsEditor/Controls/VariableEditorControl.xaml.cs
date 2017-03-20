﻿using NetPrints.Core;
using NetPrintsEditor.ViewModels;
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
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace NetPrintsEditor.Controls
{
    /// <summary>
    /// Interaction logic for VariableEditorControl.xaml
    /// </summary>
    public partial class VariableEditorControl : UserControl
    {
        public static DependencyProperty VariableProperty = DependencyProperty.Register(
            nameof(Variable), typeof(VariableVM), typeof(VariableEditorControl));

        public VariableVM Variable
        {
            get => (VariableVM)GetValue(VariableProperty);
            set => SetValue(VariableProperty, value);
        }

        public VariableEditorControl()
        {
            InitializeComponent();
        }
    }
}