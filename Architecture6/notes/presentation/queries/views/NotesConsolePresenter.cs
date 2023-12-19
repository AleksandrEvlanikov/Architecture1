using Architecture6.notes.application.interfaces;
using Architecture6.notes.domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Architecture6.notes.presentation.queries.views
{
    internal class NotesConsolePresenter : INotesPresenter
    {
        public void PrintAll(List<Note> notes)
        {
            //if (notes != null)
            //{
            //    Console.WriteLine(notes.Count);
            //    Console.WriteLine("Лист пуст.");
            //}
            foreach (Note note in notes)
            {
                Console.WriteLine(note);
            }
            
            Console.WriteLine("Метод PrintAll");
            Console.WriteLine("-------------------------------------------------------------------------------------------------");
        }

        public void RemovOnePart(List<Note> notes)
        {
            Console.WriteLine("Введите какую запись хотите удалить: ");
            string inputNumber = Console.ReadLine();
            List<Note> listOfNoInputNum = new List<Note>();

            if (!int.TryParse(inputNumber, out int elementToCheck))
            {
                Console.WriteLine("Некорректный ввод числа.");

            }
            else if (elementToCheck > notes.Count)
            {
                Console.WriteLine("Такого значение у нас нет. Список не изменен.");
                Console.WriteLine();
                
            }
            else
            {
                foreach (Note note in notes)
                {
                    if (note.Id != elementToCheck)
                    {
                        listOfNoInputNum.Add(note);
                    }

                }
                notes.Clear();
                notes.AddRange(listOfNoInputNum);
                Console.WriteLine("Метод RemovOnePart");
                Console.WriteLine($"Удалили строку с ID = {elementToCheck}");
            }
            PrintAll(notes);

        }
    }
}
