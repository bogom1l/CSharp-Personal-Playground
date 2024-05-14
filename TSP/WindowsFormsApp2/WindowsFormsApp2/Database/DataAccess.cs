namespace WindowsFormsApp2.Database
{
    using System;
    using System.Collections.Generic;
    using System.Data.SQLite;
    using System.Text;
    using Entities;

    public class DataAccess
    {
        private readonly string connectionString =
            "Data Source=C:\\Users\\wavepc\\Documents\\My Git Repos\\CSharp-Personal-Playground\\TSP\\WindowsFormsApp2\\Database.db;Version=3;";

        public void CreateCarTable()
        {
            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                connection.Open();

                string query = "CREATE TABLE IF NOT EXISTS Car (" +
                               "id INTEGER PRIMARY KEY, " +
                               "licensePlate TEXT, " +
                               "model TEXT, " +
                               "make TEXT, " +
                               "color TEXT, " +
                               "year INTEGER, " +
                               "seats INTEGER, " +
                               "priceForRepairing REAL" +
                               ")";

                using (SQLiteCommand command = new SQLiteCommand(query, connection))
                {
                    command.ExecuteNonQuery();
                }
            }
        }

        public List<Car> GetAllCars()
        {
            List<Car> cars = new List<Car>();

            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                connection.Open();

                string query = "SELECT * FROM Car";

                using (SQLiteCommand command = new SQLiteCommand(query, connection))
                using (SQLiteDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Car car = new Car
                        {
                            Id = Convert.ToInt32(reader["id"]),
                            LicensePlate = Convert.ToString(reader["licensePlate"]),
                            Model = Convert.ToString(reader["model"]),
                            Make = Convert.ToString(reader["make"]),
                            Color = Convert.ToString(reader["color"]),
                            Year = Convert.ToInt32(reader["year"]),
                            Seats = Convert.ToInt32(reader["seats"]),
                            PriceForRepairing = Convert.ToDouble(reader["priceForRepairing"])
                        };

                        cars.Add(car);
                    }
                }
            }

            return cars;
        }

        public void CreateCar(Car car)
        {
            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                connection.Open();

                string query = "INSERT INTO Car (licensePlate, model, make, color, year, seats, priceForRepairing) " +
                               "VALUES (@LicensePlate, @Model, @Make, @Color, @Year, @Seats, @PriceForRepairing)";

                using (SQLiteCommand command = new SQLiteCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@LicensePlate", car.LicensePlate);
                    command.Parameters.AddWithValue("@Model", car.Model);
                    command.Parameters.AddWithValue("@Make", car.Make);
                    command.Parameters.AddWithValue("@Color", car.Color);
                    command.Parameters.AddWithValue("@Year", car.Year);
                    command.Parameters.AddWithValue("@Seats", car.Seats);
                    command.Parameters.AddWithValue("@PriceForRepairing", car.PriceForRepairing);

                    command.ExecuteNonQuery();
                }
            }
        }

        public void UpdateCar(Car car)
        {
            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                connection.Open();

                string query = "UPDATE Car SET licensePlate = @LicensePlate, model = @Model, " +
                               "make = @Make, color = @Color, year = @Year, seats = @Seats, " +
                               "priceForRepairing = @PriceForRepairing WHERE id = @Id";

                using (SQLiteCommand command = new SQLiteCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@LicensePlate", car.LicensePlate);
                    command.Parameters.AddWithValue("@Model", car.Model);
                    command.Parameters.AddWithValue("@Make", car.Make);
                    command.Parameters.AddWithValue("@Color", car.Color);
                    command.Parameters.AddWithValue("@Year", car.Year);
                    command.Parameters.AddWithValue("@Seats", car.Seats);
                    command.Parameters.AddWithValue("@PriceForRepairing", car.PriceForRepairing);
                    command.Parameters.AddWithValue("@Id", car.Id);

                    command.ExecuteNonQuery();
                }
            }
        }

        public void DeleteCar(int carId)
        {
            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                connection.Open();

                string query = "DELETE FROM Car WHERE id = @Id";

                using (SQLiteCommand command = new SQLiteCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Id", carId);

                    command.ExecuteNonQuery();
                }
            }
        }

        public void DeleteAllCars()
        {
            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                connection.Open();

                string query = "DELETE FROM Car";

                using (SQLiteCommand command = new SQLiteCommand(query, connection))
                {
                    command.ExecuteNonQuery();
                }
            }
        }

        public List<Car> GetFilteredCars(string licensePlate, string model, string make, string color, string year,
            string seats, string priceForRepairing)
        {
            List<Car> filteredCars = new List<Car>();

            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                connection.Open();

                StringBuilder queryBuilder = new StringBuilder("SELECT * FROM Car WHERE 1=1");


                if (!string.IsNullOrEmpty(licensePlate))
                {
                    queryBuilder.Append(" AND licensePlate = @LicensePlate");
                }

                if (!string.IsNullOrEmpty(make))
                {
                    queryBuilder.Append(" AND make = @Make");
                }

                if (!string.IsNullOrEmpty(model))
                {
                    queryBuilder.Append(" AND model = @Model");
                }

                if (!string.IsNullOrEmpty(color))
                {
                    queryBuilder.Append(" AND color = @Color");
                }

                if (!string.IsNullOrEmpty(year))
                {
                    queryBuilder.Append(" AND year = @Year");
                }

                if (!string.IsNullOrEmpty(seats))
                {
                    queryBuilder.Append(" AND seats = @Seats");
                }

                if (!string.IsNullOrEmpty(priceForRepairing))
                {
                    queryBuilder.Append(" AND priceForRepairing = @PriceForRepairing");
                }

                string query = queryBuilder.ToString();

                using (SQLiteCommand command = new SQLiteCommand(query, connection))
                {
                    if (!string.IsNullOrEmpty(licensePlate))
                    {
                        command.Parameters.AddWithValue("@LicensePlate", licensePlate);
                    }

                    if (!string.IsNullOrEmpty(make))
                    {
                        command.Parameters.AddWithValue("@Make", make);
                    }

                    if (!string.IsNullOrEmpty(model))
                    {
                        command.Parameters.AddWithValue("@Model", model);
                    }

                    if (!string.IsNullOrEmpty(color))
                    {
                        command.Parameters.AddWithValue("@Color", color);
                    }

                    if (!string.IsNullOrEmpty(year))
                    {
                        command.Parameters.AddWithValue("@Year", year);
                    }

                    if (!string.IsNullOrEmpty(seats))
                    {
                        command.Parameters.AddWithValue("@Seats", seats);
                    }

                    if (!string.IsNullOrEmpty(priceForRepairing))
                    {
                        command.Parameters.AddWithValue("@PriceForRepairing", priceForRepairing);
                    }


                    using (SQLiteDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Car car = new Car
                            {
                                Id = Convert.ToInt32(reader["id"]),
                                LicensePlate = Convert.ToString(reader["licensePlate"]),
                                Model = Convert.ToString(reader["model"]),
                                Make = Convert.ToString(reader["make"]),
                                Color = Convert.ToString(reader["color"]),
                                Year = Convert.ToInt32(reader["year"]),
                                Seats = Convert.ToInt32(reader["seats"]),
                                PriceForRepairing = Convert.ToDouble(reader["priceForRepairing"])
                            };

                            filteredCars.Add(car);
                        }
                    }
                }
            }

            return filteredCars;
        }


        public List<double> GetCarPrices()
        {
            List<double> carPrices = new List<double>();

            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                connection.Open();

                string query = "SELECT PriceForRepairing FROM Car";
                using (SQLiteCommand command = new SQLiteCommand(query, connection))
                {
                    using (SQLiteDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            if (!reader.IsDBNull(0))
                            {
                                double price = reader.GetDouble(0);
                                carPrices.Add(price);
                            }
                        }
                    }
                }

                connection.Close();
            }

            return carPrices;
        }
    }
}