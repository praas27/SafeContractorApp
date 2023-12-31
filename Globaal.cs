﻿using Google.Protobuf.WellKnownTypes;
using MySql.Data.MySqlClient;
using PdfSharp.Drawing;
using PdfSharp.Pdf;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SafeContractorApp
{
    internal class Globaal
    {
        public static string user = "";
        public static string foutcode = "";
        public static string database = "";
        public static string username = "";
        public static string host = "";
        public static int vuurId = 0;
        public static int openId = 0;
        public static int sluitId = 0;
        public static string noodnummer = "";
        public static string uitvoerder = "";
        public static string opdrachtgever = "";
        public static int printId = 0;

        public static string[] FormatText(string text, XFont font, int margin)
        {
            PdfDocument doc = new PdfDocument();
            PdfPage page = doc.AddPage();
            XGraphics gfx = XGraphics.FromPdfPage(page);
            List<string> lines = new List<string>();
            StringBuilder currentLine = new StringBuilder();

            string[] words = text.Split(' ');

            foreach (string word in words)
            {
                string testLine = currentLine.ToString() + word + " ";
                double lineSize = gfx.MeasureString(testLine, font).Width;

                if (lineSize < page.Width - (2 * margin))
                {
                    // The word fits on the current line
                    currentLine.Append(word + " ");
                }
                else
                {
                    // The word exceeds the margin, start a new line
                    lines.Add(currentLine.ToString().Trim());
                    currentLine = new StringBuilder(word + " ");
                }
            }

            // Add the last line
            lines.Add(currentLine.ToString().Trim());

            return lines.ToArray();
        }

        public static string[] FormatTextTwo(string text, XFont font, int maxSize)
        {
            PdfDocument doc = new PdfDocument();
            PdfPage page = doc.AddPage();
            XGraphics gfx = XGraphics.FromPdfPage(page);
            List<string> lines = new List<string>();
            StringBuilder currentLine = new StringBuilder();

            string[] words = text.Split(' ');

            foreach (string word in words)
            {
                string testLine = currentLine.ToString() + word + " ";
                double lineSize = gfx.MeasureString(testLine, font).Width;

                if (lineSize < maxSize)
                {
                    // The word fits on the current line
                    currentLine.Append(word + " ");
                }
                else
                {
                    // The word exceeds the margin, start a new line
                    lines.Add(currentLine.ToString().Trim());
                    currentLine = new StringBuilder(word + " ");
                }
            }

            // Add the last line
            lines.Add(currentLine.ToString().Trim());

            return lines.ToArray();
        }

        public static int GetIdFromTable(string tableName, string columnName, string value)
        {
            int id = 0;
            string query = $"SELECT {columnName}_id FROM {tableName} WHERE {columnName}_naam = @value";

            using (var connection = new MySqlConnection(Globaal.user))
            {
                connection.Open();
                var command = new MySqlCommand(query, connection);
                command.Parameters.AddWithValue("@value", value);
                MySqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    id = int.Parse(reader[$"{columnName}_id"].ToString());
                }
                connection.Close();
            }

            return id;
        }

        public static void DeleteDataFromTable(string tableName, string columnName, string value)
        {
            string query = $"DELETE FROM {tableName} WHERE {columnName}_naam = @value";
            using (var connection = new MySqlConnection(Globaal.user))
            {
                connection.Open();
                var command = new MySqlCommand(query, connection);
                command.Parameters.AddWithValue("@value", value);
                command.ExecuteNonQuery();
            }
        }
    }
}
