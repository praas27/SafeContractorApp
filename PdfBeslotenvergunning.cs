using MySql.Data.MySqlClient;
using PdfSharp.Drawing;
using PdfSharp.Pdf;
using PdfSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;

namespace SafeContractorApp
{
    internal class PdfBeslotenvergunning
    {
        public static void GenDoc(int vergunningId)
        {
            int besloten_vergunning_id = 0;
            string datum = string.Empty;
            string start = string.Empty;
            string stop = string.Empty;
            string afdeling = string.Empty;
            string ruimte = string.Empty;
            string werkbeschrijving = string.Empty;
            string product = string.Empty;

            string risico = string.Empty;
            string maatregelen = string.Empty;
            string metingen = string.Empty;
            string beschermiddelen = string.Empty;

            string query = "SELECT besloten_vergunning_besloten_vergunning_id FROM vergunning where vegunning_id=@vegunning_id;";
            using (var connection = new MySqlConnection(Globaal.user))
            {
                connection.Open();
                var command = new MySqlCommand(query, connection);
                command.Parameters.AddWithValue("@vegunning_id", vergunningId);
                MySqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    besloten_vergunning_id = int.Parse(reader["besloten_vergunning_besloten_vergunning_id"].ToString());
                }
                connection.Close();
            }

            query = "SELECT * FROM besloten_vergunning where besloten_vergunning_id=@besloten_vergunning_id;";
            using (var connection = new MySqlConnection(Globaal.user))
            {
                connection.Open();
                var command = new MySqlCommand(query, connection);
                command.Parameters.AddWithValue("@besloten_vergunning_id", besloten_vergunning_id);
                MySqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                   datum = reader["datum"].ToString();
                    start = reader["start"].ToString();
                    stop = reader["stop"].ToString();
                    afdeling = reader["afdeling"].ToString();
                    ruimte = reader["ruimte"].ToString();
                    werkbeschrijving = reader["werkbeschrijving"].ToString();
                    product = reader["product"].ToString();
                    datum = datum.Length > 9 ? datum.Substring(0, 10) : datum;
                    start = start.Length > 4 ? start.Substring(0, 5) : start;
                    stop = stop.Length > 4 ? stop.Substring(0, 5) : stop;
                }
                connection.Close();
            }

            //crete page
            PdfDocument doc = new PdfDocument();
            PdfPage page = doc.AddPage();
            page.Orientation = PageOrientation.Landscape;
            XGraphics gfx = XGraphics.FromPdfPage(page);
            //
            int margeX = 30;
            int margeY = 30;
            XFont titele = new XFont("Calibri", 25);
            XFont font_antw = new XFont("Calibri", 11);
            XFont font_sub = new XFont("Calibri", 11, XFontStyle.Bold);
            XFont font3 = new XFont("Calibri", 12);
            XFont font_Titel = new XFont("Calibri", 20, XFontStyle.Bold);
            XFont font5 = new XFont("Bodoni MT", 11);
            XPen line = new XPen(XColors.Black, 0.5);
            XPen darkLine = new XPen(XColors.Black, 2);
            XImage logo = XImage.FromFile($@"{Properties.Settings.Default.Images}\logo.png");

            //box 1
            gfx.DrawLine(darkLine, margeX, margeY, margeX + 300, margeY);
            gfx.DrawLine(darkLine, margeX, margeY + 60, margeX + 300, margeY + 60);
            gfx.DrawLine(darkLine, margeX, margeY, margeX, margeY + 60);
            gfx.DrawLine(darkLine, margeX + 300, margeY, margeX + 300, margeY + 60);
            //
            gfx.DrawLine(line, margeX + 140, margeY, margeX + 140, margeY + 60);
            gfx.DrawLine(line, margeX + 300 - 60, margeY, margeX + 300 - 60, margeY + 60);
            //
            gfx.DrawString("BESLOTEN", font_Titel, XBrushes.Black, margeX + 145, margeY+25);
            gfx.DrawString("RUIMTES", font_Titel, XBrushes.Black,  + 190, margeY + 45);
            
