

namespace WeFiBox.Web
{
    /// <summary>
    /// Directories of the application
    /// </summary>
    public class Settings
    {
        /// <summary>
        /// Directory for the uploads in the local file system
        /// </summary>
        public string UploadDir { get; set; }

        /// <summary>
        /// Directory for resized photos on local file system
        /// </summary>
        public string ResizedDir {get; set;}

        /// <summary>
        /// Flag if the file system is alphabetical or requires sorting
        /// </summary>
        public bool AlphabeticalFileSystem {get; set; }
    }
}