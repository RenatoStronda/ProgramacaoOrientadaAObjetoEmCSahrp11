// See https://aka.ms/new-console-template for more information
using System;
class Program {
  public static void Main (string[] args) {
    Porta porta1 = new Porta(false, "210x90");
    Porta porta2 = new Porta(true, "210x80");
    Porta porta3 = new Porta(true, "210x70");
    Casa casa = new Casa("Azul", porta1, porta2, porta2); 
    Console.WriteLine(casa.quantasPortasEstaoAbertas());
    casa.getPorta1().abre_fecha(true);
    casa.getPorta2().abre_fecha(true);
    casa.getPorta3().abre_fecha(true); 
    casa.pinta("Verde");
    Console.WriteLine(casa.quantasPortasEstaoAbertas()); 
    casa.getPorta1().abre_fecha(false);
    casa.getPorta2().abre_fecha(false);
    casa.getPorta3().abre_fecha(false);
    Console.WriteLine(casa.quantasPortasEstaoAbertas());     
  }
}
class Casa{
  public String cor;
  public Porta porta1;
  public Porta porta2;
  public Porta porta3;

public Casa(string cor, Porta porta1, Porta porta2, Porta porta3){
  this.cor = cor;
  this.porta1 = porta1;
  this.porta2 = porta2;
  this.porta3 = porta3;
}

public void pinta(string cor){
  this.cor = cor;
}

public Porta getPorta1(){
  return this.porta1;
}     
    
public Porta getPorta2(){
  return this.porta2;
}         
    
public Porta getPorta3(){
  return this.porta3;
}         

public String getCor(){
  return this.cor;
}

public int quantasPortasEstaoAbertas(){
  int portasabertas = 0;
  if (porta1.isAberta()) portasabertas++;
  if (porta2.isAberta()) portasabertas++;
  if (porta3.isAberta()) portasabertas++;
  return portasabertas;        
}
}

public class Porta{
  private bool aberta;
  private String tamanho;
  
public Porta(bool aberta, String tamanho){
  this.aberta = aberta;
  this.tamanho = tamanho;
}
    
public void abre_fecha(bool abre_fecha){
  this.aberta = abre_fecha;
}
    
public bool isAberta(){
  return this.aberta;
}
}