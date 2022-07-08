using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructuresAndAlgorithms.cSharpBasic
{
    public enum NoteState
    {
        completed,
        active,
        others
    }
    public class NotesStore
    {
        private List<string> notes = new List<string>();

        public NotesStore() {}
        public void AddNote(string state, string name) 
        {
            if (name == "")
                throw new Exception("Name cannot be empty");

            if (!IsValidState(state))
                throw new Exception($"Invalid state {state}");

            notes.Add(state + "," + name);
        }

        public List<string> GetNotes(string state) 
        {
            if (!IsValidState(state))
                throw new Exception($"Invalid state {state}");

            if (notes.Count == 0)
                return new List<string>();

            var tempList = new List<string>();
            foreach(var element in notes)
            {
                var elements = element.Split(",");
                if (state == elements[0])
                    tempList.Add(elements[1]);
            }

            return tempList;
        }

        private bool IsValidState(string state)
        {
            if (state == NoteState.completed.ToString() || state == NoteState.active.ToString() || state == NoteState.others.ToString())
                return true;
            else
                return false;
        }
    }
}
