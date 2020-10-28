/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package code;

import javax.jws.WebService;
import javax.jws.WebMethod;
import javax.jws.WebParam;

/**
 *
 * @author Hoc vien
 */
@WebService(serviceName = "NewWebService")
public class NewWebService {

    /**
     * Web service operation
     */
    @WebMethod(operationName = "uocSo")
    public String uocSo(int n) {
        String sms = "Ước số:";
        int sum = 0;
        for(int i=1; i<n; i++) {
            if(n%i==0) {
                sum += i;
                sms += " " + i;
            }
        }
        sms += " Tổng các ước số: " + sum;
        return sms;
    }

    /**
     * Web service operation
     */
    @WebMethod(operationName = "uocSoLe")
    public String uocSoLe(int n) {
        String sms = "Ước số lẻ:";
        int sum = 0;
        for(int i=1; i<n; i++) {
            if(n%i==0 && i%2!=0) {
                sum += i;
                sms += " " + i;
            }
        }
        sms += " Tổng các ước số: " + sum;
        return sms;
    }

    /**
     * Web service operation
     */
    @WebMethod(operationName = "uocSoChan")
    public String uocSoChan(int n) {
        String sms = "Ước số chẵn:";
        int tich = 1;
        for(int i=1; i<n; i++) {
            if(n%i==0 && i%2==0) {
                tich *= i;
                sms += " " + i;
            }
        }
        sms += " Tổng các ước số: " + tich;
        return sms;
    }
    
    
    
}
