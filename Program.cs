using System;
using System.Collections;
					
namespace Hash {
	
	class Program {
		
		static Hashtable hash;
		static List<UserInfo> user;
		
		public static void Main() {
			hash = new Hashtable();
			user = new List<UserInfo>();
			
			for(int i=0; i<8; i++){
				hash.Add(i, "user" + i);
				user.Add(new UserInfo(i, "user" + i));
			}
			
			if(hash.ContainsKey(0)){
				hash.Remove(0);
			}
			
			if(hash.ContainsKey(1)){
				hash[1] = "replacement";
			}
			
			foreach(DictionaryEntry entry in hash){
				Console.WriteLine("Key: " + entry.Key + " Value: " + entry.Value);
			}
			
		}	
	}

}
