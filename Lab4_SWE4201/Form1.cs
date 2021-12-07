using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab4_SWE4201
{
    public partial class Form1 : Form
    {
        
        List<StudyBooks> listofbooks = new List<StudyBooks>();
        List<ResearchArticle> researchArticles = new List<ResearchArticle>();

        public Form1()
        {
            InitializeComponent();
        }

        private void AddBook_Click(object sender, EventArgs e)
        {
            string bookid = BID.Text;
            string btitle = BTitle.Text;
            string bauthor = BAth.Text;
            string bpublisher  = BPublisher.Text;
            int bq = Convert.ToInt32(BQuantity.Text);
            string bisbn = ISBNtxtbox.Text;
            string bgen = Genre.Text;
            StudyBooks studybooks = new StudyBooks();
            studybooks.ID = bookid;
            studybooks.Title = btitle;  
            studybooks.Author = bauthor;
            studybooks.Publisher = bpublisher;
            studybooks.quantity = bq;
            studybooks.ISBN = bisbn;
            studybooks.genre = bgen;

            listofbooks.Add(studybooks);
            MessageBox.Show("This book has been added");
        }

        private void AddArticle_Click(object sender, EventArgs e)
        {

            string aid = ArtID.Text;
            string atitle = ArtTitle.Text;
            string Aauthor = ArtAth.Text;
            string Apublisher = ArtPublisher.Text;
            int aq = Convert.ToInt32(ArtQ.Text);
            string Adoi = DOI.Text;
            string ADate = Datetxtbox.Text;
            string aCJ = CJtxtbox.Text;
            ResearchArticle article = new ResearchArticle();
            article.ID = aid;
            article.Title = atitle;
            article.Author = Aauthor;
            article.Publisher = Apublisher;
            article.quantity = aq;
            article.doi = Adoi;
            article.date = ADate;
            article.cj = aCJ;

            researchArticles.Add(article);
            MessageBox.Show("This article has been added");
        }

        private void BorrowBook_Click(object sender, EventArgs e)
        {
            string bookidforborrow = Bookidborrow.Text;
            foreach( StudyBooks book in listofbooks)
            {
                if(bookidforborrow == book.ID)
                {
                    if(book.quantity <= 0)
                    {
                        MessageBox.Show("This book can not be borrowed.");
                    }
                    else
                    {
                        book.quantity--;
                    }
                }
            }
        }

        private void BorrowArticle_Click(object sender, EventArgs e)
        {
            string articleidforborrow = AIDBorrow.Text;
            foreach (ResearchArticle Article in researchArticles)
            {
                if (articleidforborrow == Article.ID)
                {
                    if (Article.quantity <= 0)
                    {
                        MessageBox.Show("This book can not be borrowed.");
                    }
                    else
                    {
                        Article.quantity--;
                    }
                }
            }
        }

        private void ShowBook_Click(object sender, EventArgs e)
        {
            ListofBooks.Items.Clear();
            foreach(StudyBooks Book in listofbooks)
            {
                ListofBooks.Items.Add(Book.getbookinfo());
            }
        }

        private void ShowArt_Click(object sender, EventArgs e)
        {
            ListofArticles.Items.Clear();
            foreach(ResearchArticle ARTICLE in researchArticles)
            {
                ListofArticles.Items.Add(ARTICLE.getarticleinfo());
            }
        }
    }
}
