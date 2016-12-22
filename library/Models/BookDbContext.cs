using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace library.Models
{
    public class BookDbContext : DbContext
    {
        public DbSet<Book> Books { get; set; }
        public DbSet<Comment> Comments { get; set; }
        public DbSet<Link> Links { get; set; }
        public DbSet<BookMeta> Metas { get; set; }
    }

    public class ShopContextInitializer : DropCreateDatabaseIfModelChanges<BookDbContext>
    {
        protected override void Seed(BookDbContext context)
        {
            base.Seed(context);
            var book = new Book
            {
                Name = "Гарри Поттер и филосовский камень",
                Author = "Роулинг Д.",
                Discription = "История про мальчика-волшебника",
                Genre = "Фантастика",
            };

            AddBook(context, book, BookFormat.fb2, BookFormat.doc);
            book = new Book
            {
                Name = "Гарри Поттер и тайная комната",
                Author = "Роулинг Д.",
                Discription = "История про мальчика-волшебника",
                Genre = "Фантастика",
            };
            AddBook(context, book,BookFormat.fb2);
            book = new Book
            {
                Name = "Десять негритят",
                Author = "Кристи Агата",
                Discription = "Десять никак не связанных между собой людей в особняке на уединенном острове… Кто вызвал их сюда таинственным приглашением? Кто убивает их, одного за другим, самыми невероятными способами? Почему все происходящее так тесно переплетено с веселым детским стишком?",
                Genre = "Детектив",
            };
            AddBook(context, book, BookFormat.fb2, BookFormat.epub, BookFormat.rtf);
            book = new Book
            {
                Name = "До встречи с тобой",
                Author = "Мойес Д.",
                Discription = "Лу Кларк знает, сколько шагов от автобусной остановки до ее дома. Она знает, что ей очень нравится работа в кафе и что, скорее всего, она не любит своего бойфренда Патрика. Но Лу не знает, что вот-вот потеряет свою работу и что в ближайшем будущем ей понадобятся все силы, чтобы преодолеть свалившиеся на нее проблемы. Уилл Трейнор знает,что сбивший его мотоциклист отнял у него желание жить.И он точно знает, что надо сделат, чтобы положить конец всему этому.Но он не знает, что Лу скоро ворвется в его мир буйством красок.И они оба не знают, что навсегда изменят жизнь друг друга. ",
                Genre = "Проза",
            };
            AddBook(context, book, BookFormat.fb2, BookFormat.epub, BookFormat.rtf);
            book = new Book
            {
                Name = "В поисках Аляски",
                Author = "Грин Д.",
                Discription = "Никому, кроме собственных родителей, не интересный тощий Толстячок Майлз Холтер в романтическом поиске неизвестного, но непременно Великого «Возможно» переезжает в закрытую частную школу, где начинается настоящая жизнь: сигареты и вино, красотка Аляска и пышногрудая Лара, надежные друзья и не перестающие досаждать враги, где в воздухе витают новые идеи и чувства, где страшно жарко, но дышится полной грудью, где за пятки кусает страх – страх наказания за неповиновения правилам – и гонит вперед любовь и жажда счастья… И с этим счастьем удается соприкоснуться, но соприкоснуться всего лишь на миг,после чего приходится, едва оперившись,выходить во взрослую жизнь.",
                Genre = "Проза",
            };
            AddBook(context, book, BookFormat.fb2, BookFormat.epub, BookFormat.rtf);
            book = new Book
            {
                Name = "Ангелы и Демоны",
                Author = "Браун Д.",
                Discription = "Иллюминаты. Древний таинственный орден, прославившийся в Средние века яростной борьбой с официальной церковью. Легенда далекого прошлого ? Возможно… Но – почему тогда на груди убитого при загадочных обстоятельствах ученого вырезан именно символ иллюминатов ? Приглашенный из Гарварда специалист по символике и его напарница, дочь убитого, начинают собственное расследование – и вскоре приходят к невероятным результатам…",
                Genre = "Детектив",
            };
            AddBook(context, book, BookFormat.fb2, BookFormat.epub);
            book = new Book
            {
                Name = "Евгений Онегин",
                Author = "Пушкин А.",
                Discription = "Любовная история Татьяны Лариной и Евгения Онегина в высшей степени оригинальна и не имеет аналогов в мировой литературе. ",
                Genre = "Поэзия",
            };
            AddBook(context, book, BookFormat.fb2, BookFormat.doc);
            book = new Book
            {
                Name = "Мастер и Маргарита",
                Author = "Булгаков М.",
                Discription = "\"Мастер и Маргарита\" - бессмертное, загадочное и остроумное произведение Михаила Булгакова - главный роман его жизни. ",
                Genre = "Классика",
            };
            AddBook(context, book, BookFormat.fb2, BookFormat.doc);
            book = new Book
            {
                Name = "Обломов",
                Author = "Гончаров И.",
                Genre = "Классика",
            };
            AddBook(context, book, BookFormat.fb2, BookFormat.doc);
            book = new Book
            {
                Name = "Девушка в поезде",
                Author = "Хокинс П.",
                Discription = "Джесс и Джейсон. Такие имена дала Рейчел «безупречным» супругам, за жизнью которых она день за днем наблюдает из окна электрички. У них, похоже, есть все, чего совсем недавно лишилась сама Рейчел, – любовь, счастье, благополучие… Но однажды, проезжая мимо, она видит, как в дворике коттеджа, где живут Джесс и Джейсон, происходит нечто странное, загадочное, шокирующее.Всего минута – и поезд опять трогается, но этого достаточно, чтобы идеальная картинка исчезла навсегда. А потом – Джесс пропадает.И Рейчел понимает, что только она, возможно, способна разгадать тайну ее исчезновения.Что делать ? Примет ли полиция ее показания всерьез ? И надо ли вообще ей вмешиваться в чужую жизнь ? ",
                Genre = "Детектив",
            };
            AddBook(context, book, BookFormat.fb2, BookFormat.epub, BookFormat.rtf);
            context.SaveChanges();
        }

        private void AddBook(BookDbContext context,Book book, params BookFormat[] formats)
        {
            context.Books.Add(book);
            context.SaveChanges();
            foreach (var i in formats)
            {
                var link = new Link
                {
                    BookId = book.Id,
                    Book = System.IO.File.ReadAllBytes("Books/" + book.Name + " - " + book.Author+'.' + i.ToString())
                };
                context.Links.Add(link);
                context.SaveChanges();

                context.Metas.Add(new BookMeta
                {
                    BookId = book.Id,
                    LinkId = link.Id,
                    Format = i
                });
            }
        }
    }
}