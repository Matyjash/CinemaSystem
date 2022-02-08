using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;

namespace Cinema_System
{
    class DatabaseCommunication
    {
        //Connection String
        private readonly SqlConnection connection = new SqlConnection(Properties.Resources.ConncectionString);

        public DataTable GetBoughtTickets(User user)
        {
            //tabela na otrzymane dane
            DataTable table = new DataTable();
            //polecenie sql
            string query = "EXEC getBoughtTickets @Login='" + user.login + "';";
            try
            {
                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                adapter.Fill(table);
            }
            catch (Exception e)
            {
                string returnMessage = "Błąd komunikacji z bazą danych!";
                MessageBox.Show(returnMessage);
            }

            return table;
        }
        public bool buyTicket(User user, int screeningId)
        {
            bool success = false;
            if (user.logged)
            {
                string query = "EXEC buyTicket @Login='" + user.login + "', @Screening_id=" + screeningId + ";";
                try
                {
                    connection.Open();
                    SqlCommand commandBuyTicket = new SqlCommand(query, connection);

                    commandBuyTicket.ExecuteScalar();
                    success = true;

                }
                catch (Exception e)
                {
                    
                }
                finally { connection.Close(); }


            }
            return success;
        }

        
        public DataTable GetScreenings()
        {
            //polecenie sql
            string query = "EXEC get_all_going_screenings;";
            SqlDataAdapter adapter = new SqlDataAdapter(query, connection);

            //tworzymy tabele na otrzymane dane
            DataTable table = new DataTable();
           
            //wypełniamy ją otrzymanymi danymi
            adapter.Fill(table);

            return table;
        }
        public bool AddReview(string login, string text, string title, int rate)
        {
            string query = "EXEC insertReview @Login = '" + login +
             "', @Rate = " + rate + " , @Text ='" + text + "' , @Movie_title = '" + title + "'; ";
            bool success = false;

            try
            {
                connection.Open();
                SqlCommand commandInsertReview = new SqlCommand(query, connection);

                commandInsertReview.ExecuteScalar();
                success = true;

            }
            catch (Exception e)
            {
              
            }
            finally { connection.Close(); }


            return success;

        }

        public bool EditMovie(string oldTitle, string newTitle, string newGenre, string directorFirstName, string directroLastName, string date, User user)
        {
            bool success = false;

            if (user.privilaged)
            {
                string query = "EXEC editMovie @oldTitle='" + oldTitle + "', @newTitle='" + newTitle + "', @newGenre='" + newGenre +
                    "', @directorFirstName='" + directorFirstName + "', @directorLastName='" + directroLastName + "', @date ='" + date + "';";

                try
                {
                    connection.Open();
                    SqlCommand commandEditMovie = new SqlCommand(query, connection);
                    commandEditMovie.ExecuteScalar();
                    success = true;

                }
                catch (Exception e)
                {

                }
                finally { connection.Close(); }
            }
            return success;
        }

        public bool EditScreening(int screeningId, string newDate, int newHallId, User user)
        {
            bool success = false;

            if (user.privilaged)
            {
                string query = "EXEC editScreening @screeningId='" + screeningId + "', @newDate='" + newDate + "', @newHallId='" + newHallId + "';";

                try
                {
                    connection.Open();
                    SqlCommand commandEditScreening = new SqlCommand(query, connection);
                    commandEditScreening.ExecuteScalar();
                    success = true;

                }
                catch (Exception e)
                {

                }
                finally { connection.Close(); }
            }
            return success;

            return success;
        }

        public bool deleteScreening(int id, User user)
        {
            bool success = false;
            if (user.privilaged)
            {
                string query = "DELETE from screenings where id = " + id + " ;";

                try
                {
                    connection.Open();
                    SqlCommand commandDeleteScreening = new SqlCommand(query, connection);

                    commandDeleteScreening.ExecuteScalar();
                    success = true;

                }
                catch (Exception e)
                {

                }
                finally { connection.Close(); }
            }
            return success;
        }

        public DataTable GetMovies()
        {
            //polecenie sql
            string query = "EXEC get_all_going_movies";
            //tabela na otrzymane dane
            DataTable table = new DataTable();
            try
            {
                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                adapter.Fill(table);
                table.Columns[0].ColumnMapping = MappingType.Hidden;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }

            return table;
        }

