using System;

namespace PP
{
    public class Notificador
    {
        private List<ISuscriptor> suscriptores = new List<ISuscriptor>();
        private Clima mainState;
        private static Notificador instance = null;

        private Notificador(Clima mainState)
        {
            this.mainState = mainState;
        }

        public static Notificador getInstance(Clima mainState)
        {
            Notificador instanceLocal;
            if (Notificador.instance == null)
            {
                instanceLocal = new Notificador(mainState);
                Notificador.instance = instanceLocal;
                return instanceLocal;
            }
            else
                return Notificador.instance;
        }
        public void suscribirse(ISuscriptor sub)
        {
            this.suscriptores.Add(sub);
        }
        public void desuscribirse(ISuscriptor sub)
        {
            this.suscriptores.Remove(sub);
        }
        public void notificarSuscriptores()
        {
            foreach (ISuscriptor sub in suscriptores)
            {
                sub.actualizar(this.mainState.Temperatura);
            }
        }

    }
}
