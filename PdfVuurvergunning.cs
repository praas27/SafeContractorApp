using Google.Protobuf.WellKnownTypes;
using MySql.Data.MySqlClient;
using Org.BouncyCastle.Asn1.Pkcs;
using PdfSharp.Charting;
using PdfSharp.Drawing;
using PdfSharp.Pdf;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace SafeContractorApp
{
    internal class PdfVuurvergunning
    {
       



        public static void GenDoc(int vergunningId)
        {
            int vuurvergunning_id = 0;
            int werknemer_id = 0;
            string werknemer_naam = string.Empty;
            string datum = string.Empty;
            string start_time = string.Empty;
            string end_time = string.Empty;
            string verlenging = string.Empty;
            string bijkomnde_maatregelen = string.Empty;

            

            string query = "SELECT vuurvergunning_vuurvergunning_id,werknemers_werknemer_id FROM vergunning where vegunning_id=@vegunning_id;";
            using (var connection = new MySqlConnection(Globaal.user))
            {
                connection.Open();
                var command = new MySqlCommand(query, connection);
                command.Parameters.AddWithValue("@vegunning_id", vergunningId);
                MySqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    vuurvergunning_id = int.Parse(reader["vuurvergunning_vuurvergunning_id"].ToString());
                    werknemer_id = int.Parse(reader["werknemers_werknemer_id"].ToString());
                }
                connection.Close();
            }

            query = "SELECT werknemer_naam FROM werknemers where werknemer_id=@werknemer_id;";
            using (var connection = new MySqlConnection(Globaal.user))
            {
                connection.Open();
                var command = new MySqlCommand(query, connection);
                command.Parameters.AddWithValue("@werknemer_id", werknemer_id);
                MySqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    werknemer_naam = reader["werknemer_naam"].ToString();
                }
                connection.Close();
            }

            query = "SELECT * FROM vuurvergunning where vuurvergunning_id=@vuurvergunning_id;";
            using (var connection = new MySqlConnection(Globaal.user))
            {
                connection.Open();
                var command = new MySqlCommand(query, connection);
                command.Parameters.AddWithValue("@vuurvergunning_id", vuurvergunning_id);
                MySqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    datum = reader["datum"].ToString().Substring(0, 10);
                    start_time = reader["start_time"].ToString().Substring(0,5);
                    end_time = reader["end_time"].ToString().Substring(0,5);
                    verlenging = reader["verlenging"].ToString();
                    bijkomnde_maatregelen = reader["bijkomnde_maatregelen"].ToString();
                }
                connection.Close();
            }

            //crete page
            PdfDocument doc = new PdfDocument();
            PdfPage page = doc.AddPage();
            XGraphics gfx = XGraphics.FromPdfPage(page);
            //
            int marge = 50;
            XFont titele = new XFont("Calibri", 25);
            XFont font_antw = new XFont("Calibri", 11);
            XFont font_sub = new XFont("Calibri", 11, XFontStyle.Bold);
            XFont font3 = new XFont("Calibri", 12);
            XFont font_Titel = new XFont("Calibri", 20, XFontStyle.Bold);
            XFont font5 = new XFont("Bodoni MT", 11);
            XPen line = new XPen(XColors.Black, 0.5);

            XImage logo = XImage.FromFile($@"{Properties.Settings.Default.Images}\logo.png");

            gfx.DrawString("VUURVERGUNNING", font_Titel, XBrushes.Black, 225, 60);
            gfx.DrawImage(logo, new XRect(marge, 15, logo.Width / 8, logo.Height / 8));

            gfx.DrawLine(line, marge, 30, page.Width - marge, 30);
            gfx.DrawLine(line, marge, 80, page.Width - marge, 80);

            gfx.DrawLine(line, marge, 30, marge, 80);
            gfx.DrawLine(line, 180, 30, 180, 80);
            gfx.DrawLine(line, page.Width - marge- 100, 30, page.Width - marge - 100, 80);
            gfx.DrawLine(line, page.Width - marge, 30, page.Width - marge, 80);

            gfx.DrawString("Naam van de uitvoerder: ", font_sub, XBrushes.Black, marge, 100);
            gfx.DrawString(werknemer_naam, font_antw, XBrushes.Black, marge+125, 100);
            gfx.DrawString("Datum: ", font_sub, XBrushes.Black, marge+ 350, 100);
            gfx.DrawString(datum, font_antw, XBrushes.Black, marge+410, 100);
            gfx.DrawString("Tijd: ", font_sub, XBrushes.Black, marge + 350, 110);
            gfx.DrawString($"van {start_time} tot {end_time}", font_antw, XBrushes.Black, marge + 410, 110);
            gfx.DrawString("Verlenging: ", font_sub, XBrushes.Black, marge + 350, 120);
            gfx.DrawString(verlenging, font_antw, XBrushes.Black, marge + 410, 120);

            gfx.DrawString("Aard van het werk", font_sub, XBrushes.Black, marge, 140);
            gfx.DrawString("Maatregelen", font_sub, XBrushes.Black, marge, 260);
            gfx.DrawString("1. Installatie waaraan gewerkt wordt", font_sub, XBrushes.Black, marge, 280);
            gfx.DrawString("2. Omgeving", font_sub, XBrushes.Black, marge, 400);
            gfx.DrawString("3. Brandbestrijding", font_sub, XBrushes.Black, marge, 520);
            gfx.DrawString("4. Bijkomende maatregelen: ", font_sub, XBrushes.Black, marge, 640);

            gfx.DrawString("Werkbeschrijving", font_sub, XBrushes.Black, marge+200, 140);
            gfx.DrawString("Specificaties", font_sub, XBrushes.Black, marge+200, 260);

            gfx.DrawString("handtekening", font_sub, XBrushes.Black, marge + 50, 720);
            gfx.DrawString("opdrachtgever:", font_sub, XBrushes.Black, marge + 50, 730);
            gfx.DrawString("handtekening", font_sub, XBrushes.Black, marge + 200, 720);
            gfx.DrawString("uitvoerder:", font_sub, XBrushes.Black, marge + 200, 730);
            gfx.DrawString("handtekening", font_sub, XBrushes.Black, marge + 350, 720);
            gfx.DrawString("preventieadviseur:", font_sub, XBrushes.Black, marge + 350, 730);

            int i = 160;
            query = "select * from werken_has_vuurvergunning inner join werken on werken_id=werken_werken_id " +
                "where type=@type and vuurvergunning_vuurvergunning_id=@vuurvergunning_vuurvergunning_id;";
            using (var connection = new MySqlConnection(Globaal.user))
            {
                connection.Open();
                var command = new MySqlCommand(query, connection);
                command.Parameters.AddWithValue("@vuurvergunning_vuurvergunning_id", vuurvergunning_id);
                command.Parameters.AddWithValue("@type", 'A');
                MySqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    gfx.DrawString(reader["werken"].ToString(), font_antw, XBrushes.Black, marge, i);
                    gfx.DrawString(reader["extra"].ToString(), font_antw, XBrushes.Black, marge+200, i);
                    i = i + 10;
                }
                connection.Close();
            }

            i = 300;
            query = "select * from werken_has_vuurvergunning inner join werken on werken_id=werken_werken_id " +
                "where type=@type and vuurvergunning_vuurvergunning_id=@vuurvergunning_vuurvergunning_id;";
            using (var connection = new MySqlConnection(Globaal.user))
            {
                connection.Open();
                var command = new MySqlCommand(query, connection);
                command.Parameters.AddWithValue("@vuurvergunning_vuurvergunning_id", vuurvergunning_id);
                command.Parameters.AddWithValue("@type", 'I');
                MySqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    gfx.DrawString(reader["werken"].ToString(), font_antw, XBrushes.Black, marge, i);
                    gfx.DrawString(reader["extra"].ToString(), font_antw, XBrushes.Black, marge + 200, i);
                    i = i + 10;
                }
                connection.Close();
            }

            i = 420;
            query = "select * from werken_has_vuurvergunning inner join werken on werken_id=werken_werken_id " +
                "where type=@type and vuurvergunning_vuurvergunning_id=@vuurvergunning_vuurvergunning_id;";
            using (var connection = new MySqlConnection(Globaal.user))
            {
                connection.Open();
                var command = new MySqlCommand(query, connection);
                command.Parameters.AddWithValue("@vuurvergunning_vuurvergunning_id", vuurvergunning_id);
                command.Parameters.AddWithValue("@type", 'O');
                MySqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    gfx.DrawString(reader["werken"].ToString(), font_antw, XBrushes.Black, marge, i);
                    gfx.DrawString(reader["extra"].ToString(), font_antw, XBrushes.Black, marge + 200, i);
                    i = i + 10;
                }
                connection.Close();
            }

            i = 540;
            query = "select * from werken_has_vuurvergunning inner join werken on werken_id=werken_werken_id " +
                "where type=@type and vuurvergunning_vuurvergunning_id=@vuurvergunning_vuurvergunning_id;";
            using (var connection = new MySqlConnection(Globaal.user))
            {
                connection.Open();
                var command = new MySqlCommand(query, connection);
                command.Parameters.AddWithValue("@vuurvergunning_vuurvergunning_id", vuurvergunning_id);
                command.Parameters.AddWithValue("@type", 'B');
                MySqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    gfx.DrawString(reader["werken"].ToString(), font_antw, XBrushes.Black, marge, i);
                    gfx.DrawString(reader["extra"].ToString(), font_antw, XBrushes.Black, marge + 200, i);
                    i = i + 10;
                }
                connection.Close();
            }

            string[] tekst = Globaal.FormatText(bijkomnde_maatregelen, font_antw, marge);
            int tekstStart = 660;
            for (int j = 0; j < tekst.Length; j++)
            {
                gfx.DrawString(tekst[j], font_antw, XBrushes.Black, marge, tekstStart);
                tekstStart = tekstStart + 10;
            }

            doc.Save($"{Properties.Settings.Default.Work}/vuurvergunning_{vuurvergunning_id}.pdf");
        }
    }
}
