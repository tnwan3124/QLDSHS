using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2287700095_NguyenThanhTung
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            // Tạo danh sách học sinh
            List<Student> students = new List<Student>
            {
                new Student(1, "Nguyen Van A", 16),
                new Student(2, "Tran Thi B", 18),
                new Student(3, "Le Van C", 14),
                new Student(4, "Pham Anh D", 17),
                new Student(5, "Bui Thi E", 19)
            };

            // a. In danh sách toàn bộ học sinh
            Console.WriteLine("Danh sách toàn bộ học sinh:");
            foreach (var student in students)
            {
                Console.WriteLine($"ID: {student.Id}, Name: {student.Name}, Age: {student.Age}");
            }

            Console.WriteLine("\n");

            // b. Tìm và in danh sách các học sinh có tuổi từ 15 đến 18
            Console.WriteLine("Học sinh có tuổi từ 15 đến 18:");
            var studentsAge15To18 = students.Where(s => s.Age >= 15 && s.Age <= 18).ToList();
            foreach (var student in studentsAge15To18)
            {
                Console.WriteLine($"ID: {student.Id}, Name: {student.Name}, Age: {student.Age}");
            }

            Console.WriteLine("\n");

            // c. Tìm và in ra học sinh có tên bắt đầu bằng chữ "A"
            // Tìm và in ra học sinh có tên (phần cuối cùng của chuỗi) bắt đầu bằng chữ "A"
            Console.WriteLine("Học sinh có tên bắt đầu bằng chữ 'A':");

            // Sử dụng LINQ để lọc
            var studentsWithA = students.Where(s =>
            {
                // Tách tên học sinh (phần cuối cùng sau khoảng trắng)
                string lastName = s.Name.Trim().Split(' ').Last();

                // Kiểm tra nếu tên bắt đầu bằng "A" (không phân biệt hoa/thường)
                return lastName.StartsWith("A", StringComparison.OrdinalIgnoreCase);
            }).ToList();

            // In kết quả
            if (studentsWithA.Any())
            {
                foreach (var student in studentsWithA)
                {
                    Console.WriteLine($"ID: {student.Id}, Name: {student.Name}, Age: {student.Age}");
                }
            }
            else
            {
                Console.WriteLine("Không có học sinh nào có tên bắt đầu bằng chữ 'A'.");
            }

            Console.WriteLine("\n")

            // d. Tính tổng tuổi của tất cả học sinh trong danh sách
            Console.WriteLine("Tổng tuổi của tất cả học sinh:");
            int totalAge = students.Sum(s => s.Age);
            Console.WriteLine($"Tổng tuổi: {totalAge}");

            Console.WriteLine("\n");

            // e. Tìm và in ra học sinh có tuổi lớn nhất
            Console.WriteLine("Học sinh có tuổi lớn nhất:");
            int maxAge = students.Max(s => s.Age);
            var oldestStudents = students.Where(s => s.Age == maxAge).ToList();
            foreach (var student in oldestStudents)
            {
                Console.WriteLine($"ID: {student.Id}, Name: {student.Name}, Age: {student.Age}");
            }

            Console.WriteLine("\n");

            // f. Sắp xếp danh sách học sinh theo tuổi tăng dần và in ra danh sách sau khi sắp xếp
            Console.WriteLine("Danh sách học sinh theo tuổi tăng dần:");
            var sortedStudents = students.OrderBy(s => s.Age).ToList();
            foreach (var student in sortedStudents)
            {
                Console.WriteLine($"ID: {student.Id}, Name: {student.Name}, Age: {student.Age}");
            }
        }
    }
}
