using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
namespace NcMaster
{
    public class WebCEP
    {
        #region "Váriavies"  
        string _uf;
        string _city;
        string _district;
        string _typeStreet;
        string _street;
        string _result;
        string _result_txt;
        #endregion

        #region "Propiedades"  
        public string UF
        {
            get { return _uf; }
        }
        public string City
        {
            get { return _city; }
        }
        public string District
        {
            get { return _district; }
        }
        public string TypeStreet
        {
            get { return _typeStreet; }
        }
        public string Street
        {
            get { return _street; }
        }
        public string Result
        {
            get { return _result; }
        }
        public string ResultTxt
        {
            get { return _result_txt; }
        }
        #endregion
        #region "Construtor"  
        /// <summary>  
        /// WebService para Busca de CEP  
        ///  </summary>  
        /// <param  name="CEP"></param>  
        public WebCEP(string CEP)
        {
            try
            {
                _uf = "";
                _city = "";
                _district = "";
                _typeStreet = "";
                _street = "";
                _result = "0";
                _result_txt = "CEP não encontrado";

                DataSet ds = new DataSet();
                ds.ReadXml("http://cep.republicavirtual.com.br/web_cep.php?cep=" + CEP.Replace("-", "").Trim() + "&formato=xml");

                if (ds != null)
                {
                    if (ds.Tables[0].Rows.Count > 0)
                    {
                        _result = ds.Tables[0].Rows[0]["resultado"].ToString();
                        switch (_result)
                        {
                            case "1":
                                _uf = ds.Tables[0].Rows[0]["uf"].ToString().Trim();
                                _city = ds.Tables[0].Rows[0]["cidade"].ToString().Trim();
                                _district = ds.Tables[0].Rows[0]["bairro"].ToString().Trim();
                                _typeStreet = ds.Tables[0].Rows[0]["tipo_logradouro"].ToString().Trim();
                                _street = ds.Tables[0].Rows[0]["logradouro"].ToString().Trim();
                                _result_txt = "CEP completo";
                                break;
                            case "2":
                                _uf = ds.Tables[0].Rows[0]["uf"].ToString().Trim();
                                _city = ds.Tables[0].Rows[0]["cidade"].ToString().Trim();
                                _district = "";
                                _typeStreet = "";
                                _street = "";
                                _result_txt = "CEP  único";
                                break;
                            default:
                                _uf = "";
                                _city = "";
                                _district = "";
                                _typeStreet = "";
                                _street = "";
                                _result_txt = "CEP não  encontrado";
                                break;
                        }
                    }
                }

            }
            catch (Exception)
            {
            }
        }
        #endregion
    }
}