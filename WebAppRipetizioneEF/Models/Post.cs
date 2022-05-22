using System.ComponentModel.DataAnnotations;

namespace WebAppRipetizioneEF.Models
{
    public class Post
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Il campo titolo è obbligatorio")]
        [StringLength(100, ErrorMessage = "Il titolo non può avere più di 100 caratteri")]
        public string Title { get; set; }

        [Required(ErrorMessage = "Il campo descrizione è obbligatorio")]
        public string Description { get; set; }

        [Required(ErrorMessage = "L'URL dell'immagine è obbligatorio")]
        [Url(ErrorMessage = "L'Url inserito non è valido")]

        public string Image { get; set; }


        public Post()
        {

        }

        public Post(int id, string title, string description, string image)
        {
            this.Id = id;
            this.Title = title;
            this.Description = description;
            this.Image = image;
        }
    }



}
