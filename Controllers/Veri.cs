using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.Model;

namespace WebApplication1.Controllers
{
    public class Veri
    {
        public static List<Moda> Getir()
        {
            List<Moda> liste = new List<Moda>
            {
                new Moda()
                {
                    Id = 1,
                    Type = new Model.Type() {Id = 2, Name = "Culture"},
                    ModaTitle = "Kültürü Giymek: Moda Kültürle Buluşunca\r\n",
                    Content = "Kıyafet dediğimiz şey, bir kültürün paylaştığı acı, zafer ve deneyimlerden oluşuyor.\r\n\r Giydiğimiz kıyafetler, toplumların kültürlerine dair kolayca silinemeyen ya da bir kenara atılamayan pek çok şey söylüyor.",
                    Image = new Image() {Id = 1, Height = 20, Width = 20, Name = "moda1.jpg"}
                },
           
            new Moda()
            {
                Id = 2,
                Type = new Model.Type() {Id = 3, Name = "LifeStyle"},
                ModaTitle = "Gelmiş geçmiş en iyi güzellik sırları!",
                Content ="Bu güzellik sırları aynaya bakışınızı değiştirecek! Güzellik, bir bütün olarak algılanır.\r\n\r Kıyafetinizden kokunuza, teninizin dokusundan yüzünüzdeki çizgilere kadar her bir noktanızı içerir. \r\n\rBütünsel güzellik sırlarına göz atın ve güzelliğinizi tamamlayın.",
                Image = new Image() {Id = 2, Height = 20, Width = 20, Name = "Moda-nedir-neden-önemlidir.jpg"}
            }
         };

        return liste;
        }
    }
}
