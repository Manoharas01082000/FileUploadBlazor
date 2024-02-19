using BlazorInputFile;

namespace FileUploadBlazor.Services
{
    public interface IFileUpload
    {
        Task Upload(IFileListEntry file);

    }
}
