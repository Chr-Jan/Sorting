using Sorting.Models;

namespace Sorting.Data
{
    public class SeedData
    {
        private static List<Human> humans;

        static SeedData()
        {
            humans = new List<Human>
            {
                new Human { Id = 1, Name = "John", Age = 25, Dashing = true },
                new Human { Id = 2, Name = "Alice", Age = 30, Dashing = false },
                new Human { Id = 3, Name = "Bob", Age = 22, Dashing = true },
                new Human { Id = 4, Name = "Eva", Age = 28, Dashing = false },
                new Human { Id = 5, Name = "Charlie", Age = 35, Dashing = true },
                new Human { Id = 6, Name = "Diana", Age = 27, Dashing = false },
                new Human { Id = 7, Name = "Frank", Age = 31, Dashing = true },
                new Human { Id = 8, Name = "Grace", Age = 24, Dashing = false },
                new Human { Id = 9, Name = "Henry", Age = 29, Dashing = true },
                new Human { Id = 10, Name = "Ivy", Age = 33, Dashing = false },
                new Human { Id = 11, Name = "Jack", Age = 26, Dashing = true },
                new Human { Id = 12, Name = "Kelly", Age = 32, Dashing = false },
                new Human { Id = 13, Name = "Leo", Age = 23, Dashing = true },
            };
        }

        public static List<Human> GetHumans()
        {
            return humans;
        }

        public static List <Human> SortByName(bool ascending = true)
        {
            if(ascending)
            {
                return humans.OrderBy(humans => humans.Name).ToList();
            }
            else
            {
                return humans.OrderByDescending(humans=> humans.Name).ToList();
            }
        }

        public static List <Human> SortByAge(bool ascending = true)
        {
            if(ascending)
            {
                return humans.OrderBy(humans => humans.Age).ToList();
            }
            else
            {
                return humans.OrderByDescending(humans => humans.Age).ToList();
            }
        }
    }
}
