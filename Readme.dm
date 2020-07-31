************************************************************************************************************************************************************************************************************************************************

What is this Program?

************************************************************************************************************************************************************************************************************************************************

* This program is about a Video Store that uses a database to store its information. 

* This application use C# and ADO.net technology to Display the data in the application.

* The Data in the database is Manage From the DBClass called "VideoStoreDBClass". 

* The Forms manages the GUI Controls (Graphical User Interface) like Buttons and DataGridView.

* The VideoStoreDBClass uses (CRUD operations) Create, Read, Update and Delete.

************************************************************************************************************************************************************************************************************************************************

Requirments 

************************************************************************************************************************************************************************************************************************************************
------------------------------------------------------------------------------------------------------------------------------------------------------------	
Form Features
------------------------------------------------------------------------------------------------------------------------------------------------------------
1.1 DataGridView or ListView (or Both).
1.2 Data entry text boxes or list boxes, and labels.
1.3 Buttons or Radio buttons or any other clickable event to manipulate data.
1.4 Adequate signage and titles to make it easy to understand.
------------------------------------------------------------------------------------------------------------------------------------------------------------	
Form Operations
------------------------------------------------------------------------------------------------------------------------------------------------------------
2.1 Insert a new record. Update existing records, Delete records (CRUD operations).
2.2 Show all videos.
2.3 Show just the videos that are out at present.
2.4 Add fees for the videos, if videos are older than 5 years (Release Date) then they cost $2 otherwise they cost $5.
2.5 Use A Database class to hold your SQL calls.
2.6 Issue, Charge and Return Movies.
2.7 List who borrows the most videos and List what are the most popular videos.
2.8 Create Two Unit Tests, one to test the Connection to the DB and the other of your choice.
2.9 Sanitize all your Database Changes to prevent SQL Injection. 
2.10 Use at least One Procedure.
2.11 Use at least one View to return data.
2.12 Host the Project on GitHub and send me the link.
------------------------------------------------------------------------------------------------------------------------------------------------------------	
Database Operations
------------------------------------------------------------------------------------------------------------------------------------------------------------
3.1 Tables and relationships Created and filled with data

************************************************************************************************************************************************************************************************************************************************

Log of this programme life cycle

************************************************************************************************************************************************************************************************************************************************

* Note: The Logic of the snippets of code below is repeated throughout my program, so I decided to comment on them here.

* To display the query data into the DataGridView we need to:

   	Create a new UI Table.
	
Code Snippet: Create a new UI Table
---------------------------------------------------------------------------------------------------------------------------------------------
private DataTable CreateRentedMoviesUITable()
        {
            DataTable rentedMovies = new DataTable(); // Create new UI Table called rentedMovies

            rentedMovies.Clear();  // Clear UI Table in Visual Studio

            //Create Columns for Visual Studio Table
            rentedMovies.Columns.Add("rented movies id").DataType = typeof(System.Int32); 
            rentedMovies.Columns.Add("movie ID FK");
            rentedMovies.Columns.Add("title");
            rentedMovies.Columns.Add("customer ID FK");
            rentedMovies.Columns.Add("customer first name");
            rentedMovies.Columns.Add("customer last name");
            rentedMovies.Columns.Add("date rented");
            rentedMovies.Columns.Add("date returned");
            return rentedMovies;
        }
---------------------------------------------------------------------------------------------------------------------------------------------


Read data from Colums in Server and add to the new table in visual studio.