            gfx.DrawImage(logo, new XRect(margeX+5, margeY-10, logo.Width / 8, logo.Height / 8));


            //box2
            gfx.DrawLine(darkLine, margeX, margeY + 80, margeX + 300, margeY + 80);
            gfx.DrawLine(darkLine, margeX, margeY + 140, margeX + 300, margeY + 140);
            gfx.DrawLine(darkLine, margeX, margeY + 80, margeX, margeY + 140);
            gfx.DrawLine(darkLine, margeX + 300, margeY + 80, margeX + 300, margeY + 140);
            //
            gfx.DrawLine(line, margeX + 150, margeY + 80, margeX + 150, margeY + 140);
            //
            gfx.DrawString("Naam van de uitvoerder: ", font_sub, XBrushes.Black, margeX + 5, 130);
            gfx.DrawString(Globaal.uitvoerder, font_antw, XBrushes.Black, margeX + 5, 140);
            gfx.DrawString("Naam van de opdrachtgever :", font_sub, XBrushes.Black, margeX + 5, 150);
            gfx.DrawString(Globaal.opdrachtgever, font_antw, XBrushes.Black, margeX + 5, 160);
            gfx.DrawString("datum: ", font_sub, XBrushes.Black, margeX + 155, 130);
            gfx.DrawString(datum, font_antw, XBrushes.Black, margeX + 195, 130);
            gfx.DrawString("Start: ", font_sub, XBrushes.Black, margeX + 155, 160);
            gfx.DrawString(start, font_antw, XBrushes.Black, margeX + 185, 160);
            gfx.DrawString("Stop: ", font_sub, XBrushes.Black, margeX + 215, 160);
            gfx.DrawString(stop, font_antw, XBrushes.Black, margeX + 245, 160);

            //box3
            gfx.DrawLine(darkLine, margeX, margeY + 160, margeX + 300, margeY + 160);
            gfx.DrawLine(darkLine, margeX, margeY + 400, margeX + 300, margeY + 400);
            gfx.DrawLine(darkLine, margeX, margeY + 160, margeX, margeY + 400);
            gfx.DrawLine(darkLine, margeX + 300, margeY + 160, margeX + 300, margeY + 400);
            //
            gfx.DrawLine(line, margeX, margeY + 180, margeX + 300, margeY + 180);
            gfx.DrawLine(line, margeX, margeY + 290, margeX + 300, margeY + 290);
            //
            gfx.DrawString("OMSCHRIJVING", font3, XBrushes.Black, margeX + 110, 205);
            gfx.DrawString("Afdeling : ", font_sub, XBrushes.Black, margeX + 5, 230);
            gfx.DrawString("Besloten ruimte : ", font_sub, XBrushes.Black, margeX + 5, 250);
            gfx.DrawString(afdeling, font_antw, XBrushes.Black, margeX + 100, 230);
            gfx.DrawString(ruimte, font_antw, XBrushes.Black, margeX + 100, 250);
            gfx.DrawString("Werkbeschrijving :", font_sub, XBrushes.Black, margeX + 5, 340);
            string[] werkbeschrij = Globaal.FormatTextTwo($"{werkbeschrijving}", font_antw, 290);
            int werkStat = 350;
            for (int i = 0; i < werkbeschrij.Length; i++)
            {
                gfx.DrawString(werkbeschrij[i], font_antw, XBrushes.Black, margeX + 5, werkStat);
                werkStat = werkStat + 10;
            }

