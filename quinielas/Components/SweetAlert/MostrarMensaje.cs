using System;
using Microsoft.JSInterop;

namespace quinielas.Components.SweetAlert;

public class MostrarMensajes : IMostrarMensajes
{
    private readonly IJSRuntime js;

    public MostrarMensajes(IJSRuntime js)
    {
        this.js = js;
    }

    public async Task<bool> Confirmar(string Mensaje, string Titulo, TipoMensajeSweetAlert tipo)
    {
        return await js.InvokeAsync<bool>("Confirm", Titulo, Mensaje, tipo.ToString());
    }
    public async Task<bool> Error(string Mensaje, string Titulo, TipoMensajeSweetAlert tipo)
    {
        return await js.InvokeAsync<bool>("Error", Titulo, Mensaje, tipo.ToString());
    }
    public async Task<string> Input(string Mensaje, string Titulo, TipoInputSweetAlert input, TipoMensajeSweetAlert tipo, string valor = "", string ValidadorMensaje = "Validar valor")
    {
        return await js.InvokeAsync<string>("InputConfirm", Titulo, Mensaje, input.ToString(), tipo.ToString(), valor, ValidadorMensaje);
    }
    public async Task<bool> SolicitudExitosa(string Mensaje, string Titulo)
    {
        return await js.InvokeAsync<bool>("MenSolicitudExitosa", Titulo, Mensaje);
    }

    public async Task MostrarMensajeError(string mensaje)
    {
        await MostrarMensaje("Error", mensaje, "error");
    }

    public async Task MostrarMensajeExitoso(string mensaje)
    {
        await MostrarMensaje("Exitoso", mensaje, "success");
    }

    private async ValueTask MostrarMensaje(string titulo, string mensaje, string tipoMensaje)
    {
        await js.InvokeVoidAsync("Swal.fire", titulo, mensaje, tipoMensaje);
    }

    public async Task MostrarAlertaExitoAsync(string Mensaje, string Titulo)
    {
        string lottieUrl = "/lottieFiles/Success Send.json";
        string lottieHtml =
        $@"<lottie-player
            src=""{lottieUrl}""
            background=""transparent""
            speed=""1""
            style=""width: 250px; height: 250px; margin: 0 auto;""
            autoplay
            ></lottie-player>";
        await js.InvokeVoidAsync("Swal.fire", new
        {
            title = Titulo,
            html = lottieHtml,
            confirmButtonText = "Ok"
        });
        return;
    }
}