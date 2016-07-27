using NotesApp.Data.Model;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Media.Animation;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace NotesApp.Views
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class NoteList : Page
    {
        public NoteList()
        {
            this.InitializeComponent();

            var notes = new List<Note>();
            notes.Add(new Note() { Id = 1, Title = "UWP Prep Notes",
                Content = "Make sure we cover list view, item templates, and the item data source for Wednesday Evenings Lesson"
            });
            notes.Add(new Note() { Id = 2, Title = "V&V Prep Notes" });

            NotesListView.ItemsSource = notes;
        }

        private void NotesListView_ItemClick(object sender, ItemClickEventArgs e)
        {
            var selectedNote = e.ClickedItem as Note;

            Frame.Navigate(typeof(NoteDetail), selectedNote, new DrillInNavigationTransitionInfo());
        }
    }
}
