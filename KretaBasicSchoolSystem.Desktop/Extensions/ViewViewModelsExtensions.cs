using KretaBasicSchoolSystem.Desktop.ViewModels;
using KretaBasicSchoolSystem.Desktop.ViewModels.ControlPanel;
using KretaBasicSchoolSystem.Desktop.ViewModels.Login;
using KretaBasicSchoolSystem.Desktop.ViewModels.SchoolCitizens;
using KretaBasicSchoolSystem.Desktop.ViewModels.SchoolClasses;
using KretaBasicSchoolSystem.Desktop.ViewModels.SchoolGrades;
using KretaBasicSchoolSystem.Desktop.ViewModels.SchoolSubjects;
using KretaBasicSchoolSystem.Desktop.Views;
using KretaBasicSchoolSystem.Desktop.Views.ControlPanel;
using KretaBasicSchoolSystem.Desktop.Views.Login;
using KretaBasicSchoolSystem.Desktop.Views.SchoolCitizens;
using KretaBasicSchoolSystem.Desktop.Views.SchoolClasses;
using KretaBasicSchoolSystem.Desktop.Views.SchoolGrades;
using KretaBasicSchoolSystem.Desktop.Views.SchoolSubjects;
using Microsoft.Extensions.DependencyInjection;
using System.Runtime.Serialization.DataContracts;

namespace KretaDesktop.Extensions
{
    public static class ViewViewModelsExtensions
    {
        public static void ConfigureViewViewModels(this IServiceCollection services)
        {
            // MainView
            services.AddSingleton<MainViewModel>();
            services.AddSingleton<MainView>(s => new MainView()
            {
                DataContext = s.GetRequiredService<MainViewModel>()
            });

            // LoginView
            services.AddSingleton<LoginViewModel>();
            services.AddSingleton<LoginView>(s => new LoginView()
            {
                DataContext = s.GetRequiredService<LoginViewModel>()
            });

            // ControlPanel
            services.AddSingleton<ControlPanelViewModel>();
            services.AddSingleton<ControlPanelView>(s => new ControlPanelView()
            {
                DataContext = s.GetRequiredService<ControlPanelViewModel>()
            });
            // School Citizens
            services.AddSingleton<SchoolCitizensViewModel>();
            services.AddSingleton<SchoolCitizensView>(s => new SchoolCitizensView()
            {
                DataContext = s.GetRequiredService<SchoolCitizensViewModel>()
            });

            // Students
            // School Citizens
            services.AddSingleton<StudentViewModel>();
            services.AddSingleton<StudentView>(s => new StudentView()
            {
                DataContext = s.GetRequiredService<StudentViewModel>()
            });
            services.AddSingleton<TeacherViewModel>();
            services.AddSingleton<TeacherView>(s => new TeacherView()
            {
                DataContext = s.GetService<TeacherViewModel>()
            });

            // School Class
            services.AddSingleton<SchoolClassesViewModel>();
            services.AddSingleton<SchoolClassesView>(s => new SchoolClassesView()
            {
                DataContext = s.GetRequiredService<SchoolClassesViewModel>()
            });

            // School Subject
            services.AddSingleton<SchoolSubjectsViewModel>();
            services.AddSingleton<SchoolSubjectsView>(s => new SchoolSubjectsView()
            {
                DataContext = s.GetRequiredService<SchoolSubjectsViewModel>()
            });

            // School Grades
            services.AddSingleton<SchoolGradesViewModel>();
            services.AddSingleton<SchoolGradesView>(s => new SchoolGradesView()
            {
                DataContext = s.GetRequiredService<SchoolGradesViewModel>()
            });

            // School Grades
            //CurrentTime
            services.AddSingleton<CurrentTimeViewModel>();
            services.AddSingleton<CurrentTimeView>(s => new CurrentTimeView{
                DataContext = s.GetRequiredService<CurrentTimeViewModel>()
            });

            // School Grades
            //EndOfSemester
            services.AddSingleton<EndOfSemesterViewModel>();
            services.AddSingleton<EndOfSemesterView>(s => new EndOfSemesterView
            {
                DataContext = s.GetRequiredService<EndOfSemesterViewModel>()

            });

            // School Grades
            //EndOfYear
            services.AddSingleton<EndOfYearViewModel>();
            services.AddSingleton<EndOfYearView>(s => new EndOfYearView
            {
                DataContext = s.GetRequiredService<EndOfYearViewModel>()

            });

            // School Grades
            //EndOfSemester
            services.AddSingleton<TaughtClassesViewModel>();
            services.AddSingleton<TaughtClassesView>(s => new TaughtClassesView
            {
                DataContext = s.GetRequiredService<TaughtClassesViewModel>()

            });

        }
}
}
