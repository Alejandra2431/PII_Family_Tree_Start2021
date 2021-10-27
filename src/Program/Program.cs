using System;
using Library;
using System.Collections.Generic;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            Persona persona1 = new Persona("Juan1", 22);
            Persona persona2 = new Persona("Juan2", 22);
            Persona persona3 = new Persona("Juan3", 22);
            Persona persona4 = new Persona("Juan4", 22);
            Persona persona5 = new Persona("Juan5", 22);
            Persona persona6 = new Persona("Juan6", 22);
            Persona persona7 = new Persona("Juan7", 22);
            Persona persona8 = new Persona("Juan8", 22);

            Node n1 = new Node(persona1);
            Node n2 = new Node(persona2);
            Node n3 = new Node(persona3);
            Node n4 = new Node(persona4);
            Node n5 = new Node(persona5);
            Node n6 = new Node(persona6);
            Node n7 = new Node(persona7);
            Node n8 = new Node(persona8);

            n1.AddChildren(n2);
            n1.AddChildren(n3);

            n2.AddChildren(n4);
            n2.AddChildren(n5);

            n3.AddChildren(n6);
            n3.AddChildren(n7);
            n3.AddChildren(n8);

            // visitar el árbol aquí
            Visitor visitor = new Visitor();
            n1.Accept(visitor);
            Console.Write(visitor.SumaEdades(n1));
            
        }
    }
}
