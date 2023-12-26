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
            "Data Source=D:\\DEVELOPER PROJECTS\\VS Projects\\Databases\\Database.db;Version=3;";

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

        public void CreateClientTable()
        {
            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                connection.Open();

                string query = "CREATE TABLE IF NOT EXISTS Client (" +
                               "id INTEGER PRIMARY KEY, " +
                               "name TEXT, " +
                               "numberOfPersonalID INTEGER, " +
                               "city TEXT, " +
                               "address TEXT, " +
                               "phone TEXT" +
                               ")";

                using (SQLiteCommand command = new SQLiteCommand(query, connection))
                {
                    command.ExecuteNonQuery();
                }
            }
        }

        public void CreateRepairTable()
        {
            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                connection.Open();

                string query = "CREATE TABLE IF NOT EXISTS Repair (" +
                               "id INTEGER PRIMARY KEY, " +
                               "carId INTEGER, " +
                               "clientId INTEGER, " +
                               "dateOfStartingRepair TEXT, " +
                               "dateOfFinishingRepair TEXT, " +
                               "isPaid BOOLEAN, " +
                               "isReturned BOOLEAN" +
                               ")";

                using (SQLiteCommand command = new SQLiteCommand(query, connection))
                {
                    command.ExecuteNonQuery();
                }
            }
        }

        // --------------Car--------------  

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


        // --------------Client-------------- 

        public List<Client> GetAllClients()
        {
            List<Client> clients = new List<Client>();

            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                connection.Open();

                string query = "SELECT * FROM Client";

                using (SQLiteCommand command = new SQLiteCommand(query, connection))
                using (SQLiteDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Client client = new Client
                        {
                            Id = Convert.ToInt32(reader["id"]),
                            Name = Convert.ToString(reader["name"]),
                            NumberOfPersonalID = Convert.ToInt32(reader["numberOfPersonalID"]),
                            City = Convert.ToString(reader["city"]),
                            Address = Convert.ToString(reader["address"]),
                            Phone = Convert.ToString(reader["phone"])
                        };

                        clients.Add(client);
                    }
                }
            }

            return clients;
        }

        public void CreateClient(Client client)
        {
            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                connection.Open();

                string query = "INSERT INTO Client (name, numberOfPersonalID, city, address, phone) " +
                               "VALUES (@Name, @NumberOfPersonalID, @City, @Address, @Phone)";

                using (SQLiteCommand command = new SQLiteCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Name", client.Name);
                    command.Parameters.AddWithValue("@NumberOfPersonalID", client.NumberOfPersonalID);
                    command.Parameters.AddWithValue("@City", client.City);
                    command.Parameters.AddWithValue("@Address", client.Address);
                    command.Parameters.AddWithValue("@Phone", client.Phone);

                    command.ExecuteNonQuery();
                }
            }
        }

        public void UpdateClient(Client client)
        {
            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                connection.Open();

                string query = "UPDATE Client SET name = @Name, numberOfPersonalID = @NumberOfPersonalID, " +
                               "city = @City, address = @Address, phone = @Phone WHERE id = @Id";

                using (SQLiteCommand command = new SQLiteCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Name", client.Name);
                    command.Parameters.AddWithValue("@NumberOfPersonalID", client.NumberOfPersonalID);
                    command.Parameters.AddWithValue("@City", client.City);
                    command.Parameters.AddWithValue("@Address", client.Address);
                    command.Parameters.AddWithValue("@Phone", client.Phone);
                    command.Parameters.AddWithValue("@Id", client.Id);

                    command.ExecuteNonQuery();
                }
            }
        }

        public void DeleteClient(int clientId)
        {
            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                connection.Open();

                string query = "DELETE FROM Client WHERE id = @Id";

                using (SQLiteCommand command = new SQLiteCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Id", clientId);

                    command.ExecuteNonQuery();
                }
            }
        }


        // --------------Repair-------------- 

        public List<Repair> GetAllRepairs()
        {
            List<Repair> repairs = new List<Repair>();

            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                connection.Open();

                string query = "SELECT * FROM Repair";

                using (SQLiteCommand command = new SQLiteCommand(query, connection))
                using (SQLiteDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Repair repair = new Repair
                        {
                            Id = Convert.ToInt32(reader["id"]),
                            CarId = Convert.ToInt32(reader["carId"]),
                            ClientId = Convert.ToInt32(reader["clientId"]),
                            DateOfStartingRepair = Convert.ToString(reader["dateOfStartingRepair"]),
                            DateOfFinishingRepair = Convert.ToString(reader["dateOfFinishingRepair"]),
                            IsPaid = Convert.ToBoolean(reader["isPaid"]),
                            IsReturned = Convert.ToBoolean(reader["isReturned"])
                        };

                        repairs.Add(repair);
                    }
                }
            }

            return repairs;
        }

        public void CreateRepair(Repair repair)
        {
            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                connection.Open();

                string query =
                    "INSERT INTO Repair (carId, clientId, dateOfStartingRepair, dateOfFinishingRepair, isPaid, isReturned) " +
                    "VALUES (@CarId, @ClientId, @DateOfStartingRepair, @DateOfFinishingRepair, @IsPaid, @IsReturned)";

                using (SQLiteCommand command = new SQLiteCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@CarId", repair.CarId);
                    command.Parameters.AddWithValue("@ClientId", repair.ClientId);
                    command.Parameters.AddWithValue("@DateOfStartingRepair", repair.DateOfStartingRepair);
                    command.Parameters.AddWithValue("@DateOfFinishingRepair", repair.DateOfFinishingRepair);
                    command.Parameters.AddWithValue("@IsPaid", repair.IsPaid);
                    command.Parameters.AddWithValue("@IsReturned", repair.IsReturned);

                    command.ExecuteNonQuery();
                }
            }
        }

        public void UpdateRepair(Repair repair)
        {
            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                connection.Open();

                string query = "UPDATE Repair SET carId = @CarId, clientId = @ClientId, " +
                               "dateOfStartingRepair = @DateOfStartingRepair, " +
                               "dateOfFinishingRepair = @DateOfFinishingRepair, " +
                               "isPaid = @IsPaid, isReturned = @IsReturned WHERE carId = @CarId";

                using (SQLiteCommand command = new SQLiteCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@CarId", repair.CarId);
                    command.Parameters.AddWithValue("@ClientId", repair.ClientId);
                    command.Parameters.AddWithValue("@DateOfStartingRepair", repair.DateOfStartingRepair);
                    command.Parameters.AddWithValue("@DateOfFinishingRepair", repair.DateOfFinishingRepair);
                    command.Parameters.AddWithValue("@IsPaid", repair.IsPaid);
                    command.Parameters.AddWithValue("@IsReturned", repair.IsReturned);

                    command.ExecuteNonQuery();
                }
            }
        }

        public void DeleteRepair(int repairId)
        {
            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                connection.Open();

                string query = "DELETE FROM Repair WHERE id = @Id";

                using (SQLiteCommand command = new SQLiteCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Id", repairId);

                    command.ExecuteNonQuery();
                }
            }
        }


        // ------- Selects --------


        // Select 1: All clients who left their cars for repair in the last 24 hours, ordered by car make and ascending car license plate
        public string GetClientsLeftCarsForRepairLast24Hours()
        {
            StringBuilder result = new StringBuilder();

            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                connection.Open();

                string query = @"
                SELECT C.name, R.dateOfStartingRepair, R.dateOfFinishingRepair, Ca.make, Ca.licensePlate
                FROM Client C
                JOIN Repair R ON C.id = R.clientId
                JOIN Car Ca ON R.carId = Ca.id
                WHERE datetime('now', '-1 day') <= datetime(R.dateOfStartingRepair)
                ORDER BY Ca.make, Ca.licensePlate ASC;";

                using (SQLiteCommand command = new SQLiteCommand(query, connection))
                using (SQLiteDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        result.AppendLine($"Client Name: {reader["name"]}, " +
                                          $"Start Date: {reader["dateOfStartingRepair"]}, " +
                                          $"End Date: {reader["dateOfFinishingRepair"]}, " +
                                          $"Car Make: {reader["make"]}, " +
                                          $"Car License Plate: {reader["licensePlate"]}");
                    }
                }
            }

            return result.ToString();
        }

        // Select 2: Minimal and maximal price for repair, ordered by car make
        public string GetMinMaxPriceForRepairByCarMake()
        {
            StringBuilder result = new StringBuilder();

            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                connection.Open();

                string query = @"
                SELECT make, MIN(priceForRepairing) AS minimalPrice, MAX(priceForRepairing) AS maximalPrice
                FROM Car
                GROUP BY make
                ORDER BY make;";

                using (SQLiteCommand command = new SQLiteCommand(query, connection))
                using (SQLiteDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        result.AppendLine($"Car Make: {reader["make"]}, " +
                                          $"Minimal Price: {reader["minimalPrice"]}, " +
                                          $"Maximal Price: {reader["maximalPrice"]}");
                    }
                }
            }

            return result.ToString();
        }

        // Select 3: All unpaid repaired cars
        public string GetUnpaidRepairedCars()
        {
            StringBuilder result = new StringBuilder();

            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                connection.Open();

                string query = @"
                SELECT C.*, R.*
                FROM Car C
                JOIN Repair R ON C.id = R.carId
                WHERE R.isPaid = 0;";

                using (SQLiteCommand command = new SQLiteCommand(query, connection))
                using (SQLiteDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        result.AppendLine($"Car Id: {reader["id"]}, " +
                                          $"License Plate: {reader["licensePlate"]}, " +
                                          $"Model: {reader["model"]}, " +
                                          // Add other properties as needed
                                          $"IsPaid: {reader["isPaid"]}");
                    }
                }
            }

            return result.ToString();
        }

        // Select 4: All paid repaired cars
        public string GetPaidRepairedCars()
        {
            StringBuilder result = new StringBuilder();

            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                connection.Open();

                string query = @"
                SELECT C.*, R.*
                FROM Car C
                JOIN Repair R ON C.id = R.carId
                WHERE R.isPaid = 1;";

                using (SQLiteCommand command = new SQLiteCommand(query, connection))
                using (SQLiteDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        result.AppendLine($"Car Id: {reader["id"]}, " +
                                          $"License Plate: {reader["licensePlate"]}, " +
                                          $"Model: {reader["model"]}, " +
                                          // Add other properties as needed
                                          $"IsPaid: {reader["isPaid"]}");
                    }
                }
            }

            return result.ToString();
        }

        // Select 5: Top 3 most frequently repaired cars
        public string GetTop3MostFrequentlyRepairedCars()
        {
            StringBuilder result = new StringBuilder();

            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                connection.Open();

                string query = @"
                SELECT C.*, COUNT(*) AS repairCount
                FROM Car C
                JOIN Repair R ON C.id = R.carId
                GROUP BY C.id
                ORDER BY repairCount DESC
                LIMIT 3;";

                using (SQLiteCommand command = new SQLiteCommand(query, connection))
                using (SQLiteDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        result.AppendLine($"Car Id: {reader["id"]}, " +
                                          $"License Plate: {reader["licensePlate"]}, " +
                                          $"Model: {reader["model"]}, " +
                                          // Add other properties as needed
                                          $"Repair Count: {reader["repairCount"]}");
                    }
                }
            }

            return result.ToString();
        }

        // Select 6: Top 1 client who spent the most money on repairing cars
        public string GetTop1ClientSpentMostMoneyOnRepairs()
        {
            StringBuilder result = new StringBuilder();

            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                connection.Open();

                string query = @"
                SELECT C.name, SUM(Ca.priceForRepairing) AS totalSpent
                FROM Client C
                JOIN Repair R ON C.id = R.clientId
                JOIN Car Ca ON R.carId = Ca.id
                GROUP BY C.id
                ORDER BY totalSpent DESC
                LIMIT 1;";

                using (SQLiteCommand command = new SQLiteCommand(query, connection))
                using (SQLiteDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        result.AppendLine($"Client Name: {reader["name"]}, " +
                                          // Add other properties as needed
                                          $"Total Spent: {reader["totalSpent"]}");
                    }
                }
            }

            return result.ToString();
        }
    }
}