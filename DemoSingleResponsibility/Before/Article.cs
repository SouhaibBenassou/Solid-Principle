
namespace DemoSingleResponsibility.Before
{
    public class Article
    { 
        public int Id { get; set; } 
        public string Title { get; set; }  = string.Empty;
        public string Description { get; set; } = string.Empty;

        public void SaveToDB()
        {

        }
        public void SendResponseToClient ()
        {
            
        }
    }
}
