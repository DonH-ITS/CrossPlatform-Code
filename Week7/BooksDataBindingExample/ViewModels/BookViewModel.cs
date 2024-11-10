

using System.Collections.ObjectModel;

namespace DataBindingLecture
{
    public class BookViewModel
    {
        public ObservableCollection<Book> Books { get; set; }
        private int _id = 4;

      public BookViewModel() {
            Books = new ObservableCollection<Book>
              {
              new Book { Id = 1, Title = "The Great Gatsby", Author = "F. Scott Fitzgerald", PublishedYear = 1925 },
              new Book { Id = 2, Title = "1984", Author = "George Orwell", PublishedYear = 1949 },
              new Book { Id = 3, Title = "To Kill a Mockingbird", Author = "Harper Lee", PublishedYear = 1960 }
              };
        }

        public void AddBooks(string title, string author, int year) {
            Books.Add(new Book { Id = _id++, Title = title, Author = author, PublishedYear = year });
        }
    }
}
