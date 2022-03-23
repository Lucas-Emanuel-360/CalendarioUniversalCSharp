using System;
using System.Reflection;

public class Calendario
{

    public Byte Mes { get; set; }
    public UInt16 Ano { get; set; }

    public Boolean isMesValido()
    {
        if (this.Mes < 13 && this.Mes > 0)
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    public Boolean isAnoValido()
    {
        if (this.Ano <= 9999 && this.Ano >= 1)
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    public string gerarCalendario()
    {
        //recebe da classe
        int yearDate = this.Ano;
        int monthDate = this.Mes;

        //determina a quantidade de dias em determinado mes 
        int dayInMonth = System.DateTime.DaysInMonth(yearDate, monthDate);

        //variaval de controle
        int weekDay = 0;
        string textReturn = "";

        //datatime que recebe os valores solicitados
        DateTime dateTimeExemple = new DateTime(yearDate, monthDate, 1);


        if (dateTimeExemple.ToString("dddd") == "segunda-feira")
        {
            textReturn += "\t";
            weekDay = 2;
        }
        else if (dateTimeExemple.ToString("dddd") == "terça-feira")
        {
            textReturn += "\t\t";
            weekDay = 3;
        }
        else if (dateTimeExemple.ToString("dddd") == "quarta-feira")
        {
            textReturn += "\t\t\t";
            weekDay = 4;
        }
        else if (dateTimeExemple.ToString("dddd") == "quinta-feira")
        {
            textReturn += "\t\t\t\t";
            weekDay = 5;
        }
        else if (dateTimeExemple.ToString("dddd") == "sexta-feira")
        {
            textReturn += "\t\t\t\t\t";
            weekDay = 6;
        }
        else if (dateTimeExemple.ToString("dddd") == "sábado")
        {
            textReturn += "\t\t\t\t\t\t";
            weekDay = 7;
        }
        else
        {
            weekDay = 1;
        }

        for (int i = 1; i <= dayInMonth; i++)
        {
            textReturn += i;
            textReturn += "\t";

            if (weekDay % 7 == 0)
            {
                textReturn += "\n";
            }
            weekDay += 1;
        }

        textReturn += "\n";
        return textReturn;
    }

    public override String ToString()
    {
        return gerarCalendario();
    }
}