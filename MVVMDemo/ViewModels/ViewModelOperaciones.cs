using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace MVVMDemo.ViewModels
{
    public class ViewModelOperaciones :ViewModelBase
    {

        #region  Atributos
        int valorA;
        public int ValorA
        {
            get { return valorA; }
            set
            {
                if (valorA != value)
                {
                    valorA = value;
                    OnPropertyChanged();
                }
            }
        }

        int valorB;
        public int ValorB
        {
            get { return valorB; }
            set
            {
                if (valorB != value)
                {
                    valorB = value;
                    OnPropertyChanged();
                }
            }
        }

        string message;
        public string Message
        {
            get { return message; }
            set
            {
                if (message != value)
                {
                    message = value;
                    OnPropertyChanged();
                }
            }
        }

        int operacion;
        public int Operacion {
            get { return operacion; }
            set {
                if (operacion != value) 
                {
                    operacion = value;
                    OnPropertyChanged();
                }
            }
        }


        #endregion

        public ICommand Sumar { protected set; get; }
        public ICommand Restar { protected set; get; }
        public ICommand Multiplicar { protected set; get; }
        public ICommand Dividir { protected set; get; }



        public ViewModelOperaciones()
        {
            //OPERACIONES 

            Sumar = new Command(() =>
            {
                Operacion = ValorA + ValorB;
                Message = "";
            });

            Restar = new Command(() =>
            {
                Operacion = ValorA - ValorB;
                Message = "";
            });

            Multiplicar = new Command(() =>
            {
                Operacion = ValorA * ValorB;
                Message = "";
            });


            Dividir = new Command(() =>
            {
                if (ValorB != 0)
                {
                    Operacion = ValorA / ValorB;
                    Message = "";

                }
                else {
                   operacion = 0;
                    Message = "No existe division entre 0";
                };

            });

        }       
    }
}
