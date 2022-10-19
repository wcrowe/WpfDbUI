using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using WpfBindingExample;

namespace WpfBindingExample
{
    public class Notes : INotifyPropertyChanged
    {
        private Guid _id;
        private string? _fullName;
        private DateTime? _createdDate;
        private bool _isDeleted;
        private ObservableCollection<NoteDetails>? _noteDetailsList;

        public Notes()
        {
            _noteDetailsList = new();
        }

        public Guid Id
        {
            get => _id;
            set => SetField(ref _id, value);
        }


        public ObservableCollection<NoteDetails> NoteDetailsList
        {

            get => _noteDetailsList!;

            set => SetField(ref _noteDetailsList, value);
        }



        public string FullName
        {
            get => _fullName ?? "";
            set => SetField(ref _fullName, value);
        }

        public DateTime CreatedDate
        {
            get => _createdDate ?? DateTime.Now;
            set => SetField(ref _createdDate, value);
        }

        public bool IsDeleted
        {
            get => _isDeleted;
            set => SetField(ref _isDeleted, value);
        }

        public event PropertyChangedEventHandler? PropertyChanged;

        protected virtual void OnPropertyChanged([CallerMemberName] string? propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        protected bool SetField<T>(ref T field, T value, [CallerMemberName] string? propertyName = null)
        {
            if (EqualityComparer<T>.Default.Equals(field, value)) return false;
            field = value;
            OnPropertyChanged(propertyName);
            return true;
        }
    }


    public class NoteDetails
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public Guid NoteId { get; set; }
        public string NoteName { get; set; } = string.Empty;

        public string NoteText { get; set; } = string.Empty;
        public DateTime CreatedDate { get; set; } = DateTime.Now;
        public bool IsDeleted { get; set; } = false;

    }




    //Note details class inherits ObservableCollection
    public class NoteDetailslist : ObservableCollection<NoteDetails>
    {
        public void AddNoteDetails(NoteDetails noteDetails)
        {
            Add(noteDetails);
        }

        public void RemoveNoteDetails(NoteDetails noteDetails)
        {
            Remove(noteDetails);
        }

        public void UpdateNoteDetails(NoteDetails noteDetails)
        {
            var index = IndexOf(noteDetails);
            if (index != -1)
            {
                this[index] = noteDetails;
            }
        }

        public NoteDetails FindNoteDetails(Guid id)
        {
            return this.FirstOrDefault(x => x.Id == id)!;
        }

        public void ClearNoteDetails()
        {
            Clear();
        }

    }
}