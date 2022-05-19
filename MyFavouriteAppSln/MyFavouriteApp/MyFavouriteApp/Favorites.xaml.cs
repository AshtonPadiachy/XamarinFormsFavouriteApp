using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MyFavouriteApp
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Favorites : ContentPage
    {
        private List<FavouriteBooks> _books = new List<FavouriteBooks>();

        public List<FavouriteBooks> Books
        { 

            get { return _books; }

            set { _books = value; }

        }
        public Favorites()
        {
            InitializeComponent();

            var book = new FavouriteBooks();
            book.TitleOfBook = "Pokemon Adventures";
            book.ChapterNumbers = 436;
            book.LatestUpdate = new DateTime(2021, 03, 07);
            book.NameofImage = "pokespec.png";

            Books.Add(book);

            book = new FavouriteBooks();
            book.TitleOfBook = "Demon Slayer";
            book.ChapterNumbers = 205;
            book.LatestUpdate = new DateTime(2022, 03, 25);
            book.NameofImage = "demon.png";

            Books.Add(book);

            book = new FavouriteBooks();
            book.TitleOfBook = "Sweet Home";
            book.ChapterNumbers = 142;
            book.LatestUpdate = new DateTime(2020, 09, 03);
            book.NameofImage = "sweethome.png";

            Books.Add(book);

            book = new FavouriteBooks();
            book.TitleOfBook = "My Hero Academia";
            book.ChapterNumbers = 350;
            book.LatestUpdate = new DateTime(2022, 04, 08);
            book.NameofImage = "hero.png";

            Books.Add(book);

            book = new FavouriteBooks();
            book.TitleOfBook = "Black Clover";
            book.ChapterNumbers = 331;
            book.LatestUpdate = new DateTime(2022, 04, 26);
            book.NameofImage = "blackclover.png";

            Books.Add(book);

            book = new FavouriteBooks();
            book.TitleOfBook = "Toilet-Bound Hanako-kun";
            book.ChapterNumbers = 89;
            book.LatestUpdate = new DateTime(2022, 04, 18);
            book.NameofImage = "hanako.png";

            Books.Add(book);

            book = new FavouriteBooks();
            book.TitleOfBook = "Haikyuu!!";
            book.ChapterNumbers = 402;
            book.LatestUpdate = new DateTime(2022, 04, 26);
            book.NameofImage = "hq.png";

            Books.Add(book);

            book = new FavouriteBooks();
            book.TitleOfBook = "Blue Exorcist";
            book.ChapterNumbers = 132;
            book.LatestUpdate = new DateTime(2022, 04, 18);
            book.NameofImage = "blue.png";

            Books.Add(book);

            book = new FavouriteBooks();
            book.TitleOfBook = "Solo Leveling";
            book.ChapterNumbers = 175;
            book.LatestUpdate = new DateTime(2022, 04, 18);
            book.NameofImage = "solo.png";

            Books.Add(book);

            book = new FavouriteBooks();
            book.TitleOfBook = "Yona Of The Dawn";
            book.ChapterNumbers = 224;
            book.LatestUpdate = new DateTime(2022, 04, 18);
            book.NameofImage = "yona.png";

            Books.Add(book);

            book = new FavouriteBooks();
            book.TitleOfBook = "Blue Lock";
            book.ChapterNumbers = 172;
            book.LatestUpdate = new DateTime(2022, 04, 18);
            book.NameofImage = "lock.png";

            Books.Add(book);

            BindingContext = this;
        }
    }
}