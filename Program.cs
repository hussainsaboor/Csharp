using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Base64
{
    class Program
    {
        static void Main(string[] args)
        {
            string base64Str=Tobase64String("<?xml version='1.0' encoding='utf-16'?><VpAccountDetailResponse xmlns:xsi='http://www.w3.org/2001/XMLSchema-instance' xmlns:xsd='http://www.w3.org/2001/XMLSchema'><ExtensionData /><Header><ExtensionData /><ExternalReferenceNumber>20190114182711</ExternalReferenceNumber><IsSuccess>true</IsSuccess><MsgDateTime>20190114182620</MsgDateTime><MsgIdentifier>ea8ea5b6-777d-4c74-926d-f7a4a50fc6b7</MsgIdentifier><MsgWarningDescEN>Simulation Data</MsgWarningDescEN></Header><CASAAccount><ExtensionData /><AccountDescription>01103-HEKIMA SAVINGS ACCOUNT</AccountDescription><AccountHolderName>SADIKI MAONYESHO MATUMIZI</AccountHolderName><AccountNumber>01109512191700</AccountNumber><AvailableBalanceInAccountCurrency>123.0</AvailableBalanceInAccountCurrency><AvailableBalanceInLocalCurrency>0</AvailableBalanceInLocalCurrency><BookBalanceInAccountCurrency>123.0</BookBalanceInAccountCurrency><BookBalanceInLocalCurrency>0</BookBalanceInLocalCurrency><DataItem /><DoesHoldExist>false</DoesHoldExist><IsCreditAllowed>false</IsCreditAllowed><IsDebitAllowed>false</IsDebitAllowed><IsDormantAccount>false</IsDormantAccount><IsFrozenAccount>false</IsFrozenAccount><OverdraftLimit>0</OverdraftLimit><TotalHoldAmount>0</TotalHoldAmount><UnclearedBalanceInAccountCurrency>0</UnclearedBalanceInAccountCurrency><UnclearedBalanceInLocalCurrency>0</UnclearedBalanceInLocalCurrency><Address /><AverageBalance>1234.5</AverageBalance><BlockedAmount>99.9</BlockedAmount><TotalAmount>0</TotalAmount></CASAAccount><ClearedBalance>0</ClearedBalance></VpAccountDetailResponse>");
           string actual= FromBase64(base64Str);
           Console.WriteLine(actual);
        }

        private static string Tobase64String(string txt)
        {
            byte[] textByte = System.Text.Encoding.UTF32.GetBytes(txt);
            return System.Convert.ToBase64String(textByte);
        }

        private static string FromBase64(string base64str)
        {
            byte[] str = System.Convert.FromBase64String(base64str);
            return System.Text.Encoding.UTF32.GetString(str);
        }
    }
}
