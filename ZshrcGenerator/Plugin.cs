namespace ZshrcGenerator
{
	public class Plugin
	{
		public bool   BuiltIn;
		public string GithubLink;
		public string Name;

		public Plugin(string name, bool builtIn, string githubLink)
		{
			BuiltIn    = builtIn;
			GithubLink = githubLink;
			Name       = name;
		}
	}
}