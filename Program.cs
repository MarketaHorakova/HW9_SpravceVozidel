
using HW9_SpravceVozidel;
using System.ComponentModel;
using System.Reflection;

SpravceVozidel auto = new SpravceVozidel();
auto.PridaniAuta("auto", 2022, "hneda", 5, "Peugeot, 3008");
auto.PridaniAuta("auto", 2012, "zelena", 3, "Renault, Zafira");
auto.PridaniAuta("auto", 2019, "stribran", 5, "Skoda, Superb");
auto.PridaniAuta("auto", 2019, "Blue", 4 , "Toyota, Camry");
auto.PridaniAuta("auto", 2020, "Red", 2, "Ford, Mustang");
auto.PridaniAuta("auto", 2022, "Silver", 5 , "Honda, Civic");
auto.PridaniAuta("auto", 2018, "Black", 4 , "Chevrolet, Malibu");
auto.PridaniAuta("auto", 2021, "White", 4 , "BMW, 3 Series");
auto.PridaniAuta("auto", 2017, "Gray", 4 , "Volkswagen, Passat");
auto.PridaniAuta("auto", 2023, "Green", 5 , "Tesla, Model Y");
auto.PridaniAuta("auto", 2016, "Yellow", 2 , "Dodge, Challenger");

SpravceVozidel moto = new SpravceVozidel();
moto.PridaniMotorky("moto", 2020, "cervena", 2, "Honda Sport bike");
moto.PridaniMotorky("moto", 2019, "cerna", 2, "Yamaha Cruiser");
moto.PridaniMotorky("moto", 2022, "modra", 2, "Harley-Davidson Touring bike");
moto.PridaniMotorky("moto", 2018, "Green", 2, "Kawasaki Dual Sport");
moto.PridaniMotorky("moto", 2020, "Stribrna", 2, "BMW Naked bike");



auto.ZobrazNaKonzoli();

Console.ReadLine();