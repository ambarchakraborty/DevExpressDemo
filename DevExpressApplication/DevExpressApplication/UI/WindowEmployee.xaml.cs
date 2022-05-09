using DevExpress.Xpf.Core;
using DevExpress.Xpf.Grid;
using DevExpressApplication.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;


namespace DevExpressApplication
{
    /// <summary>
    /// Interaction logic for WindowEmployee.xaml
    /// </summary>
    public partial class WindowEmployee : ThemedWindow
    {

        public ObservableCollection<EmployeeInformation> employeeInformationList { get; set; }
        public ObservableCollection<GenderInformation> genderInformationList { get; set; }
        public EmployeeInformation employeeInformation { get; set; }
        public DevExpress.Xpf.Editors.Settings.ComboBoxEditSettings genderSettings { get; set; }
        public DevExpress.Xpf.Editors.Settings.DateEditSettings editSettings { get; set; }
        public DevExpress.Xpf.Editors.Settings.ToggleSwitchEditSettings toggleSwitchEditSettings { get; set; }



        public WindowEmployee()
        {
            InitializeComponent();
            employeeInformationList = new ObservableCollection<EmployeeInformation>();
            genderInformationList = new ObservableCollection<GenderInformation>();
        }
        public void CreateColumn()
        {
            //GridColumn gridColumn = new GridColumn();


            //idEmployeeData.

        }
        public void InitializeUI()
        {







            idEmployeeData.GroupBy("FirstName");
            //  int rowHandle = idEmployeeData.GetRowHandleByListIndex(2);
            int rowHandle = idEmployeeData.GetRowHandleByListIndex(2);


            if (!idEmployeeData.IsGroupRowHandle(rowHandle))
                rowHandle = idEmployeeData.GetParentRowHandle(rowHandle);
            if (!idEmployeeData.IsGroupRowExpanded(rowHandle))
                idEmployeeData.ExpandGroupRow(rowHandle);

            idEmployeeData.AutoExpandAllGroups = true;
            genderSettings = new DevExpress.Xpf.Editors.Settings.ComboBoxEditSettings();
            editSettings = new DevExpress.Xpf.Editors.Settings.DateEditSettings();
            toggleSwitchEditSettings = new DevExpress.Xpf.Editors.Settings.ToggleSwitchEditSettings();
            idEmployeeData.Columns["gender"].EditSettings = genderSettings;
            idEmployeeData.Columns["inCampus"].EditSettings = toggleSwitchEditSettings;
          
        }

        public void FillData()
        {
            employeeInformationList.Clear();
             genderInformationList = new ObservableCollection<GenderInformation>();
            GenderInformation genderInformation = new GenderInformation();
            genderInformation.Gender = "Male";
            genderInformationList.Add(genderInformation);
            genderInformation = new GenderInformation();
            genderInformation.Gender = "Female";
            genderInformationList.Add(genderInformation);

            employeeInformation = new EmployeeInformation();
            employeeInformation.FirstName = "Ambar";
            employeeInformation.SecondName = "Chakraborty";
            employeeInformation.contact = "324";
            employeeInformation.email = "ambarc@pinnaclecad.com";
            employeeInformation.gender = "Male";
            employeeInformation.inCampus = false;
            employeeInformation.dateOfJoin = new DateTime(2017, 1, 12);
            employeeInformationList.Add(employeeInformation);

            employeeInformation = new EmployeeInformation();
            employeeInformation.FirstName = "Umakanta";
            employeeInformation.SecondName = "Mandal";
            employeeInformation.contact = "323";
            employeeInformation.email = "umakantm@pinnaclecad.com";
            employeeInformation.gender = "Male";
            employeeInformation.inCampus = true;
            employeeInformation.dateOfJoin = new DateTime(2017, 1, 12);
            employeeInformationList.Add(employeeInformation);



            employeeInformation = new EmployeeInformation();
            employeeInformation.FirstName = "Preeti";
            employeeInformation.SecondName = "Kumari";
            employeeInformation.contact = "373";
            employeeInformation.email = "preeti.kumari@dgp.pinnaclecad.com";
            employeeInformation.gender = "Female";
            employeeInformation.inCampus = true;
            employeeInformation.dateOfJoin = new DateTime(2017, 1, 12);
            employeeInformationList.Add(employeeInformation);




            genderSettings.ItemsSource = genderInformationList;
            genderSettings.ValueMember = "Gender";
            genderSettings.DisplayMember = "Gender";
            idEmployeeData.ItemsSource = employeeInformationList;


        }


        private void ThemedWindow_Loaded(object sender, RoutedEventArgs e)
        {

            InitializeUI();
      

        }

        private void btnFetch_Click(object sender, RoutedEventArgs e)
        {

            EmployeeInformation employeeInformation = idEmployeeData.GetFocusedRow() as EmployeeInformation;
            //  idEmployeeData.(visibleIndex, "Country;City;Population", OnGetGridViewValues);
        }

        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {
            employeeInformation = new EmployeeInformation();
            employeeInformation.FirstName = "X";
            employeeInformation.SecondName = "Y";
            employeeInformation.contact = "373";
            employeeInformation.email = "preeti.kumari@dgp.pinnaclecad.com";
            employeeInformation.gender = "Female";
            employeeInformation.inCampus = true;
            employeeInformation.dateOfJoin = new DateTime(2017, 1, 12);
            employeeInformationList.Add(employeeInformation);
            idEmployeeData.ItemsSource = employeeInformationList;
        }

        private void btnLoad_Click(object sender, RoutedEventArgs e)
        {
            FillData();
        }

        private void btnDelete_Click(object sender, RoutedEventArgs e)
        {
            EmployeeInformation employeeInformation = idEmployeeData.GetFocusedRow() as EmployeeInformation;


           int index= employeeInformationList.IndexOf(employeeInformation);
            employeeInformationList.RemoveAt(index);
        }

        private void DXTabControl_SelectionChanged(object sender, TabControlSelectionChangedEventArgs e)
        {

        }
    }
}
