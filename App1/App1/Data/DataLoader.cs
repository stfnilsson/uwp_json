using System;
using System.Diagnostics;
using System.Threading.Tasks;
using Windows.Storage;

namespace App1.Data
{
    public static class DataLoader
    {
        public static async Task<string> LoadJsonAsync()
        {
            string fileName = "ms-appx:///JsonData/data.json";
            try
            {
                var fileUri = new Uri(fileName);
                var storageFile = await StorageFile.GetFileFromApplicationUriAsync(fileUri).AsTask().ConfigureAwait(false);
                var json = await FileIO.ReadTextAsync(storageFile).AsTask().ConfigureAwait(false);

                return json;

            }
            catch (Exception exception)
            {
                Debug.WriteLine(exception.Message);
                return string.Empty;
            } 
        }
    }
}