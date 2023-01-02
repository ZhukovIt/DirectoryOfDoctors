

namespace DirectoryOfDoctors.Classes.PhotoDB
{
    internal class ImageFromDB
    {
        public string FileName { get; set; }
        public string Title { get; set; }
        public byte[] Data { get; set; }

        public ImageFromDB(string fileName, string title, byte[] data)
        {
            FileName = fileName;
            Title = title;
            Data = data;
        }

    }
}
