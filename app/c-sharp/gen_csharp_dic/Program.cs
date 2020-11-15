using System;
using System.Diagnostics;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;
using System.Runtime.Remoting.Channels;

namespace GenCsharpDic
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Assembly mscorlib_debug = typeof(System.Diagnostics.Debug).Assembly;
            Assembly mscorlib = typeof(string).Assembly;

            var generator = new DictionaryGenerator();
            generator.Append(mscorlib_debug.GetTypes());
            generator.Append(mscorlib.GetTypes());
            foreach (var item in generator.hidemaru_dictionary)
            {
                Console.WriteLine(item);
            }
        }
    }

    class DictionaryGenerator{
        public SortedSet<String> hidemaru_dictionary { get; }

		public DictionaryGenerator()
		{
            hidemaru_dictionary = new SortedSet<String>();
        }
        public void Append(Type[] types)
		{
            foreach (var t in types) {
                AppendMethods(t);
                Append(t.GetNestedTypes());
            }			
        }
        
        static bool isDictChars(char s)
		{
            if(('0'<=s) && (s <= '9'))
			{
                return true;
			}
            if (('A' <= s) && (s <= 'Z'))
            {
                return true;
            }
            if (('a' <= s) && (s <= 'z'))
            {
                return true;
            }
			if ((s == '_') || (s == '.'))
			{
                return true;
			}
            return false;
		}

        static bool isIdentifier(string s)
		{
            return s.All(c => isDictChars(c));
		}

        void AppendMethods(Type t)
        {
			if (! isIdentifier(t.FullName))
			{
                return;
			}
            
#if false
            foreach(var prop in t.GetProperties(BindingFlags.Public | BindingFlags.Static))
			{
                Console.WriteLine(t.FullName + "." + prop.Name);
			}
#endif

#if true
            if (t.IsEnum)
            {
                foreach (var enumName in t.GetEnumNames())
                {
                    if (! isIdentifier(enumName))
					{
                        continue;
					}
                    var fullName = t.FullName + "." + enumName;
                    hidemaru_dictionary.Add(fullName);
                }
            }
#endif   

            //メソッドの一覧を取得する
            MethodInfo[] methods = t.GetMethods(
                BindingFlags.Public | 
                //BindingFlags.NonPublic |
                //BindingFlags.Instance | 
                BindingFlags.Static);
            foreach (MethodInfo m in methods)
            {
                //特別な名前のメソッドは表示しない
                if (m.IsSpecialName)
                    continue;
                if (!m.IsPublic)
                    continue;

#if false
                //アクセシビリティを表示
                //ここではIs...プロパティを使っているが、
                //Attributesプロパティを調べても同じ
                if (m.IsPublic)
                    Console.Write("public ");
                if (m.IsPrivate)
                    Console.Write("private ");
                if (m.IsAssembly)
                    Console.Write("internal ");
                if (m.IsFamily)
                    Console.Write("protected ");
                if (m.IsFamilyOrAssembly)
                    Console.Write("internal protected ");
#endif

#if false
                //その他修飾子を表示
                if (m.IsStatic)
                    Console.Write("static ");
                if (m.IsAbstract)
                    Console.Write("abstract ");
                else if (m.IsVirtual)
                    Console.Write("virtual ");
#endif

#if false
                //戻り値を表示
                if (m.ReturnType == typeof(void))
                    Console.Write("void ");
                else
                    Console.Write(m.ReturnType.ToString() + " ");
#endif

				if (! isIdentifier(m.Name))
				{
                    continue;
				}
                //メソッド名を表示
                var fullName = t.FullName + "." + m.Name;            
                hidemaru_dictionary.Add(fullName);                    
            
#if false
                //パラメータを表示
                ParameterInfo[] prms = m.GetParameters();
                Console.Write("(");
                for (int i = 0; i < prms.Length; i++)
                {
                    ParameterInfo p = prms[i];
                    Console.Write(p.ParameterType.ToString() + " " + p.Name);
                    if (prms.Length - 1 > i)
                        Console.Write(", ");
                }
                Console.Write(")");
#endif
                
            }
        }

    }
    
}
