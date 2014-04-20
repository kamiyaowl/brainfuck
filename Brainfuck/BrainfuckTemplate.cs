
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Brainfuck {
	public static class BrainfuckTemplete {
	
		public const string Source = @">+++++++++[<++++++++>-]<.>+++++++[<++++>-]<+.+++++++..+++.[-]>++++++++[<++++>-]<.>+++++++++++[<+++++>-]<.>++++++++[<+++>-]<.+++.------.--------.[-]>++++++++[<++++>-]<+.[-]++++++++++.";
		public static void Run() {
			var ptr = 0;
			var buffer = new char[30000];
				 ++ptr; 
				 ++buffer[ptr]; 
				 ++buffer[ptr]; 
				 ++buffer[ptr]; 
				 ++buffer[ptr]; 
				 ++buffer[ptr]; 
				 ++buffer[ptr]; 
				 ++buffer[ptr]; 
				 ++buffer[ptr]; 
				 ++buffer[ptr]; 
				 while(buffer[ptr] != 0) {
				 --ptr; 
				 ++buffer[ptr]; 
				 ++buffer[ptr]; 
				 ++buffer[ptr]; 
				 ++buffer[ptr]; 
				 ++buffer[ptr]; 
				 ++buffer[ptr]; 
				 ++buffer[ptr]; 
				 ++buffer[ptr]; 
				 ++ptr; 
				--buffer[ptr];  
				 }
				 --ptr; 
				 Console.Write(buffer[ptr]); 
				 ++ptr; 
				 ++buffer[ptr]; 
				 ++buffer[ptr]; 
				 ++buffer[ptr]; 
				 ++buffer[ptr]; 
				 ++buffer[ptr]; 
				 ++buffer[ptr]; 
				 ++buffer[ptr]; 
				 while(buffer[ptr] != 0) {
				 --ptr; 
				 ++buffer[ptr]; 
				 ++buffer[ptr]; 
				 ++buffer[ptr]; 
				 ++buffer[ptr]; 
				 ++ptr; 
				--buffer[ptr];  
				 }
				 --ptr; 
				 ++buffer[ptr]; 
				 Console.Write(buffer[ptr]); 
				 ++buffer[ptr]; 
				 ++buffer[ptr]; 
				 ++buffer[ptr]; 
				 ++buffer[ptr]; 
				 ++buffer[ptr]; 
				 ++buffer[ptr]; 
				 ++buffer[ptr]; 
				 Console.Write(buffer[ptr]); 
				 Console.Write(buffer[ptr]); 
				 ++buffer[ptr]; 
				 ++buffer[ptr]; 
				 ++buffer[ptr]; 
				 Console.Write(buffer[ptr]); 
				 while(buffer[ptr] != 0) {
				--buffer[ptr];  
				 }
				 ++ptr; 
				 ++buffer[ptr]; 
				 ++buffer[ptr]; 
				 ++buffer[ptr]; 
				 ++buffer[ptr]; 
				 ++buffer[ptr]; 
				 ++buffer[ptr]; 
				 ++buffer[ptr]; 
				 ++buffer[ptr]; 
				 while(buffer[ptr] != 0) {
				 --ptr; 
				 ++buffer[ptr]; 
				 ++buffer[ptr]; 
				 ++buffer[ptr]; 
				 ++buffer[ptr]; 
				 ++ptr; 
				--buffer[ptr];  
				 }
				 --ptr; 
				 Console.Write(buffer[ptr]); 
				 ++ptr; 
				 ++buffer[ptr]; 
				 ++buffer[ptr]; 
				 ++buffer[ptr]; 
				 ++buffer[ptr]; 
				 ++buffer[ptr]; 
				 ++buffer[ptr]; 
				 ++buffer[ptr]; 
				 ++buffer[ptr]; 
				 ++buffer[ptr]; 
				 ++buffer[ptr]; 
				 ++buffer[ptr]; 
				 while(buffer[ptr] != 0) {
				 --ptr; 
				 ++buffer[ptr]; 
				 ++buffer[ptr]; 
				 ++buffer[ptr]; 
				 ++buffer[ptr]; 
				 ++buffer[ptr]; 
				 ++ptr; 
				--buffer[ptr];  
				 }
				 --ptr; 
				 Console.Write(buffer[ptr]); 
				 ++ptr; 
				 ++buffer[ptr]; 
				 ++buffer[ptr]; 
				 ++buffer[ptr]; 
				 ++buffer[ptr]; 
				 ++buffer[ptr]; 
				 ++buffer[ptr]; 
				 ++buffer[ptr]; 
				 ++buffer[ptr]; 
				 while(buffer[ptr] != 0) {
				 --ptr; 
				 ++buffer[ptr]; 
				 ++buffer[ptr]; 
				 ++buffer[ptr]; 
				 ++ptr; 
				--buffer[ptr];  
				 }
				 --ptr; 
				 Console.Write(buffer[ptr]); 
				 ++buffer[ptr]; 
				 ++buffer[ptr]; 
				 ++buffer[ptr]; 
				 Console.Write(buffer[ptr]); 
				--buffer[ptr];  
				--buffer[ptr];  
				--buffer[ptr];  
				--buffer[ptr];  
				--buffer[ptr];  
				--buffer[ptr];  
				 Console.Write(buffer[ptr]); 
				--buffer[ptr];  
				--buffer[ptr];  
				--buffer[ptr];  
				--buffer[ptr];  
				--buffer[ptr];  
				--buffer[ptr];  
				--buffer[ptr];  
				--buffer[ptr];  
				 Console.Write(buffer[ptr]); 
				 while(buffer[ptr] != 0) {
				--buffer[ptr];  
				 }
				 ++ptr; 
				 ++buffer[ptr]; 
				 ++buffer[ptr]; 
				 ++buffer[ptr]; 
				 ++buffer[ptr]; 
				 ++buffer[ptr]; 
				 ++buffer[ptr]; 
				 ++buffer[ptr]; 
				 ++buffer[ptr]; 
				 while(buffer[ptr] != 0) {
				 --ptr; 
				 ++buffer[ptr]; 
				 ++buffer[ptr]; 
				 ++buffer[ptr]; 
				 ++buffer[ptr]; 
				 ++ptr; 
				--buffer[ptr];  
				 }
				 --ptr; 
				 ++buffer[ptr]; 
				 Console.Write(buffer[ptr]); 
				 while(buffer[ptr] != 0) {
				--buffer[ptr];  
				 }
				 ++buffer[ptr]; 
				 ++buffer[ptr]; 
				 ++buffer[ptr]; 
				 ++buffer[ptr]; 
				 ++buffer[ptr]; 
				 ++buffer[ptr]; 
				 ++buffer[ptr]; 
				 ++buffer[ptr]; 
				 ++buffer[ptr]; 
				 ++buffer[ptr]; 
				 Console.Write(buffer[ptr]); 
			}
	}
}

