﻿using System;

namespace cmdcli
{
    class Program
    {
        static string BytesCountToStringSize(long bytesCount)
        {
            long n = bytesCount, i = 0;

            while ((bytesCount=bytesCount/1024)!=0 && i<3)
            {
                i++;
            }
            var units = new []{"o", "Ko", "Mo", "Go"};
            return $"{n/Math.Pow(1024, i):,0.00}{units[i]}";
        }
        static void Main(string[] args)
        {
            var se= new Basics.COM.KAT.KatSearchEngine();
            se.Search();
            //var cli = new TorrentClient("127.0.0.1", 7070, "yiabiten", "hrt.tkr10990");
            //var tkn= cli.GetTorrentList();
            //foreach (var t in tkn)
            //{
            //    Console.WriteLine($"{t.Name,85} {BytesCountToStringSize(t.Size),10} {t.State,10}");
            //}
            //Console.WriteLine(tkn.Count);
            //System.IO.File.Delete("MyDatabase.sqlite");
            //SQLiteConnection.CreateFile("MyDatabase.sqlite");
            //var mDbConnection = new SQLiteConnection("Data Source=MyDatabase.sqlite;Version=3;Password=jsdgf;");
            //var mDbConnection = Connection.CreateInstance().sqliteConnection;
            //mDbConnection.Open();
            //
            //string sql = "CREATE TABLE highscores (name VARCHAR(20), score INT)";
            //SQLiteCommand command = new SQLiteCommand(sql, mDbConnection);
            //Console.WriteLine(command.ExecuteNonQuery());
            //
            //sql = "insert into highscores (name, score) values ('Me', 3000)";
            //command = new SQLiteCommand(sql, mDbConnection);
            //Console.WriteLine(command.ExecuteNonQuery());
            //
            //sql = "insert into highscores (name, score) values ('Myself', 6000)";
            //command = new SQLiteCommand(sql, mDbConnection);
            //Console.WriteLine(command.ExecuteNonQuery());
            //
            //sql = "insert into highscores (name, score) values ('And I', 9001)";
            //command = new SQLiteCommand(sql, mDbConnection);
            //Console.WriteLine(command.ExecuteNonQuery());
            //
            //sql = "select * from highscores order by score desc";
            //command = new SQLiteCommand(sql, mDbConnection);
            //SQLiteDataReader reader = command.ExecuteReader();
            //while (reader.Read())
            //    Console.WriteLine($"Name: {reader["name"]}\tScore: {reader["score"]}");
            //
            //mDbConnection.Close();
            //mDbConnection.Dispose();
            Console.ReadKey();
        }
    }
}