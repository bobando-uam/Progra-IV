namespace Calculadora_D_202020051140.Models
{
    public class CalculatorControlViewModel
    {
        private string _Salario = String.Empty;
        private string _SalarioNeto = String.Empty;
        private string _SeguroCCSS = String.Empty;
        private string _SalarioBruto = String.Empty;
        private string _IptoMH = String.Empty;
        private string _TotalDeducciones = String.Empty;

        public string carnet {  get; set; }
        public string Salario { get => _Salario; set => _Salario = value; }
        public string SalarioNeto { get => _SalarioNeto; set => _SalarioNeto = value; }
        public string SeguroCCSS { get => _SeguroCCSS; set => _SeguroCCSS = value; }
        public string SalarioBruto { get => _SalarioBruto; set => _SalarioBruto = value; }
        public string IptoMH { get => _IptoMH; set => _IptoMH = value; }
        public string TotalDeducciones { get => _TotalDeducciones; set => _TotalDeducciones = value; }

        

        public double calculoSalario()
        {
            
            var calc = Convert.ToDouble(_Salario);
            if (calc < 900000)
            {
                _SeguroCCSS = (Convert.ToDouble(_Salario) * .13).ToString();
                _SalarioNeto = (Convert.ToDouble(_Salario) - Convert.ToDouble(_SeguroCCSS)).ToString();
                _SalarioBruto = "₡" + _Salario;
                _TotalDeducciones = _SeguroCCSS;
                _IptoMH = "0";
            }
            else if (calc >= 900000 && calc < 1200000)
            {
                _SalarioBruto = "₡" + _Salario;
                _SeguroCCSS = (Convert.ToDouble(_Salario) * 0.13).ToString();
                _IptoMH = (Convert.ToDouble(_Salario) * 0.10).ToString();
                _TotalDeducciones = (Convert.ToDouble(_IptoMH) + Convert.ToDouble(_SeguroCCSS)).ToString();
                _SalarioNeto = (Convert.ToDouble(_Salario) - Convert.ToDouble(_TotalDeducciones)).ToString();
            }
            else if (calc >= 1200000 && calc < 2400000)
            {
                _SalarioBruto = "₡" + _Salario;
                _SeguroCCSS = (Convert.ToDouble(_Salario) * 0.13).ToString();
                _IptoMH = (Convert.ToDouble(_Salario) * 0.15).ToString();
                _TotalDeducciones = (Convert.ToDouble(_IptoMH) + Convert.ToDouble(_SeguroCCSS)).ToString();
                _SalarioNeto = (Convert.ToDouble(_Salario) - Convert.ToDouble(_TotalDeducciones)).ToString();
            }
            else if (calc >= 2400000 && calc < 4500000)
            {
                _SalarioBruto = "₡" + _Salario;
                _SeguroCCSS = (Convert.ToDouble(_Salario) * 0.13).ToString();
                _IptoMH = (Convert.ToDouble(_Salario) * 0.20).ToString();
                _TotalDeducciones = (Convert.ToDouble(_IptoMH) + Convert.ToDouble(_SeguroCCSS)).ToString();
                _SalarioNeto = (Convert.ToDouble(_Salario) - Convert.ToDouble(_TotalDeducciones)).ToString();
            }
            else if (calc >= 4500000)
            {
                _SalarioBruto = "₡" + _Salario;
                _SeguroCCSS = (Convert.ToDouble(_Salario) * 0.13).ToString();
                _IptoMH = (Convert.ToDouble(_Salario) * 0.25).ToString();
                _TotalDeducciones = (Convert.ToDouble(_IptoMH) + Convert.ToDouble(_SeguroCCSS)).ToString();
                _SalarioNeto = (Convert.ToDouble(_Salario) - Convert.ToDouble(_TotalDeducciones)).ToString();
            }
            return Convert.ToDouble(SalarioNeto);
        }
    }
}