Code Snippet: Read Data into Table
---------------------------------------------------------------------------------------------------------------------------------------------
 private DataTable ReadRentedMoviesDATA(DataTable rentedMovies)
 {
      string query = @"SELECT * FROM RentedMovies, Movies, Customer
       Where MovieID = MovieIDFK AND CustID = CustIDFK ORDER BY RMID"; //Create Query 

       SqlCommand command = new SqlCommand(query, con);

       SqlDataReader reader = command.ExecuteReader(); //  Execute  Query of the Server

        //Reading form Server
        while (reader.Read())
        {
           // read data from Colums in Server and add to the RentedMovies table in visual studio
           rentedMovies.Rows.Add(
             reader["RMID"],
             reader["MovieIDFK"],
             reader["Title"],
             reader["CustIDFK"],
             reader["FirstName"],
             reader["LastName"],
             reader["DateRented"],
             reader["DateReturned"] 
             );
  }
  reader.Close(); // Close the Data Reader
  return rentedMovies;
}
---------------------------------------------------------------------------------------------------------------------------------------------


Show Data by returning a Table (Vision Studio Table) and assign it to the DataGridView DataSource


Code Snippet: Show Data
---------------------------------------------------------------------------------------------------------------------------------------------
// Code From the DBClass "VideoStoreDBClass"

public DataTable ShowRentedMovies()
{
   con.Open(); // Open Connection to Server

   DataTable rentedMovies = CreateRentedMoviesUITable();

   rentedMovies = ReadRentedMoviesDATA(rentedMovies);

   con.Close(); // Close Connection to Server

   return rentedMovies;
}

//Code From the Form
MovieRenteddataGridView.DataSource = videoStoreDBClass.ShowRentedMovies();

---------------------------------------------------------------------------------------------------------------------------------------------

Create a New Data For the Video Store database

Code Snippet: Create 
---------------------------------------------------------------------------------------------------------------------------------------------
public void NewMovie(string rating, string title, string year, string rentalCost, string copies, string plot, string genre)
{
   // this puts the parameters into the code so that the data in the text boxes is added to the database
   string NewEntry = "INSERT INTO Movies (Rating, Title, Year, Rental_Cost, Copies, Plot, Genre)" +
                      "VALUES(@Rating, @Title, @Year, @Rental_Cost, @Copies, @Plot, @Genre)";

   using (SqlCommand newdata = new SqlCommand(NewEntry, con))
   {
        newdata.Parameters.AddWithValue("@Rating", rating);
        newdata.Parameters.AddWithValue("@Title", title);
        newdata.Parameters.AddWithValue("@Year", year);
        newdata.Parameters.AddWithValue("@Rental_Cost", rentalCost);
        newdata.Parameters.AddWithValue("@Copies", copies);
        newdata.Parameters.AddWithValue("@Plot", plot);
        newdata.Parameters.AddWithValue("@Genre", genre);

        con.Open(); //open a connection to the database

        //its a NONQuery as it doesn't return any data its only going up to the server

        newdata.ExecuteNonQuery(); //Run the Query

        con.Close(); //Close a connection to the database

        //a happy message box
	MessageBox.Show("New Movie added to database!! ");
   }
}
---------------------------------------------------------------------------------------------------------------------------------------------


Update existing Data From the Video Store database

Code Snippet: Update 
---------------------------------------------------------------------------------------------------------------------------------------------
public void UpdateMovie(int movieID, string rating, string title, string year, string rentalCost, string copies, string plot, string genre)
{
    // this puts the parameters into the code so that the data in the text boxes is added to the database
    string updatestatement = "UPDATE Movies set Rating=@Rating, Title=@Title, Year=@Year, Rental_Cost=@Rental_Cost," +
                              "Copies=@Copies, Plot=@Plot, Genre=@Genre where MovieID = @MovieID";

    using (SqlCommand update = new SqlCommand(updatestatement, con))
    {
          update.Parameters.AddWithValue("@MovieID", movieID.ToString());
          update.Parameters.AddWithValue("@Rating", rating);
          update.Parameters.AddWithValue("@Title", title);
          update.Parameters.AddWithValue("@Year", year);
          update.Parameters.AddWithValue("@Rental_Cost", rentalCost);
          update.Parameters.AddWithValue("@Copies", copies);
          update.Parameters.AddWithValue("@Plot", plot);
          update.Parameters.AddWithValue("@Genre", genre);

          con.Open(); //open a connection to the database

          //its a NONQuery as it doesn't return any data its only going up to the server

          update.ExecuteNonQuery(); //Run the Query

          con.Close(); //Close a connection to the database

          //a happy message box
	  MessageBox.Show("Existing movie is edited!! ");
   }
}
---------------------------------------------------------------------------------------------------------------------------------------------



