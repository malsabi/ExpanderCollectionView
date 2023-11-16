using CommunityToolkit.Maui.Core.Extensions;
using CommunityToolkit.Mvvm.ComponentModel;
using ExpanderCollectionView.Models;
using System.Collections.ObjectModel;

namespace ExpanderCollectionView.ViewModels
{
    public class MainViewModel : ObservableObject
    {
        public ObservableCollection<ExamineeModel> Examinees { get; } = ExamineeGenerator.GenerateExaminees(10).ToObservableCollection();
    }
}