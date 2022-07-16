using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructuresAndAlgorithms.cSharpBasic.NoteStore
{
    
    public class NotesStore
    {
        private List<Note> notes = new List<Note>();
        public NotesStore() {}

        /// <summary>
        /// Add a note to the list of Notes
        /// </summary>
        /// <param name="state"></param>
        /// <param name="name"></param>
        /// <exception cref="ArgumentException"></exception>
        public void AddNote(string state, string name)
        {
            if (name == string.Empty)
            {
                throw new ArgumentException("Name cannot be empty");
            }

            var noteState = GetNoteState(state.ToLower());
            notes.Add(new Note { NoteState = noteState, Name = name});
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="state"></param>
        /// <returns>A list of notes based on a state</returns>
        public List<Note> GetNotes(string state)
        {
            if (notes.Count == 0)
            {
                return new List<Note>();
            }

            var noteState = GetNoteState(state.ToLower());
            var tempList = new List<Note>();

            foreach(var element in notes)
            {
                if(noteState == element.NoteState)
                {
                    tempList.Add(element);
                }
            }

            return tempList;
        }

        /// <summary>
        /// Displays the list of notes
        /// </summary>
        /// <param name="notes"></param>
        public void DisplayNotes(List<Note> notes)
        {
            foreach (var note in notes)
            {
                Console.WriteLine(note);
            }
        }

        /// <summary>
        /// Gets the Note State from the enum
        /// </summary>
        /// <param name="state"></param>
        /// <returns></returns>
        /// <exception cref="ArgumentException"></exception>
        private NoteState GetNoteState(string state)
        {
            if (state == NoteState.completed.ToString())
            {
                return NoteState.completed;
            }
            else if (state == NoteState.active.ToString())
            {
                return NoteState.active;
            }
            else if (state == NoteState.others.ToString())
            {
                return NoteState.others;
            }
            else
            {
                throw new ArgumentException($"Invalid state {state}");
            }
        }
    }
}
