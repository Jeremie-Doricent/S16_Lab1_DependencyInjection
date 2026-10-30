namespace ZombieParty.Utility
{
    public class ImageFileManager : IImageFileManager
    {
        public ImageFileManager() { }

        public string? UploadImage(IFormCollection form, bool edit, string? oldImagePath = null)
        {
            // Vous devez copier la logique du contrôleur à cet endroit


            // Vous devez retourner fileName + extension quand files.Count est plus grand que 0 

            // Sinon on retourne l’ancien imagePath
            return oldImagePath;
        }
    }
    
}
