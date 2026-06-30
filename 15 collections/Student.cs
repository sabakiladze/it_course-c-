using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15_collections
{
    internal class Student
    {
        private static int _idCounter = 0;
        public int Id { get; }
        private string _name;
        public Student(string na)
        {
            Name = na;
            _idCounter++;
            Id=_idCounter;
        }
        public String Name
        {
            get { return _name; }
            set
            {
                if(string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("invalid input");
                }
                _name = value;
            }
        }
    }
}

// სახელი უნდა ყოფილიყო key დიქშენერიში, მაგრამ რადგან შეიძ₾ება
// რომ ერთი სახელის ორი ობიექტი ყოფილიყო ერთნაირი ქულებით, რომ
// არ არეულიყო მოძებნიასა, სტუდენტის კლაში შემოვიტანე და მოძებნა id -ით გავაკეთე
// თან უფრო გართულდასავით კოდი და პრაქტიკაშიც ჩამეთვალა.

// p.s ისე დავიღალე რომ ბოლომდე ვეღარ გავტესტე და იმედია ყველაფერი სწორადაა, ძირითადები მაინც შევამოწმე.  ;))