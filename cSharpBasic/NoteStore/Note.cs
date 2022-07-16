using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructuresAndAlgorithms.cSharpBasic.NoteStore
{
    public enum NoteState
    {
        completed,
        active,
        others
    }

    public class Note
    {
        public NoteState NoteState { get; set; }

        public string Name { get; set; }

        public override string ToString()
        {
            return Name + " " + NoteState.ToString();
        }
    }
}
