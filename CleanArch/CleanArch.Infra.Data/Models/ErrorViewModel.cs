namespace CleanArch.Infra.Data.Models
{
    /// <summary>Modelo usado pela página de erro (Home/Error) para exibir o RequestId.</summary>
    public class ErrorViewModel
    {
        public string? RequestId { get; set; }

        public bool ShowRequestId => !string.IsNullOrEmpty(RequestId);
    }
}