            //box4
            gfx.DrawLine(darkLine, margeX, margeY + 420, margeX + 300, margeY + 420);
            gfx.DrawLine(darkLine, margeX, margeY + 490, margeX + 300, margeY + 490);
            gfx.DrawLine(darkLine, margeX, margeY + 420, margeX, margeY + 490);
            gfx.DrawLine(darkLine, margeX + 300, margeY + 420, margeX + 300, margeY + 490);
            //
            gfx.DrawLine(line, margeX + 100, margeY + 420, margeX + 100, margeY + 490);
            gfx.DrawLine(line, margeX + 200, margeY + 420, margeX + 200, margeY + 490);
            gfx.DrawLine(line, margeX + 300, margeY + 420, margeX + 300, margeY + 490);
            //text 4
            gfx.DrawString("Handtekening", font_sub, XBrushes.Black, margeX + 5, 460);
            gfx.DrawString("Handtekening", font_sub, XBrushes.Black, margeX + 105, 460);
            gfx.DrawString("Handtekening", font_sub, XBrushes.Black, margeX + 205, 460);
            gfx.DrawString("UITVOERDER", font_sub, XBrushes.Black, margeX + 5, 470);
            gfx.DrawString("OPDRACHTGEVER", font_sub, XBrushes.Black, margeX + 105, 470);
            gfx.DrawString("PREVENTIEDIENST", font_sub, XBrushes.Black, margeX + 205, 470);

            //box5
            gfx.DrawLine(darkLine, margeX + 300 + margeX, margeY, page.Width - margeX, margeY);
            gfx.DrawLine(darkLine, margeX + 300 + margeX, margeY + 490, page.Width - margeX, margeY + 490);
            gfx.DrawLine(darkLine, margeX + 300 + margeX, margeY, margeX + 300 + margeX, margeY + 490);
            gfx.DrawLine(darkLine, page.Width - margeX, margeY, page.Width - margeX, margeY + 490);
            //
            gfx.DrawLine(darkLine, margeX + 300 + margeX, margeY+60, page.Width - margeX, margeY+60);
            gfx.DrawLine(darkLine, margeX + 300 + margeX, margeY + 330, page.Width - margeX, margeY + 330);
            gfx.DrawLine(darkLine, margeX + 300 + margeX, margeY + 400, page.Width - margeX, margeY + 400);
            //
            gfx.DrawLine(line, margeX + 300 + margeX, margeY + 80, page.Width - margeX, margeY + 80);
            gfx.DrawLine(line, margeX + 300 + margeX, margeY + 350, page.Width - margeX, margeY + 350);
            gfx.DrawLine(line, margeX + 300 + margeX, margeY + 420, page.Width - margeX, margeY + 420);
            //text 5
            gfx.DrawString("Betrokken product :", font_sub, XBrushes.Black, margeX + 335, margeY+15);
            gfx.DrawString(product,font_antw, XBrushes.Black, margeX + 450, margeY + 15);
            gfx.DrawString("Risico:", font_sub, XBrushes.Black, margeX + 335, margeY + 35);

            query = "SELECT risico FROM risico_has_besloten_vergunning " +
                "INNER JOIN risico ON risico_risico_id = risico_id " +
                "WHERE besloten_vergunning_besloten_vergunning_id = @besloten_vergunning_besloten_vergunning_id;";

            int risicoX = 385;
            int risicoY = 35;