        /// <summary>
        /// Metoda dodająca do bazy film o wskazanych parametrach
        /// </summary>
        /// <param name="title">Tytuł filmu</param>
        /// <param name="genre">Gatunek filmu</param>
        /// <param name="directorFirstname">Imię reżysera</param>
        /// <param name="directorLastName">Nazwisko rezysera</param>
        /// <param name="date">Data premiery</param>
        public void addMovie(string title, string genre, string directorFirstname, string directorLastName, string date)
        {
            //poleceni sql
            string query = "EXEC insertMovie @Movie_title ='" + title + "', @Movie_genre='" + genre + 
                "', @Director_first_name='" + directorFirstname + "', @Director_last_name='" + directorLastName + "', @Movie_release_day='" + date + "';";

            try
            {
                connection.Open();

                SqlCommand commandInsertMovie= new SqlCommand(query, connection);
                commandInsertMovie.ExecuteScalar();
                MessageBox.Show("Pomyślnie dodano film!");
            }
            catch (Exception e)
            {
                string returnMessage;
                returnMessage = "Błąd komunikacji z bazą danych!";
                returnMessage += "\n" + e.Message;
                MessageBox.Show(returnMessage);
            }
            finally
            {
                connection.Close();
            } 


        }
        /// <summary>
        /// Metoda dodająca do bazy seans o wskazanych parametrach
        /// </summary>
        /// <param name="movieName">Nazwa filmu</param>
        /// <param name="date">Data i godzina filmu w formacie YYYY-MM-DD HH:mm</param>
        /// <param name="hallId">Id sali w której ma się odbyć seans</param>
        public void addScreening(string movieName, string date, int hallId, User user)
        {
            //polecenie sql
            string query = "EXEC insertScreening @Movie = '" + movieName + "', @Date = '" + date + "' , @Hall_id =" + hallId + ";";

            try
            {
                connection.Open();

                SqlCommand commandInsertScreening = new SqlCommand(query, connection);
                commandInsertScreening.ExecuteScalar();
                MessageBox.Show("Pomyślnie dodano seans!");
            }
            catch(Exception e)
            {
                string returnMessage;
                returnMessage = "Błąd komunikacji z bazą danych!";
                returnMessage += "\n" + e.Message;
                MessageBox.Show(returnMessage);
            }
            finally
            {
                connection.Close();
            }


        }

        public bool Login(string login, string password, User user)
        {
            bool success = false;
            string returnMessage = "!";
            bool status = false;

            string query = "DECLARE	@responseMessage nvarchar(250) "+
                "EXEC Login " +
                "@Login = '"+login+"', " +
                "@Password = '"+password+"', " +
                "@responseMessage = @responseMessage OUTPUT " +
                "SELECT	@responseMessage as N'@responseMessage';";

            string query2 = "exec getUserStatus @Login = '" + login + "';";

            try
            {
                connection.Open();
                SqlCommand commandLogin = new SqlCommand(query, connection);

                returnMessage = (string)commandLogin.ExecuteScalar();

                if (returnMessage.StartsWith('1'))
                {
                    success = true;
                    user.logged = true;
                    user.login = login;

                    SqlCommand commandGetStatus = new SqlCommand(query2, connection);
                    status = (bool)commandGetStatus.ExecuteScalar();
                    if (status == true)
                    {
                        user.privilaged = true;
                    }
                    else
                    {
                        user.privilaged = false;
                    }
                }
                returnMessage = returnMessage.Substring(1);

            }
            catch (Exception e)
            {
                returnMessage = "Błąd komunikacji z bazą danych!";
                returnMessage += "\n" + e.Message;
            }
            finally { connection.Close(); }

            MessageBox.Show(returnMessage);

            return success;
        }

        public bool Register(string login, string password)
        {
            bool success = false;
            string returnMessage = "!";

            string query = "DECLARE	@responseMessage nvarchar(250) " +
                "EXEC register " +
                "@Login = '" + login + "', " +
                "@Password = '" + password + "', " +
                "@responseMessage = @responseMessage OUTPUT " +
                "SELECT	@responseMessage as N'@responseMessage';";

            try
            {
                connection.Open();
                SqlCommand commandRegister = new SqlCommand(query, connection);

                returnMessage = (string)commandRegister.ExecuteScalar();

                if (returnMessage.StartsWith('1'))
                {
                    success = true;
                }
                returnMessage = returnMessage.Substring(1);

            }
            catch (Exception e)
            {
                returnMessage = "Błąd komunikacji z bazą danych!";
                returnMessage += "\n" + e.Message;
            }
            finally { connection.Close(); }

            MessageBox.Show(returnMessage);

            return success;

        }

        public DataTable GetReviews(string title)
        {
            //tabela na otrzymane dane
            DataTable table = new DataTable();
            //polecenie sql
            string query = "EXEC get_all_reviews_for @Movie='"+title+"';";
            try
            {
                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);

                

                adapter.Fill(table);
            }catch(Exception e)
            {
                string returnMessage;
                returnMessage = "Błąd komunikacji z bazą danych!";
                returnMessage += "\n" + e.Message;
                MessageBox.Show(returnMessage);
            }

            return table;

        }

    }
}
