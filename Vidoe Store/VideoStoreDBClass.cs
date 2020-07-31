using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vidoe_Store
{
    public class VideoStoreDBClass
    {
        private readonly string conString = @"Data Source=MSI\SQLEXPRESS;Initial Catalog=VideoStoreDB;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
        private readonly SqlConnection con; // create connection

        public static int CustomerID;
        public static string FirstName;
        public static string LastName;
        public static int MovieID;
        public static string MovieTitle;

        public VideoStoreDBClass()
        {
            con = new SqlConnection(conString);
        }

        public string ReturnDBName()
        {
            return con.Database;
        }

        public ConnectionState ReturnDBConnectionState()
        {
            return con.State;
        }

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

        public DataTable ShowRentedMovies()
        {

            con.Open(); // Open Connection to Server

            DataTable rentedMovies = CreateRentedMoviesUITable();

            rentedMovies = ReadRentedMoviesDATA(rentedMovies);

            con.Close(); // Close Connection to Server

            return rentedMovies;
        }

        private DataTable CreateMoviesUITable()
        {
            DataTable movies = new DataTable(); // Create new UI Table called movies

            movies.Clear();  // Clear UI Table in Visual Studio

            //Create Columns for Visual Studio Table
            movies.Columns.Add("movie id").DataType = typeof(System.Int32);
            movies.Columns.Add("rating");
            movies.Columns.Add("title");
            movies.Columns.Add("year");
            movies.Columns.Add("rental cost");
            movies.Columns.Add("copies");
            movies.Columns.Add("plot");
            movies.Columns.Add("genre");
            return movies;
        }
        private DataTable ReadMoviesDATA(DataTable movies)
        {
            string query = @"Select * From Movies ORDER BY MovieID"; //Create Query 

            SqlCommand command = new SqlCommand(query, con);

            SqlDataReader reader = command.ExecuteReader(); //  Execute  Query of the Server

            //Reading form Server
            while (reader.Read())
            {
                // read data from Colums in Server and add to the movies table in visual studio
                movies.Rows.Add(
                    reader["MovieID"],
                    reader["Rating"],
                    reader["Title"],
                    reader["Year"],
                    reader["Rental_Cost"],
                    reader["Copies"],
                    reader["Plot"],
                    reader["Genre"]
                    );
            }
            reader.Close(); // Close the Data Reader
            return movies;
        }

        public DataTable ShowMovies()
        {

            con.Open(); // Open Connection to Server

            DataTable movies = CreateMoviesUITable();

            movies = ReadMoviesDATA(movies);

            con.Close(); // Close Connection to Server

            return movies;
        }

        private DataTable CreateCustomerUITable()
        {
            DataTable customer = new DataTable(); // Create new UI Table called customer

            customer.Clear();  // Clear UI Table in Visual Studio

            //Create Columns for Visual Studio Table
            customer.Columns.Add("customer id").DataType = typeof(System.Int32); ;
            customer.Columns.Add("first name");
            customer.Columns.Add("last name");
            customer.Columns.Add("address");
            customer.Columns.Add("phone");
            return customer;
        }

        private DataTable ReadCustomerDATA(DataTable customer)
        {
            string query = @"Select * From Customer ORDER BY CustID"; //Create Query 

            SqlCommand command = new SqlCommand(query, con);

            SqlDataReader reader = command.ExecuteReader(); //  Execute  Query of the Server

            //Reading form Server
            while (reader.Read())
            {
                // read data from Colums in Server and add to the customer table in visual studio
                customer.Rows.Add(
                    reader["CustID"],
                    reader["FirstName"],
                    reader["LastName"],
                    reader["Address"],
                    reader["Phone"]
                    );
            }
            reader.Close(); // Close the Data Reader
            return customer;
        }

        public DataTable ShowCustomer()
        {
            con.Open(); // Open Connection to Server

            DataTable customer = CreateCustomerUITable();

            customer = ReadCustomerDATA(customer);

            con.Close(); // Close Connection to Server

            return customer;
        }

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
                MessageBox.Show("New Movie is added to database!! ");
            }
        }

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
                MessageBox.Show("Movie is edited!! ");
            }
        }

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

                    //a happy message box
                    MessageBox.Show("Movie is deleted from database!! ");
                }
            } else if (Convert.ToInt32(numMovie) > 0) {
                /* if data does exist: inform user of exist data in other tables*/
                MessageBox.Show("First need to remove this movie from Movie Rental", "caption", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void NewCustomer(string firstname, string lastname, string address, string phone)
        {

            // this puts the parameters into the code so that the data in the text boxes is added to the database

            string NewEntry = "INSERT INTO Customer (FirstName, LastName, Address, Phone)" +
                "VALUES(@FirstName, @LastName, @Address, @Phone)";

            using (SqlCommand newdata = new SqlCommand(NewEntry, con))
            {

                newdata.Parameters.AddWithValue("@FirstName", firstname);
                newdata.Parameters.AddWithValue("@LastName", lastname);
                newdata.Parameters.AddWithValue("@Address", address);
                newdata.Parameters.AddWithValue("@Phone", phone);

                con.Open(); //open a connection to the database

                //its a NONQuery as it doesn't return any data its only going up to the server
                newdata.ExecuteNonQuery(); //Run the Query

                con.Close(); //Close a connection to the database

                //a happy message box
                MessageBox.Show("New customer is added to database!! ");
            }
        }
        public void UpdateCustomer(int customerID, string firstname, string lastname, string address, string phone)
        {

            // this puts the parameters into the code so that the data in the text boxes is added to the database
            string updatestatement = "UPDATE Customer set FirstName=@FirstName, LastName=@LastName, Address=@Address, Phone=@Phone Where CustID = @CustomerID";

            using (SqlCommand update = new SqlCommand(updatestatement, con))
            {
                update.Parameters.AddWithValue("@CustomerID", customerID.ToString());
                update.Parameters.AddWithValue("@FirstName", firstname);
                update.Parameters.AddWithValue("@LastName", lastname);
                update.Parameters.AddWithValue("@Address", address);
                update.Parameters.AddWithValue("@Phone", phone);
                
                con.Open(); //open a connection to the database

                //its a NONQuery as it doesn't return any data its only going up to the server
                update.ExecuteNonQuery(); //Run the Query

                con.Close(); //Close a connection to the database

                //a happy message box
                MessageBox.Show("Customer is edited!! ");
            }
        }

        public void DeleteCustomer(int customerID)
        {
            // a simple Scalar query just returning one value.
            string queryString = "SELECT COUNT(CustIDFK) FROM RentedMovies Where CustIDFK = " + customerID;

            string numCust = "";
            using (SqlConnection con2 = new SqlConnection(conString))
            {
                SqlCommand Command1 = new SqlCommand(queryString, con2);
                con2.Open();
                numCust = Command1.ExecuteScalar().ToString();
                con2.Close();
            }
            if (Convert.ToInt32(numCust) == 0) { 
                // a simple Scalar query just returning one value.
                string queryDelete = "Delete Customer Where CustID = " + customerID;

                using (SqlConnection con3 = new SqlConnection(conString))
                {
                    SqlCommand Command = new SqlCommand(queryDelete, con3);
                    con3.Open();
                    Command.ExecuteNonQuery();
                    con3.Close();
                    MessageBox.Show("Customer is deleted from database!! ");
                }
            }else if (Convert.ToInt32(numCust) > 0){
                MessageBox.Show("First need to remove this customer from Movie Rental", "caption", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void NewMovieRented(string movieIDFK, string custIDFK, DateTime dateRented)
        {
            // a simple Scalar query just returning one value.
            string queryString1 = "SELECT COUNT(MovieID) FROM Movies Where MovieID = " + ((movieIDFK == "") ? "0" : movieIDFK);

            string numMovies = "";
            using (SqlConnection con1 = new SqlConnection(conString))
            {
                SqlCommand Command1 = new SqlCommand(queryString1, con1);
                con1.Open();
                numMovies = Command1.ExecuteScalar().ToString();
                con1.Close();
            }

            // a simple Scalar query just returning one value.
            string queryString2 = "SELECT COUNT(CustID) FROM Customer Where CustID =" + ((custIDFK == "") ? "0" : custIDFK);

            string numCust = "";
            using (SqlConnection con2 = new SqlConnection(conString))
            {
                SqlCommand Command2 = new SqlCommand(queryString2, con2);
                con2.Open();
                numCust = Command2.ExecuteScalar().ToString();
                con2.Close();
            }

            // Check if the Customer and Movie Exists 
            if (Convert.ToInt32(numMovies) > 0 && Convert.ToInt32(numCust) > 0)
            {
                //MessageBox.Show(dateReturned.ToString());

                // this puts the parameters into the code so that the data in the text boxes is added to the database

                string NewEntry = "INSERT INTO RentedMovies (MovieIDFK, CustIDFK, DateRented)" +
                    "VALUES(@MovieIDFK, @CustIDFK, @DateRented)";

                using (SqlCommand newdata = new SqlCommand(NewEntry, con))
                {
                    newdata.Parameters.AddWithValue("@MovieIDFK", movieIDFK);
                    newdata.Parameters.AddWithValue("@CustIDFK", custIDFK);
                    newdata.Parameters.AddWithValue("@DateRented", dateRented);
                    //newdata.Parameters.AddWithValue("@DateReturned", DBNull.Value);

                    con.Open(); //open a connection to the database

                    //its a NONQuery as it doesn't return any data its only going up to the server
                    newdata.ExecuteNonQuery(); //Run the Query

                    con.Close(); //Close a connection to the database

                    //a happy message box
                    MessageBox.Show("New rented movie is added to database!! ");
                }
            }else {
                MessageBox.Show("The customer or movie doesn't exist in the database");
            }
        }

        public void UpdateMovieRented(int rentedMovieID, string movieIDFK, string custIDFK, DateTime dateRented, DateTime dateReturned)
        {
            // a simple Scalar query just returning one value.
            string queryString1 = "SELECT COUNT(MovieID) FROM Movies Where MovieID =" + ((movieIDFK == "") ? "0" : movieIDFK);

            string numMovies = "";
            using (SqlConnection con1 = new SqlConnection(conString))
            {
                SqlCommand Command1 = new SqlCommand(queryString1, con1);
                con1.Open();
                numMovies = Command1.ExecuteScalar().ToString();
                con1.Close();
            }

            // a simple Scalar query just returning one value.
            string queryString2 = "SELECT COUNT(CustID) FROM Customer Where CustID =" + ((custIDFK == "") ? "0" : custIDFK);

            string numCust = "";
            using (SqlConnection con2 = new SqlConnection(conString))
            {
                SqlCommand Command2 = new SqlCommand(queryString2, con2);
                con2.Open();
                numCust = Command2.ExecuteScalar().ToString();
                con2.Close();
            }

            // Check if the Customer and Movie Exists 
            if (Convert.ToInt32(numMovies) > 0 && Convert.ToInt32(numCust) > 0)
            {
                // this puts the parameters into the code so that the data in the text boxes is added to the database
                string updatestatement = "UPDATE RentedMovies set MovieIDFK=@MovieIDFK, CustIDFK=@CustIDFK, DateRented=@DateRented, DateReturned=@DateReturned Where RMID = @RMID";

                using (SqlCommand update = new SqlCommand(updatestatement, con))
                {
                    update.Parameters.AddWithValue("@RMID", rentedMovieID.ToString());
                    update.Parameters.AddWithValue("@MovieIDFK", movieIDFK);
                    update.Parameters.AddWithValue("@CustIDFK", custIDFK);
                    update.Parameters.AddWithValue("@DateRented", dateRented);
                    update.Parameters.AddWithValue("@DateReturned", dateReturned);

                    con.Open(); //open a connection to the database

                    //its a NONQuery as it doesn't return any data its only going up to the server
                    update.ExecuteNonQuery(); //Run the Query

                    con.Close(); //Close a connection to the database

                    //a happy message box
                    MessageBox.Show("Rented Movie is edited!! ");
                }

                string queryGetYear = "SELECT Year FROM Movies Where MovieID =" + ((movieIDFK == "") ? "0" : movieIDFK);
                SqlConnection con2 = new SqlConnection(conString);
                SqlCommand command2 = new SqlCommand(queryGetYear, con2);
                con2.Open();
                SqlDataReader reader = command2.ExecuteReader(); //  Execute  Query of the Server
                List<string> storeYear = new List<string>();
                //Reading form Server
                while (reader.Read())
                {
                    var charsToRemove = new string[] { "-" };
                    string holdvalue;
                    foreach (var c in charsToRemove)
                    {

                        holdvalue = reader["Year"].ToString().Replace(c, string.Empty);
                        holdvalue = reader["Year"].ToString().Substring(0, 4);
                        storeYear.Add(holdvalue);
                    }
                }
                reader.Close(); // Close the Data Reader
                foreach (var c in storeYear)
                {
                    if ((DateTime.Now.Year - Convert.ToInt32(c)) >= 5)
                    {
                        MessageBox.Show("The Cost will Be $2.00");
                    }
                    else{
                        MessageBox.Show("The Cost will Be $5.00");
                    }
                }
            }
            else{
                MessageBox.Show("The customer or movie doesn't exist in the database");
            }
        }

        public void DeleteMovieRented(int rentedMovieID)
        {
            // a simple Scalar query just returning one value.
            string queryString = "Delete RentedMovies Where RMID =" + rentedMovieID;

            using (SqlConnection con2 = new SqlConnection(conString))
            {
                SqlCommand Command = new SqlCommand(queryString, con2);
                con2.Open();
                Command.ExecuteNonQuery();
                con2.Close();

                MessageBox.Show("Rented Movie is deleted from database!!");
            }
        }

        private DataTable CreateRentedOutUITable()
        {
            DataTable rentedOut = new DataTable(); // Create new UI Table called rentedOut

            rentedOut.Clear();  // Clear UI Table in Visual Studio

            //Create Columns for Visual Studio Table
            rentedOut.Columns.Add("rented movies id").DataType = typeof(System.Int32);
            rentedOut.Columns.Add("movie ID FK");
            rentedOut.Columns.Add("title");
            rentedOut.Columns.Add("customer ID FK");
            rentedOut.Columns.Add("customer first name");
            rentedOut.Columns.Add("customer last name");
            rentedOut.Columns.Add("date rented");
            rentedOut.Columns.Add("date returned");
            return rentedOut;
        }
        private DataTable ReadRentedOutDATA(DataTable rentedOut)
        {
            string query = @"SELECT *
                             FROM RentedMovies, Movies, Customer
                             WHERE DateReturned IS NULL AND MovieID = MovieIDFK AND CustID = CustIDFK 
                             ORDER BY RMID;"; //Create Query 

            SqlCommand command = new SqlCommand(query, con);

            SqlDataReader reader = command.ExecuteReader(); //  Execute  Query of the Server

            //Reading form Server
            while (reader.Read())
            {
                // read data from Colums in Server and add to the rentedOut table in visual studio
                rentedOut.Rows.Add(
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
            return rentedOut;
        }

        public DataTable ShowRentedOutMovies()
        {

            con.Open(); // Open Connection to Server

            DataTable rentedOut = CreateRentedOutUITable();

            rentedOut = ReadRentedOutDATA(rentedOut);

            con.Close(); // Close Connection to Server

            return rentedOut;
        }

        private DataTable CreateTheMostPopularVideoUITable()
        {
            DataTable popularVideo = new DataTable(); // Create new UI Table called popularVideo

            popularVideo.Clear();  // Clear UI Table in Visual Studio

            //Create Columns for Visual Studio Table
            popularVideo.Columns.Add("The most popular video").DataType = typeof(System.Int32); ;
            popularVideo.Columns.Add("title");
            return popularVideo;
        }

        private DataTable ReadTheMostPopularVideoDATA(DataTable popularVideo)
        {
            string query = @"Select TOP 1 Count(*)TheMostPopularVideo, Title 
                             FROM RentedMovies, Movies
                             WHERE MovieIDFK = MovieID 
                             GROUP BY Title
                             HAVING COUNT(*) > 1 
                             ORDER BY TheMostPopularVideo DESC"; //Create Query 

            SqlCommand command = new SqlCommand(query, con);

            SqlDataReader reader = command.ExecuteReader(); //  Execute  Query of the Server

            //Reading form Server
            while (reader.Read())
            {
                // read data from Colums in Server and add to the popularVideo table in visual studio
                popularVideo.Rows.Add(
                    reader["TheMostPopularVideo"],
                    reader["Title"]
                    );
            }
            reader.Close(); // Close the Data Reader
            return popularVideo;
        }

        public DataTable ShowTheMostPopularVideo()
        {
            con.Open(); // Open Connection to Server

            DataTable popularVideo = CreateTheMostPopularVideoUITable();

            popularVideo = ReadTheMostPopularVideoDATA(popularVideo);

            con.Close(); // Close Connection to Server

            return popularVideo;
        }

        private DataTable CreateWhoBorrowedTheMostVideosUITable()
        {
            DataTable bestCustomer = new DataTable(); // Create new UI Table called bestCustomer

            bestCustomer.Clear();  // Clear UI Table in Visual Studio

            //Create Columns for Visual Studio Table
            bestCustomer.Columns.Add("Who borrowed the most videos").DataType = typeof(System.Int32); ;
            bestCustomer.Columns.Add("first name");
            bestCustomer.Columns.Add("last name");
            return bestCustomer;
        }

        private DataTable ReadWhoBorrowedTheMostVideosDATA(DataTable bestCustomer)
        {
            string query = @"Select TOP 1 Count(*)WhoBorrowedTheMostVideos, FirstName, LastName 
                             FROM RentedMovies, Customer 
                             WHERE CustID = CustIDFK 
                             GROUP BY FirstName, LastName 
                             HAVING COUNT(*) > 1 
                             ORDER BY WhoBorrowedTheMostVideos DESC "; //Create Query 

            SqlCommand command = new SqlCommand(query, con);

            SqlDataReader reader = command.ExecuteReader(); //  Execute  Query of the Server

            //Reading form Server
            while (reader.Read())
            {
                // read data from Colums in Server and add to the bestCustomer table in visual studio
                bestCustomer.Rows.Add(
                    reader["WhoBorrowedTheMostVideos"],
                    reader["FirstName"],
                    reader["LastName"]
                    );
            }
            reader.Close(); // Close the Data Reader
            return bestCustomer;
        }
        
        public DataTable ShowWhoBorrowedTheMostVideosVideo()
        {
            con.Open(); // Open Connection to Server

            DataTable bestCustomer = CreateWhoBorrowedTheMostVideosUITable();

            bestCustomer = ReadWhoBorrowedTheMostVideosDATA(bestCustomer);

            con.Close(); // Close Connection to Server

            return bestCustomer;
        }
    }
}
