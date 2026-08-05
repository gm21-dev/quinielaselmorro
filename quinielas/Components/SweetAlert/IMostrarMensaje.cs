using System;

namespace quinielas.Components.SweetAlert;

public interface IMostrarMensajes
{
    Task MostrarMensajeError(string Mensaje);
    Task MostrarMensajeExitoso(string Mensaje);
    Task<bool> Confirmar(string Mensaje, string Titulo, TipoMensajeSweetAlert tipo);
    Task<bool> Error(string Mensaje, string Titulo, TipoMensajeSweetAlert tipo);
    Task<string> Input(string Mensaje, string Titulo, TipoInputSweetAlert input, TipoMensajeSweetAlert tipo, string valor = "", string ValidadorMensaje = "Validar valor");
    Task<bool> SolicitudExitosa(string Mensaje, string Titulo);
    Task MostrarAlertaExitoAsync(string Mensaje, string Titulo);
}
public enum TipoMensajeSweetAlert
{
    warning, error, success, info, question
}
public enum TipoInputSweetAlert
{
    text, email, password, number, tel, range, textarea, select, radio, checkbox, file, url
}