            using (var connection = new MySqlConnection(Globaal.user))
            {
                connection.Open();
                var command = new MySqlCommand(query, connection);
                command.Parameters.AddWithValue("@besloten_vergunning_besloten_vergunning_id", besloten_vergunning_id);
                MySqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    // Assuming 'gfx' and 'font_sub' are properly defined
                    gfx.DrawString(reader["risico"].ToString(), font_antw, XBrushes.Black, margeX + risicoX, margeY + risicoY);
                    risicoY = risicoY + 10;

                    if (risicoY > 55)
                    {
                        risicoY = 35;
                        risicoX = risicoX + 150;
                    }
                }
                connection.Close();
            }

            gfx.DrawString("TE NEMEN MAATREGELEN", font_sub, XBrushes.Black, margeX + 490, margeY + 75);
            int maatY = 90;

            // Add spaces between different parts of the SQL query
            query = "SELECT besloten_maatregelen, paraaf FROM maatregelen_has_besloten_vergunningen " +
                    "INNER JOIN besloten_maatregelen ON besloten_maatregelen_besloten_maatregelen_id = besloten_maatregelen_id " +
                    "WHERE besloten_vergunning_besloten_vergunning_id = @besloten_vergunning_besloten_vergunning_id;";

            using (var connection = new MySqlConnection(Globaal.user))
            {
                connection.Open();
                var command = new MySqlCommand(query, connection);
                command.Parameters.AddWithValue("@besloten_vergunning_besloten_vergunning_id", besloten_vergunning_id);
                MySqlDataReader reader = command.ExecuteReader();
                int count = 0;

                while (reader.Read())
                {
                    count++;
                    string[] schrijf = Globaal.FormatTextTwo($"{count}. {reader["besloten_maatregelen"].ToString()} : {reader["paraaf"].ToString()}", font_antw, 447);

                    for (int i = 0; i < schrijf.Length; i++)
                    {
                        gfx.DrawString(schrijf[i], font_antw, XBrushes.Black, margeX + 335, margeY+maatY);

                        if (i + 1 < schrijf.Length)
                            maatY = maatY + 10;
                    }
                    maatY = maatY + 20;
                }
                connection.Close();
            }
            gfx.DrawString("METINGEN IN DE BESLOTEN RUIMTE", font_sub, XBrushes.Black, margeX + 460, margeY + 345);

            int metingY = 360;

            // Add spaces between different parts of the SQL query
            query = "SELECT meting, paraaf FROM meting_has_besloten_vergunnning " +
                    "INNER JOIN metingen ON metingen_metingen_id = metingen_id " +
                    "WHERE besloten_vergunning_besloten_vergunning_id = @besloten_vergunning_besloten_vergunning_id;";

            using (var connection = new MySqlConnection(Globaal.user))
            {
                connection.Open();
                var command = new MySqlCommand(query, connection);
                command.Parameters.AddWithValue("@besloten_vergunning_besloten_vergunning_id", besloten_vergunning_id);
                MySqlDataReader reader = command.ExecuteReader();
                int count = 0;

                while (reader.Read())
                {
                    gfx.DrawString($"{reader["meting"].ToString()} : {reader["paraaf"].ToString()}", font_antw, XBrushes.Black, margeX + 335, margeY + metingY);
                    metingY = metingY + 10;
                }
                connection.Close();
            }

            gfx.DrawString("METINGEN IN PERSOONLIJKE BESCHERMINGSMIDDELEN BESLOTEN RUIMTE", font_sub, XBrushes.Black, margeX + 395, margeY + 415);
            int beschermX = 335;
            int beschermY = 430;
            query = "SELECT beschermiddelen FROM besloten_vergunning_has_beschermiddelen " +
                    "INNER JOIN beschermiddelen ON beschermiddelen_beschermiddelen_id = beschermiddelen_id " +
                    "WHERE besloten_vergunning_besloten_vergunning_id = @besloten_vergunning_besloten_vergunning_id;";

            using (var connection = new MySqlConnection(Globaal.user))
            {
                connection.Open();
                var command = new MySqlCommand(query, connection);
                command.Parameters.AddWithValue("@besloten_vergunning_besloten_vergunning_id", besloten_vergunning_id);
                MySqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    gfx.DrawString(reader["beschermiddelen"].ToString(), font_antw, XBrushes.Black, margeX + beschermX, margeY + beschermY);
                    beschermY = beschermY + 10;

                    if (beschermY > 485)
                    {
                        beschermY = 430;
                        beschermX = beschermX + 150;
                    }
                }
                connection.Close();
            }


            doc.Save($"{Properties.Settings.Default.Work}/besloten_vergunning_{besloten_vergunning_id}.pdf");
        }
    }
}
