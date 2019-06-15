namespace Infrastructure
{
	public class Documentation : object
	{
		protected enum WordType
		{
			Persian,
			NonPersian,
		}

		public Documentation(string source) : base()
		{
			Source = source;

			Convert();
		}

		public string Source { get; set; }

		public string Result { get; set; }

		protected virtual void Convert()
		{
			string source = Source;

			if (source == null)
			{
				Result = string.Empty;
				return;
			}

			source = source.Trim();

			if (source == string.Empty)
			{
				Result = string.Empty;
				return;
			}

			while (source.Contains("  "))
			{
				source =
					source.Replace("  ", " ");
			}

			source = source.Replace(" .", ".");
			source = source.Replace(" !", "!");

			source = source.Replace(" ?", "?");
			source = source.Replace(" ؟", "؟");

			source = source.Replace(" ,", ",");
			source = source.Replace(" ،", "،");

			source = source.Replace("( ", "(");
			source = source.Replace(" )", ")");

			source = source.Replace("[ ", "[");
			source = source.Replace(" ]", "]");

			source = source.Replace("{ ", "{");
			source = source.Replace(" }", "}");

			string[] words =
				source.Split(' ');

			WordType currentWordType = WordType.Persian;

			System.Collections.Generic.List<string>
				slaveList = new System.Collections.Generic.List<string>();

			System.Collections.Generic.List<string>
				masterList = new System.Collections.Generic.List<string>();

			for (int index = words.Length - 1; index >= 0; index--)
			{
				string word = words[index];

				WordType wordType = GetWordType(word);

				if (currentWordType != wordType)
				{
					currentWordType = wordType;

					slaveList.Reverse();

					foreach (var tempWord in slaveList)
					{
						masterList.Add(tempWord);
					}

					slaveList.Clear();
				}

				slaveList.Add(word);
			}

			slaveList.Reverse();

			foreach (var tempWord in slaveList)
			{
				masterList.Add(tempWord);
			}

			for (int index = 0; index <= masterList.Count - 1; index++)
			{
				Result += masterList[index];

				if (index != masterList.Count - 1)
				{
					Result += " ";
				}
			}
		}

		protected virtual WordType GetWordType(string word)
		{
			char firstChar = word[0];

			if ((firstChar >= '0') && (firstChar <= '9'))
			{
				return WordType.NonPersian;
			}

			if ((firstChar >= 'a') && (firstChar <= 'z'))
			{
				return WordType.NonPersian;
			}

			if ((firstChar >= 'A') && (firstChar <= 'Z'))
			{
				return WordType.NonPersian;
			}

			return WordType.Persian;
		}
	}
}
