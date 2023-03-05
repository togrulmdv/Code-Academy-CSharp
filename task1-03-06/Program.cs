using task1_03_06.Models;

Car LADA = new Car("Green",2005, "LADA", "2107", 40f, 1.6f, 28f);
Car Hyundai = new Car("Silver", 2015, "Hyundai", "SantaFe", 70f, 2.4f, 54f);
LADA.Drive(14);
Hyundai.Drive(12);
LADA.ShowInfo();
Hyundai.ShowInfo();