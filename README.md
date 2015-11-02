# SandBox
Rinconcillo para testear codigo

####ManejoVariablesEntrePostBack
En ese ejercicio se puede ver un poco que se guarda y donde se guarda entre postbacks y cambios de paginas.
No funciona del todo bien ya que una vez te metes la primera vez y cambias de pagina, la variables de session y cookies
perduran, pero para ver como funciona session, cookie, viewstate y postback si sirve.

Tambien una forma de como manejar los diferentes postbacks creados por un treeview y por los botones capturandolos por
la key de Request.Params[] con el metodo de retorno booleano this.IsPostBack, que se envia con cada llamada a la pagina.

Ahora con Table y treeView Creados mediante HTML y a mano.
