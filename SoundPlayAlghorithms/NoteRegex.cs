using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace MusicCircle.SoundPlayAlghorithms
{
    internal class NoteRegex
    {
        private static readonly Regex regex = new Regex("[A-Z](b|#)?\\d?", RegexOptions.Compiled);
        internal static string[] RegexNotes(string notes)
        {
            MatchCollection noteMatchCollection = regex.Matches(notes);
            return noteMatchCollection.Cast<Match>().Select(match => match.Value).ToArray(); ;
        }
    }
}
