using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using KretaBasicSchoolSystem.Desktop.ViewModels.Base;

namespace KretaBasicSchoolSystem.Desktop.ViewModels.SchoolGrades
{
    public partial class SchoolGradesViewModel : BaseViewModel
    {
        private CurrentTimeViewModel _currentTimeViewModel;
        private EndOfYearViewModel _endOfYearViewModel;
        private EndOfSemesterViewModel _endOfSemesterViewModel;
        private TaughtClassesViewModel _taughtClassesViewModel;

        public SchoolGradesViewModel()
        {
            _currentSchoolGradesChildView = new CurrentTimeViewModel();
            _currentTimeViewModel = new CurrentTimeViewModel();
            _currentSchoolGradesChildView = new EndOfYearViewModel();
            _endOfYearViewModel = new EndOfYearViewModel();
            _currentSchoolGradesChildView= new EndOfSemesterViewModel();
            _endOfSemesterViewModel = new EndOfSemesterViewModel();
            _currentSchoolGradesChildView = new TaughtClassesViewModel();
            _taughtClassesViewModel = new TaughtClassesViewModel();

        }

        public SchoolGradesViewModel(CurrentTimeViewModel currentTimeViewModel)
        {
            _currentTimeViewModel= currentTimeViewModel;
            _currentSchoolGradesChildView = new CurrentTimeViewModel();
        }
        public SchoolGradesViewModel(EndOfSemesterViewModel endOfSemesterViewModel)
        {
            _endOfSemesterViewModel= endOfSemesterViewModel;
            _currentSchoolGradesChildView = new EndOfSemesterViewModel();
        }
        public SchoolGradesViewModel(EndOfYearViewModel endOfYearViewModel)
        {
            _endOfYearViewModel= endOfYearViewModel;
            _currentSchoolGradesChildView = new EndOfYearViewModel();
        }
        public SchoolGradesViewModel(TaughtClassesViewModel taughtClassesViewModel)
        {
            _taughtClassesViewModel= taughtClassesViewModel;
            _currentSchoolGradesChildView = new TaughtClassesViewModel();
        }



        [ObservableProperty]
        private BaseViewModel _currentSchoolGradesChildView;


        [RelayCommand]
        public void ShowCurrentTimeView()
        {
            CurrentSchoolGradesChildView = _currentTimeViewModel;
        }
        [RelayCommand]
        public void ShowEndOfSemesterView()
        {
            CurrentSchoolGradesChildView = _endOfSemesterViewModel;
        }
        [RelayCommand]
        public void ShowEndOfYearView()
        {
            CurrentSchoolGradesChildView = _endOfYearViewModel;
        }
        [RelayCommand]
        public void ShowTaughtClassesView()
        {
            CurrentSchoolGradesChildView = _taughtClassesViewModel;
        }
    }
}

