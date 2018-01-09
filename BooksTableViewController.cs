using Foundation;
using System;
using UIKit;
using System.IO
using System.Collections.Generic;
using SQLExample.Classes;

namespace SQLExample
{
    public partial class BooksTableViewController : UITableViewController
    {

        List<Book> books;

        public BooksTableViewController (IntPtr handle) : base (handle)
        {
        }

        public override void ViewDidAppear(bool animated)
        {
            base.ViewDidAppear(animated);

			string db_name = "book_db.sqlite";
			string folderPath = System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal); // Special folder that is personal to the application
			string db_path = Path.Combine(folderPath, db_name); // Sets the database filepath to the folder and file name

            books = DatabaseHelper.Read(db_path);

            TableView.ReloadData();
		}

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();

            books = new List<Book>();
        }

        public override UITableViewCell GetCell(UITableView tableView, NSIndexPath indexPath)
        {
            var cell = tableView.DequeueReusableCell("bookCell", indexPath);

            var data = books[indexPath.Row];


            return base.GetCell(tableView, indexPath);
        }

        public override nint RowsInSection(UITableView tableView, nint section)
        {
            return base.RowsInSection(tableView, section);
        }
    }
}