using DesafioPOO.Models;

// TODO: Realizando os testes com as classes Nokia e Iphone
IPhone iPhone = new IPhone("21988812347", "iPhone 12", "IMEI123", 123);
iPhone.InstalarAplicativo("WhatsApp");

Nokia nokia = new Nokia("21988876543", "g11 plus", "IMEI455", 321);
nokia.InstalarAplicativo("Telegram");