Delete existing Data From the Video Store database

Code Snippet: Delete 
---------------------------------------------------------------------------------------------------------------------------------------------
 public void DeleteMovie(int movieID)
 {
    // a simple Scalar query just returning one value.
    string queryString = "SELECT COUNT(MovieIDFK) FROM RentedMovies Where MovieIDFK = " + movieID;

    string numMovie = "";
    using (SqlConnection con2 = new SqlConnection(conString))
    {
       SqlCommand Command1 = new SqlCommand(queryString, con2);
       con2.Open();
       numMovie = Command1.ExecuteScalar().ToString();
       con2.Close();
    }
    // Check if data exist in other tables before Deleting
    if (Convert.ToInt32(numMovie) == 0)
    {
       // if data doesn't exist in other tables then Delete data
       // a simple Scalar query just returning one value.
       string queryDelete = "Delete Movies Where MovieID = " + movieID;

       using (SqlConnection con3 = new SqlConnection(conString))
       {
          SqlCommand Command = new SqlCommand(queryDelete, con3);
          con3.Open();
          Command.ExecuteNonQuery();
          con3.Close();
	  MessageBox.Show("Existing movie is deleted from database!!");
       }
    } else if (Convert.ToInt32(numMovie) > 0) { 
	 /* if data does exist: inform user of exist data in other tables*/  
       MessageBox.Show("First need to remove this movie from Movie Rental", "caption", MessageBoxButtons.OK, MessageBoxIcon.Error);
   }
}
---------------------------------------------------------------------------------------------------------------------------------------------



*********************************************************************************************************************************************************************************************       

About the UI

*********************************************************************************************************************************************************************************************        

* I use the menuStrip to navigate from one form to the next.



* Buttons Naming Convention:

* The button with New in their name will create a new record. 

* The button with Update in their name will edit record.

* The button with Delete in their name will Remove record.

* Note: Customer and/or Movie can only be removed if they don't exist in Rented Movies.

* Note: The required fields must be field in before user can create new or update existing entry.

* Note: User must select customer and movie from each form (Customer form and Movies form) before a new Rented Movies can be Created.




Code Snippet: How to display data in the datagridview?
---------------------------------------------------------------------------------------------------------------------------------------------
VideoStoreDBClass videoStoreDBClass = new VideoStoreDBClass();

public MoviesForm()
{
     InitializeComponent();

     // add the newly created visual studio table to the DataGridView
     MovieRenteddataGridView.DataSource = videoStoreDBClass.ShowMovies();
}

---------------------------------------------------------------------------------------------------------------------------------------------

* How to display selected data from datagridview using row and event.

source: https://stackoverflow.com/questions/11260843/getting-data-from-selected-datagridview-row-and-which-event

Code Snippet: Display selected data from datagridview
---------------------------------------------------------------------------------------------------------------------------------------------
private void MoviesdataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
{
	MessageBox.Show("CEll Double_Click event calls");

	int rowIndex = e.RowIndex; // Get selected Row index
	DataGridViewRow row = MoviesdataGridView.Rows[rowIndex]; // Get selected Row using row index
	
	// Get data from DataGridView from each cell in the row and assing data to textbox
	txtbxMovieTitle.Text = row.Cells[0].Value.ToString();
}

--------------------------------------------------------------------------------------------------------------------------------------------

* The only down side to this code is you must select the value in column for this event to execute
* and retrive the data to be displayed on the textbox.

* Note: "The fix to this is CellClick event and wrap your code
* in a try catch to stop the errors when clicking just outside the cell, for example in the
* header." (The Vision College Instation Manual for the Practice Golf Project ADO.net, 22 May 2019)


