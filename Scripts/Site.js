$('#btnGoogleLogin').click(function () {
    window.location.href = "/api/Account/ExternalLogin?provider=Google&response_type=token&client_id=self&redirect_uri=https%3A%2F%2Flocalhost%3A44315%2FAdmin%2FLogin.cshtml&state=GerGr5JlYx4t_KpsK57GFSxVueteyBunu02xJTak5m01";
});
$('#btnFacebookLogin').click(function () {
    window.location.href = "/api/Account/ExternalLogin?provider=Facebook&response_type=token&client_id=self&redirect_uri=https%3A%2F%2Flocalhost%3A44315%2FAdmin%2FLogin.cshtml&state=GerGr5JlYx4t_KpsK57GFSxVueteyBunu02xJTak5m01";

});