using System;
using System.Windows.Media;

namespace WpfBindingExample
{
    public class DataClass
    {
        //       private Notes note = new Notes();
        public Notes GetNotes()
        {
            var note = new Notes();
            note.Id = Guid.NewGuid();
            note.NoteDetailsList.Add(new NoteDetails { NoteId = note.Id, NoteName = "Note 1", NoteText = "Note 1 Text" });
            note.NoteDetailsList.Add(new NoteDetails { NoteId = note.Id, NoteName = "Note 2", NoteText = "Note 2 Text" });
            note.NoteDetailsList.Add(new NoteDetails { NoteId = note.Id, NoteName = "Note 3", NoteText = "Note 3 Text" });
            note.NoteDetailsList.Add(new NoteDetails { NoteId = note.Id, NoteName = "Note 4", NoteText = "Note 4 Text" });
            note.NoteDetailsList.Add(new NoteDetails { NoteId = note.Id, NoteName = "Note 5", NoteText = "Note 5 Text" });
            note.NoteDetailsList.Add(new NoteDetails { NoteId = note.Id, NoteName = "Note 6", NoteText = "Note 6 Text" });
            note.NoteDetailsList.Add(new NoteDetails { NoteId = note.Id, NoteName = "Note 7", NoteText = "Note 7 Text" });
            note.FullName = "Test Note";
            note.IsDeleted = false;
            note.CreatedDate = DateTime.Now;
            

            return note;


        }
        public void fill()
        {

            //    TNotes note = new TNotes();
            //new NoteDetails { };
            //new NoteDetails { NoteName = "Note 2", NoteText = "Note 2 Text" };
            //new NoteDetails { NoteName = "Note 3", NoteText = "Note 3 Text" };
            //new NoteDetails { NoteName = "Note 4", NoteText = "Note 4 Text" };
            //new NoteDetails { NoteName = "Note 5", NoteText = "Note 5 Text" };


        }

    }


}
