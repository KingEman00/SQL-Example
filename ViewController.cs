using System;
using System.IO;
using SQLExample.Classes;
using UIKit;

namespace SQLExample
{
    public partial class ViewController : UIViewController
    {
        protected ViewController(IntPtr handle) : base(handle)
        {
            // Note: this .ctor should not contain any initialization logic.
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();
            // Perform any additional setup after loading the view, typically from a nib.

            buttonSave.TouchUpInside += ButtonSave_TouchUpInside; // Call method when save button is pressed
        }

        void ButtonSave_TouchUpInside(object sender, EventArgs e) // Method that runs when user clicks on save button
        {
            string db_name = "book_db.sqlite";
            string folderPath = System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal); // Special folder that is personal to the application
            string db_path = Path.Combine(folderPath, db_name); // Sets the database filepath to the folder and file name

            Book newBook = new Book() // Give each new book the title and name gathered from the .text of the inputs
            {
                Author = txtBookAuthor.Text,
                Name = txtBookTitle.Text
            };

            if (DatabaseHelper.Insert(ref newBook, db_path)) // If there is a new book to be added add it
                Console.WriteLine("SUCCESS"); // LOG SUCCESS if all works
            else
                Console.WriteLine("FAILURE"); // LOG FAILURE if something doesn't work


        }

        public override void DidReceiveMemoryWarning()
        {
            base.DidReceiveMemoryWarning();
            // Release any cached data, images, etc that aren't in use.
        }
    }
}
