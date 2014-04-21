using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Roslyn.Compilers;
using Roslyn.Compilers.CSharp;
using Roslyn.Scripting.CSharp;

namespace Brainfuck {
	public static class BrainfuckExtension {
		public static string Brainfuck(this string src) {
			var sb = new StringBuilder();
			sb.AppendLine(@"var ptr = 0;");
			sb.AppendLine(@"var buffer = new char[30000];");
			foreach (var c in src) {
				switch (c) {
					case '>':
						sb.AppendLine(@"++ptr;");
						break;
					case '<':
						sb.AppendLine(@"--ptr;");
						break;
					case '+':
						sb.AppendLine(@"buffer[ptr] = (char)(buffer[ptr] + 1);");
						break;
					case '-':
						sb.AppendLine(@"buffer[ptr] = (char)(buffer[ptr] - 1);");
						break;
					case '.':
						sb.AppendLine(@"Console.Write(buffer[ptr]);");
						break;
					case ',':
						sb.AppendLine(@"buffer[ptr] = (char)Console.Read();");
						break;
					case '[':
						sb.AppendLine(@"while(buffer[ptr] != 0) {");
						break;
					case ']':
						sb.AppendLine(@"}");
						break;
					default:
						break;
				}
			}
			var code = sb.ToString();
			//run 
			var engine = new ScriptEngine();
			engine.ImportNamespace("System");
			var session = engine.CreateSession();
			session.Execute(code);

			return code;
		}
	}
}
