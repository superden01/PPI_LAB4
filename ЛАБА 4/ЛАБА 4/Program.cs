using System;
using System.Reflection;

//class Example
//{
//    static void Main()
//    {
//        Type t = typeof(String);

//        MethodInfo substr = t.GetMethod("Substring",
//            new Type[] { typeof(int), typeof(int) });

//        Object result =
//            substr.Invoke("Hello, World!", new Object[] { 7, 5 });
//        Console.WriteLine("{0} returned \"{1}\".", substr, result);
//    }
//}
//class TestType
//{
//    public static void Main()
//    {
//        Type tt = typeof(int);
//        Console.WriteLine("{0} inherits from {1}.", tt, tt.BaseType);

//        foreach (var t in typeof(TestType).Assembly.GetTypes())
//        {
//            Console.WriteLine("{0} derived from: ", t.FullName);
//            var derived = t;
//            do
//            {
//                derived = derived.BaseType;
//                if (derived != null)
//                    Console.WriteLine("   {0}", derived.FullName);

//            } while (derived != null);
//            Console.WriteLine();
//        }
//    }
//}

//public class A { }

//public class B : A
//{ }

//public class C : B
//{ }
//[AttributeUsage(AttributeTargets.All)]
//public class MyAttribute : Attribute
//{
//    private string myName;
//    public MyAttribute(string name)
//    {
//        myName = name;
//    }
//    public string Name
//    {
//        get
//        {
//            return myName;
//        }
//    }
//}
//public class MyClass1
//{
//    [MyAttribute("This is an example attribute.")]
//    public void MyMethod(int i)
//    {
//        return;
//    }
//}

//public class MemberInfo_GetCustomAttributes_IsDefined
//{
//    public static void Main()
//    {
//        Type myType = typeof(MyClass1);
//        MemberInfo[] myMembers = myType.GetMembers();
//        for (int i = 0; i < myMembers.Length; i++)
//        {
//            if (myMembers[i].IsDefined(typeof(MyAttribute), false))
//            {
//                Object[] myAttributes = myMembers[i].GetCustomAttributes(typeof(MyAttribute), false);
//                Console.WriteLine(myMembers[i]);
//                for (int j = 0; j < myAttributes.Length; j++)
//                    Console.WriteLine(((MyAttribute)myAttributes[j]).Name);
//            }
//        }
//    }
//}
//class MyClass
//{
//    public static String val = "test";
//    public static void Main()
//    {
//        FieldInfo myf = typeof(MyClass).GetField("val");
//        Console.WriteLine(myf.GetValue(null));
//        val = "hi";
//        Console.WriteLine(myf.GetValue(null));

//        MyClass myInstance = new MyClass();
//        Type myType = typeof(MyClass);
//        FieldInfo[] myFields = myType.GetFields(BindingFlags.Public
//            | BindingFlags.Instance);
//        Console.WriteLine(myType);
//        for (int i = 0; i < myFields.Length; i++)
//        {
//            Console.WriteLine("The value of {0} is: {1}",
//                myFields[i].Name, myFields[i].GetValue(myInstance));
//        }
//    }

//    public string myFieldA;
//    public string myFieldB;
//    public MyClass()
//    {
//        myFieldA = "A public field";
//        myFieldB = "Another public field";
//    }
//}
public class Example
{
    static void Main()
    {
        MemberInfo m1 = typeof(Object).GetMethod("ToString");
        MemberInfo m2 = typeof(MemberInfo).GetMethod("ToString");

        Console.WriteLine("m1.DeclaringType: {0}", m1.DeclaringType);
        Console.WriteLine("m1.ReflectedType: {0}", m1.ReflectedType);
        Console.WriteLine();
        Console.WriteLine("m2.DeclaringType: {0}", m2.DeclaringType);
        Console.WriteLine("m2.ReflectedType: {0}", m2.ReflectedType);

       
    }
}