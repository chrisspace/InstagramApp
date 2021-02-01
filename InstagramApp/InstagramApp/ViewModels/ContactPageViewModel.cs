using InstagramApp.Models;
using InstagramApp.Models.Repositories;
using InstagramApp.Utility;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace InstagramApp.ViewModels
{
    public class ContactPageViewModel:BaseViewModel
    {
         private ObservableCollection<Contact> _contacts;



        private List<Contact> _searchedContacts = new List<Contact>();
        public List<Contact> SearchedContacts 
        { 
            get => _searchedContacts; 
            set 
            {
                _searchedContacts = value; 
                OnPropertyChanged("SearchedContacts"); 
            } 
        }




        //private string _searchText = string.Empty;

        //public string SearchText
        //{
        //    get { return _searchText; }
        //    set
        //    {
        //        if (_searchText != value)
        //        {
        //            _searchText = value ?? string.Empty; ;
        //            RaisePropertyChanged(() => SearchText);

        //            // Perform the search
        //            if (SearchCommand.CanExecute(null))
        //            {
        //                SearchCommand.Execute(null);
        //            }
        //        }
        //    }
        //}

        //public ObservableCollection<Contact>contacts
        //{
        //    get
        //    {
        //        ObservableCollection<Contact> theCollection = new ObservableCollection<Contact>();

        //        //if (contacts != null)
        //        //{
        //        //    List<Contact> c = contacts.Contains(_searchText);


        //        //}

        //        return theCollection;
        //    }
        //}




        public ICommand GoingToPhotosCommand { get; }
        public ICommand SearchBarTextChangedCommand { get; }


        public ObservableCollection<Contact> Contacts
        {
            get => _contacts;
            set
            {
                _contacts = value;
                OnPropertyChanged("Contacts");
            }
        }

        public ContactPageViewModel()
        {
            Contacts = new ObservableCollection<Contact>();
            Contacts = new ObservableCollection<Contact>(ContactRepository.Contacts);
            GoingToPhotosCommand = new Command(OnGoingToPhotos);
            //SearchBarTextChangedCommand = new Command<string>(OnSearchBarTextChangedCommand);
        }

        private void OnGoingToPhotos()
        {
            App.NavigationService.NavigateTo(PageNames.PhotosPage);
        }


        //private void OnSearchBarTextChangedCommand(object obj)
        //{ if (obj is TextChangedEventArgs args) 
        //    { 
        //      string filter = args.NewTextValue; 
        //      SearchedContacts = Contacts.Where(c => c.Name.ToLower().Contains(filter.Trim().ToLower())).ToList(); 
        //    } 
        //}

        //private string _searchQuery;
        //private List<Contact> _unfilteredResults;
        //public string SearchQuery
        //{
        //    get { return _searchQuery; }
        //    set
        //    {
        //        _searchQuery = value;
        //        RaisePropertyChanged(() => SearchQuery);
        //        RaisePropertyChanged(() => FilteredResults);
        //    }
        //}

        //public List<Contact> UnfilteredResults
        //{
        //    get { return _unfilteredResults; }
        //    set
        //    {
        //        _unfilteredResults = value;
        //        RaisePropertyChanged(() => UnfilteredResults);
        //        RaisePropertyChanged(() => FilteredResults);
        //    }
        //}

        //public List<Contact> FilteredResults
        //{
        //    get
        //    {
        //        if (string.IsNullOrEmpty(SearchQuery))
        //            return UnfilteredResults;

        //        return UnfilteredResults
        //            .Where(r => r.Name.Contains(SearchQuery)).ToList();
        //    }
        //}



        //private void OnSearchCommand(string SearchText)
        //{

        //    if (/*SearchText=="aa"*/ Contacts. Contains(SearchText))
        //        App.NavigationService.NavigateTo(PageNames.InfoPage);
        //    else
        //    {
        //        //Contacts = Contacts.Where(c => c.Name.ToLower().Contains(SearchText));
        //        App.NavigationService.NavigateTo(PageNames.PhotosPage);
        //    }


        //}


        //private void GetContacts()
        //{

        //}

        //private void SearchBar_TextChanged(object sender, TextChangedEventArgs e)
        //{
        //    ContactsListView.BeginRefresh();

        //    if (string.IsNullOrWhiteSpace(e.NewTextValue))
        //        YOUR_LISTVIEW.ItemsSource = YourViewModel.Items;
        //    else
        //        YOUR_LISTVIEW.ItemsSource = YourViewModel.Items.Where(i => i.Name.ToLower().Contains(e.NewTextValue.ToLower()));

        //    YOUR_LISTVIEW.EndRefresh();
        //}
    }
}
