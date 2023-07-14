
using Microsoft.AspNetCore.Mvc;

namespace GestorNoticias.Models
{
    public class NoticiaRepository
    {
        private static List<Noticia> noticias = new List<Noticia>();

        public static void AgregarNoticia(Noticia noticia)
        {
            noticias.Add(noticia);
        }

        public static List<Noticia> ObtenerNoticiasPorCategoria(string categoria)
        {
            return noticias.Where(n => n.Categoria == categoria).ToList();
        }
    }

}