Code Snippet: Fix snippet of code ("Display selected data from datagridview")
---------------------------------------------------------------------------------------------------------------------------------------------
int MovieIndex = 0; 
private void MoviesdataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
{
     try{
     	   int rowIndex = e.RowIndex; // Get selected Row index
    	   DataGridViewRow row = MoviesdataGridView.Rows[rowIndex]; // Get selected Row using row index
           
           // Get data from DataGridView from each cell in the row and assing data to UI elements
     	   MovieIndex = Convert.ToInt32(row.Cells[0].Value);
     	   txtbxMovieTitle.Text = row.Cells[2].Value.ToString();
     	   txtbxYear.Text = row.Cells[3].Value.ToString();
     	   txtbxGenre.Text = row.Cells[7].Value.ToString();
     	   txtbxRating.Text = row.Cells[1].Value.ToString();
     	   txtbxRentalCost.Text = row.Cells[4].Value.ToString();
     	   txtbxCopies.Text = row.Cells[5].Value.ToString();
     	   txtbxPlot.Text = row.Cells[6].Value.ToString();
      } catch{
           
      }
}
---------------------------------------------------------------------------------------------------------------------------------------------


* On Clicking this button, a New movie will be created if all the required fields are filled in.


Code Snippet: button New Movie
---------------------------------------------------------------------------------------------------------------------------------------------
private void btnNewMovie_Click(object sender, EventArgs e)
{
    if (txtbxMovieTitle.Text != "" && txtbxRating.Text != "" && txtbxYear.Text != "" && txtbxRentalCost.Text != "" && txtbxCopies.Text != "" && txtbxPlot.Text != "" && txtbxGenre.Text != "") 
    {
        videoStoreDBClass.NewMovie(txtbxRating.Text, txtbxMovieTitle.Text, txtbxYear.Text, txtbxRentalCost.Text, txtbxCopies.Text, txtbxPlot.Text, txtbxGenre.Text);
        MoviesdataGridView.DataSource = videoStoreDBClass.ShowMovies();
    } else {
      MessageBox.Show("There can't be empty textboxes");
    }
}
---------------------------------------------------------------------------------------------------------------------------------------------

* On Clicking this button, The movie will be edited if all the required fields are filled in.


Code Snippet: button Update Movie
---------------------------------------------------------------------------------------------------------------------------------------------
private void btnUpdateMovie_Click(object sender, EventArgs e)
{
   if (txtbxMovieTitle.Text != "" && txtbxRating.Text != "" && txtbxYear.Text != "" && txtbxRentalCost.Text != "" && txtbxCopies.Text != "" && txtbxPlot.Text != "" && txtbxGenre.Text != "")
   {
       videoStoreDBClass.UpdateMovie(movieIndex, txtbxRating.Text, txtbxMovieTitle.Text, txtbxYear.Text, txtbxRentalCost.Text, txtbxCopies.Text, txtbxPlot.Text, txtbxGenre.Text);
       MoviesdataGridView.DataSource = videoStoreDBClass.ShowMovies();
   } else{
     MessageBox.Show("There can't be empty textboxes");
   }
            btnUpdateMovie.Enabled = false;
}
---------------------------------------------------------------------------------------------------------------------------------------------


* On Clicking this button, The movie will be removed from the database.

Code Snippet: button Delete Movie
---------------------------------------------------------------------------------------------------------------------------------------------
private void btnDeleteMovie_Click(object sender, EventArgs e)
{
   videoStoreDBClass.DeleteMovie(movieIndex);
   MoviesdataGridView.DataSource = videoStoreDBClass.ShowMovies();
   btnDeleteMovie.Enabled = false;
}
---------------------------------------------------------------------------------------------------------------------------------------------

*********************************************************************************************************************************************************************************************************************************************** 
*********************************************************************************************************************************************************************************************************************************************** 





 

        

       



