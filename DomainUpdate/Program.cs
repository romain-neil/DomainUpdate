using System;

namespace DomainUpdate
{
	class Program
	{
		class Options
		{
			[Option('d', "domain", Required = false)]
			public string Domain { get; set; }
			
			[Option('f', "file", Required = false)]
			public string FileName { get; set; }

			[Option('u', "username", Required = false)]
			public string Username { get; set; }
			
			[Option('p', "password", Required = false)]
			public string Password { get; set; }
			
			[Option('c', "connector", Required = false, Default = "miab")]
			public string Connector { get; set; }
			
			[Option('i', "instance", Required = false)]
			public string Instance { get; set; }
		}
		
		static void Main(string[] args)
		{
			Console.WriteLine("Hello World!");
		}
	}
}