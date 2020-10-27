/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package consolejava;

import java.util.Scanner;

/**
 *
 * @author Administrator
 */
public class ConsoleJava {

    /**
     * @param args the command line arguments
     */
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);
        
        int so1 = 0, so2 = 0;
        // Nhập vào hai số
        System.out.print("Nhập số thứ nhất: ");
        so1 = Integer.parseInt( scanner.nextLine() );
        System.out.print("Nhập số thứ hai: ");
        so2 = Integer.parseInt( scanner.nextLine() );
        
        //hiển thị kết quả
        System.out.print("Tổng: " + add(so1, so2));
        
    }

    private static int add(int a, int b) {
        org.tempuri.Service service = new org.tempuri.Service();
        org.tempuri.ServiceSoap port = service.getServiceSoap();
        return port.cong(a, b);
    }

    private static int nhan(int a, int b) {
        org.tempuri.Service service = new org.tempuri.Service();
        org.tempuri.ServiceSoap port = service.getServiceSoap();
        return port.nhan(a, b);
    }
    
}
