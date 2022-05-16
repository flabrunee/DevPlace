using PP;

Youtube y1 = new Youtube("roman10");
Youtube y2 = new Youtube("paolo");
Mail m1 = new Mail("dkasjdas@hotmail.com");
Mail m2 = new Mail("chucky@gmail.com");

Clima clima = new Clima(15.5, 70);
Clima clima2 = new Clima(50.33, 20);

Notificador notificador = Notificador.getInstance(clima);
Notificador notificador2 = Notificador.getInstance(clima2);

notificador.suscribirse(y1);
notificador.suscribirse(m1);
notificador2.suscribirse(y2);
notificador2.suscribirse(m2);
//notificador.notificarSuscriptores();
notificador2.notificarSuscriptores();
Console.WriteLine("////////////// actualizo temperatura");
clima.temperatura = 20;
notificador.notificarSuscriptores();
/*notificador.desuscribirse(y2);
Console.WriteLine("//////////////");
notificador.notificarSuscriptores();*/