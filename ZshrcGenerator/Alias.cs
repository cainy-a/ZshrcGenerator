using System;

namespace ZshrcGenerator
{
	public class Alias
	{
		/// <summary>
		/// Represents a zsh alias.
		/// </summary>
		/// <param name="key">The alias keyword</param>
		/// <param name="replacement">The replacement for the keyword</param>
		/// <param name="suffix">Whether to look for the keyword at the end</param>
		/// <param name="function">Whether the alias is a function</param>
		/// <param name="permissive">If enabled and suffix and function are both true, function will take priority and no exception will be thrown.</param>
		public Alias(string key, string replacement, bool suffix = false, bool function = false, bool permissive = false)
		{
			if (!permissive)
			{
				if (suffix && function)
					throw new Exception("Alias cannot be suffix and function simultaneously");
			}
			else if (function) suffix = false;

			Key         = key;
			Replacement = replacement;
			Suffix      = suffix;
			Function    = function;
		}

		public string Key;
		public string Replacement;
		public bool   Suffix;
		public bool   Function;
	}
}
