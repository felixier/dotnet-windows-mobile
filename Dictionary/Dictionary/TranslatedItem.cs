using System;
using System.Text;

namespace Dictionary
{
	struct TranslatedItem
	{
		public readonly string Word;
		public readonly string Notes;
		public readonly string SpecialNotes;

		public TranslatedItem(string word, string notes, string specialNotes)
		{
			this.Word = word;
			this.Notes = notes;
			this.SpecialNotes = specialNotes;
		}
	}
}
