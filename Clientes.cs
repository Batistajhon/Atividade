namespace Atividade
{
    class Clientes
    {
        public string Nome {get; set;}
        public string Endereço {get; set;}
        public float Valor {get; protected set;}
        public float Valor_imposto {get; protected set;}
        public float Total {get; protected set;}

        public virtual void Pagar_imposto(float v)
        {
            this.Valor = v;
            this.Valor_imposto = this.Valor * 10/100;
            this.Total = this.Valor + this.Valor_imposto;
        }
    }
}