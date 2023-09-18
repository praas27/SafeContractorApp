using MySql.Data.MySqlClient;
using PdfSharp.Drawing;
using PdfSharp.Pdf;
using PdfSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SafeContractorApp
{
    internal class PdfBeslotenvergunning
    {
        public static void GenDoc(int vergunningId)
        {
            int besloten_vergunning_id = 0;
            string datum = string.Empty;
            string start_time = string.Empty;
            string end_time = string.Empty;
            string afdeling = string.Empty;
            string leiding = string.Empty;
            string product = string.Empty;
            string werkbeschrijving = string.Empty;
            string kopie = string.Empty;
            string uitvoerder = string.Empty;
            int werknemer_id = 0;
            string werknemer_naam = string.Empty;

            string query = "SELECT besloten_vergunning_besloten_vergunning_id,werknemers_werknemer_id FROM vergunning where vegunning_id=@vegunning_id;";
            using (var connection = new MySqlConnection(Globaal.user))
            {
                connection.Open();
                var command = new MySqlCommand(query, connection);
                command.Parameters.AddWithValue("@vegunning_id", vergunningId);
                MySqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    besloten_vergunning_id = int.Parse(reader["besloten_vergunning_besloten_vergunning_id"].ToString());
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

            query = "SELECT * FROM besloten_vergunning where besloten_vergunning_id=@besloten_vergunning_id;";
            using (var connection = new MySqlConnection(Globaal.user))
            {
                connection.Open();
                var command = new MySqlCommand(query, connection);
                command.Parameters.AddWithValue("@besloten_vergunning_id", besloten_vergunning_id);
                MySqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                   /* datum = reader["datum"].ToString().Substring(0, 10);
                    start_time = reader["start_time"].ToString().Substring(0, 5);
                    end_time = reader["eind_time"].ToString();
                    afdeling = reader["afdeling"].ToString();
                    leiding = reader["leiding"].ToString();
                    product = reader["product"].ToString();
                    werkbeschrijving = reader["werkbeschrijving"].ToString();
                    kopie = reader["kopie"].ToString();
                    uitvoerder = reader["uitvoerder"].ToString();*/
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

            //box 1
            gfx.DrawLine(darkLine, margeX, margeY, margeX + 300, margeY);
            gfx.DrawLine(darkLine, margeX, margeY + 60, margeX + 300, margeY + 60);
            gfx.DrawLine(darkLine, margeX, margeY, margeX, margeY + 60);
            gfx.DrawLine(darkLine, margeX + 300, margeY, margeX + 300, margeY + 60);
            //
            gfx.DrawLine(line, margeX + 140, margeY, margeX + 140, margeY + 60);
            gfx.DrawLine(line, margeX + 300 - 60, margeY, margeX + 300 - 60, margeY + 60);


            //box2
            gfx.DrawLine(darkLine, margeX, margeY + 80, margeX + 300, margeY + 80);
            gfx.DrawLine(darkLine, margeX, margeY + 140, margeX + 300, margeY + 140);
            gfx.DrawLine(darkLine, margeX, margeY + 80, margeX, margeY + 140);
            gfx.DrawLine(darkLine, margeX + 300, margeY + 80, margeX + 300, margeY + 140);
            //
            gfx.DrawLine(line, margeX + 150, margeY + 80, margeX + 150, margeY + 140);

            //box3
            gfx.DrawLine(darkLine, margeX, margeY + 160, margeX + 300, margeY + 160);
            gfx.DrawLine(darkLine, margeX, margeY + 400, margeX + 300, margeY + 400);
            gfx.DrawLine(darkLine, margeX, margeY + 160, margeX, margeY + 400);
            gfx.DrawLine(darkLine, margeX + 300, margeY + 160, margeX + 300, margeY + 400);
            //
            gfx.DrawLine(line, margeX, margeY + 180, margeX + 300, margeY + 180);
            gfx.DrawLine(line, margeX, margeY + 290, margeX + 300, margeY + 290);

            //box4
            gfx.DrawLine(darkLine, margeX, margeY + 420, margeX + 300, margeY + 420);
            gfx.DrawLine(darkLine, margeX, margeY + 490, margeX + 300, margeY + 490);
            gfx.DrawLine(darkLine, margeX, margeY + 420, margeX, margeY + 490);
            gfx.DrawLine(darkLine, margeX + 300, margeY + 420, margeX + 300, margeY + 490);
            //
            gfx.DrawLine(line, margeX + 100, margeY + 420, margeX + 100, margeY + 490);
            gfx.DrawLine(line, margeX + 200, margeY + 420, margeX + 200, margeY + 490);
            gfx.DrawLine(line, margeX + 300, margeY + 420, margeX + 300, margeY + 490);

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

            doc.Save($"{Properties.Settings.Default.Work}/besloten_vergunning_{besloten_vergunning_id}.pdf");
        }
    }
}
