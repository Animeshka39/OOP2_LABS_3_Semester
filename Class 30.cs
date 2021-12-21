class Transformer(){
    // объявление поля x
    int x

    // объявление метода конструктора (сюда нам чуть ниже передадут 0)
    function constructor(int x){
        // инициализация поля x 
        // (переданный конструктору 0 превращается в свойство объекта)
        this.x = x
    }
	
    // объявление метода run
    function run(){
        // обращение к собственному атрибуту через this
        this.x += 1
    }
}

// а теперь клиентский код:

// создаем новый экземпляр трансформера с начальной позицией 0
optimus = new Transformer(0)

optimus.run() // приказываем Оптимусу бежать
print optimus.x // выведет 1
optimus.run() // приказывает Оптимусу еще раз бежать
print optimus.x // выведет 2



class Gun(){
    // объявление поля x
    int x

    // объявление метода конструктора (сюда нам чуть ниже передадут 0)
    function constructor(int x){
        // инициализация поля x 
        // (переданный конструктору 0 превращается в свойство объекта)
        this.x = x
    }
	
    // объявление метода shoot
    function shoot(){
        // обращение к собственному атрибуту через this
        this.x += 1
    }
}

// а теперь клиентский код:

// создаем новый экземпляр трансформера с начальной позицией 0
gun = new Weapon(0)

gun.shoot() // приказываем gun бежать
print gun.x // выведет 1
gun.shoot() // приказывает gun еще раз бежать
print gun.x // выведет 2

class Ak47(){
    
    int x   
    function constructor(int x){    
        this.x = x
    }
	
    function shoot(){
        this.x += 1
    }
}

Ak47 = new Weapon(0)
Ak47.shoot() 
print Ak47.x 
Ak47.shoot() 
print Ak47.x 


class Kettle(){
    
    int x   
    function constructor(int x){    
        this.x = x
    }
	
    function boil(){
        this.x += 1
    }
}

kettle = new Technique(0)
kettle.boil() 
print kettle.x 
kettle.boil() 
print kettle.x 

class TV(){
    
    int x   
    function constructor(int x){    
        this.x = x
    }
	
    function changechannel(){
        this.x += 1
    }
}

tv = new Technique(0)
tv.changechannel() 
print tv.x 
tv.changechannel() 
print tv.x 

class radio(){
    
    int x   
    function constructor(int x){    
        this.x = x
    }
	
    function changechannel(){
        this.x += 1
    }
}

radio = new Technique(0)
radio.changechannel() 
print radio.x 
radio.changechannel() 
print radio.x 

class Boombox(){
    
    int x   
    function constructor(int x){    
        this.x = x
    }
	
    function changemusic(){
        this.x += 1
    }
}

boombox = new Technique(0)
boombox.changemusic() 
print boombox.x 
boombox.changemusic() 
print boombox.x 

class Smartphone(){
    
    int x   
    function constructor(int x){    
        this.x = x
    }
	
    function changemusic(){
        this.x += 1
    }
}

smartphone = new Technique(0)
smartphone.changemusic() 
print smartphone.x 
smartphone.changemusic() 
print smartphone.x 

class Phone(){
    
    int x   
    function constructor(int x){    
        this.x = x
    }
	
    function call(){
        this.x += 1
    }
}

phone = new Technique(0)
phone.call() 
print phone.x 
phone.call() 
print phone.x 

class Laptop(){
    
    int x   
    function constructor(int x){    
        this.x = x
    }
	
    function close(){
        this.x += 1
    }
}

laptop = new Technique(0)
laptop.close() 
print laptop.x 
laptop.close() 
print laptop.x 

class Chestofdrawers(){
    
    int x   
    function constructor(int x){    
        this.x = x
    }
	
    function close(){
        this.x += 1
    }
}

chestofdrawers = new Furniture(0)
chestofdrawers.close() 
print chestofdrawers.x 
chestofdrawers.close() 
print chestofdrawers.x 

class Mouth(){
    
    int x   
    function constructor(int x){    
        this.x = x
    }
	
    function close(){
        this.x += 1
    }
}

mouth = new Partofbody(0)
mouth.close() 
print mouth.x 
mouth.close() 
print mouth.x 

class Eye(){
    
    int x   
    function constructor(int x){    
        this.x = x
    }
	
    function close(){
        this.x += 1
    }
}

eye = new Partofbody(0)
eye.close() 
print eye.x 
eye.close() 
print eye.x 

class Knife(){
    
    int x   
    function constructor(int x){    
        this.x = x
    }
	
    function slash(){
        this.x += 1
    }
}

knife = new Weapon(0)
knife.slash() 
print knife.x 
knife.slash() 
print knife.x 

class Headphones(){
    
    int x   
    function constructor(int x){    
        this.x = x
    }
	
    function changemusic(){
        this.x += 1
    }
}

headphones = new Technique(0)
headphones.changemusic() 
print headphones.x 
headphones.changemusic() 
print headphones.x 

class Wifirouter(){
    
    int x   
    function constructor(int x){    
        this.x = x
    }
	
    function reset(){
        this.x += 1
    }
}

wifirouter = new Technique(0)
wifirouter.reset() 
print wifirouter.x 
wifirouter.reset() 
print wifirouter.x 

class Killer(){
    
    int x   
    function constructor(int x){    
        this.x = x
    }
	
    function kill(){
        this.x += 1
    }
}

killer = new Occupation(0)
killer.kill() 
print killer.x 
killer.kill() 
print killer.x 

class Bodyguard(){
    
    int x   
    function constructor(int x){    
        this.x = x
    }
	
    function protect(){
        this.x += 1
    }
}

bodyguard = new Occupation(0)
bodyguard.protect() 
print bodyguard.x 
bodyguard.protect() 
print bodyguard.x 

class Policeman(){
    
    int x   
    function constructor(int x){    
        this.x = x
    }
	
    function protect(){
        this.x += 1
    }
}

policeman = new Occupation(0)
policeman.protect() 
print policeman.x 
policeman.protect() 
print policeman.x 

class Realestateagent(){
    
    int x   
    function constructor(int x){    
        this.x = x
    }
	
    function lie(){
        this.x += 1
    }
}

realestateagent = new Occupation(0)
realestateagent.lie() 
print realestateagent.x 
realestateagent.lie() 
print realestateagent.x 

class Politician(){
    
    int x   
    function constructor(int x){    
        this.x = x
    }
	
    function lie(){
        this.x += 1
    }
}

politician = new Occupation(0)
politician.lie() 
print politician.x 
politician.lie() 
print politician.x 

class Printer(){
    
    int x   
    function constructor(int x){    
        this.x = x
    }
	
    function print(){
        this.x += 1
    }
}

printer = new Technique(0)
printer.print() 
print printer.x 
printer.print() 
print printer.x 

class Printer(){
    
    int x   
    function constructor(int x){    
        this.x = x
    }
	
    function print(){
        this.x += 1
    }
}

printer = new Technique(0)
printer.print() 
print printer.x 
printer.print() 
print printer.x 

class Refrigerator(){
    
    int x   
    function constructor(int x){    
        this.x = x
    }
	
    function cooling(){
        this.x += 1
    }
}

refrigerator = new Technique(0)
refrigerator.cooling() 
print refrigerator.x 
refrigerator.cooling() 
print refrigerator.x 

class Washingmachine(){
    
    int x   
    function constructor(int x){    
        this.x = x
    }
	
    function wash(){
        this.x += 1
    }
}

washingmachine = new Technique(0)
washingmachine.wash() 
print washingmachine.x 
washingmachine.wash() 
print washingmachine.x 

class Lightbulb(){
    
    int x   
    function constructor(int x){    
        this.x = x
    }
	
    function light(){
        this.x += 1
    }
}

lightbulb = new Technique(0)
lightbulb.light() 
print lightbulb.x 
lightbulb.light() 
print lightbulb.x 

class Phonecharger(){
    
    int x   
    function constructor(int x){    
        this.x = x
    }
	
    function charge(){
        this.x += 1
    }
}

phonecharger = new Technique(0)
phonecharger.charge() 
print phonecharger.x 
phonecharger.charge() 
print phonecharger.x 

class Machinegun(){
    
    int x   
    function constructor(int x){    
        this.x = x
    }
	
    function reload(){
        this.x += 1
    }
}

machinegun = new Weapon(0)
machinegun.reload() 
print machinegun.x 
machinegun.reload() 
print machinegun.x 

class Sniperrifle(){
    
    int x   
    function constructor(int x){    
        this.x = x
    }
	
    function reload(){
        this.x += 1
    }
}

sniperrifle = new Weapon(0)
sniperrifle.reload() 
print machinegun.x 
sniperrifle.reload() 
print sniperrifle.x 

class Sun(){
    
    int x   
    function constructor(int x){    
        this.x = x
    }
	
    function shine(){
        this.x += 1
    }
}

sun = new Star(0)
sun.shine() 
print sun.x 
sun.shine() 
print sun.x 

class Boiler(){
    
    int x   
    function constructor(int x){    
        this.x = x
    }
	
    function boil(){
        this.x += 1
    }
}

boiler = new Technique(0)
boiler.boil() 
print boiler.x 
boiler.boil() 
print boiler.x 

class Microwave(){
    
    int x   
    function constructor(int x){    
        this.x = x
    }
	
    function heat(){
        this.x += 1
    }
}

microwave = new Technique(0)
microwave.heat() 
print microwave.x 
microwave.heat() 
print microwave.x 

class Scanner(){
    
    int x   
    function constructor(int x){    
        this.x = x
    }
	
    function scan(){
        this.x += 1
    }
}

scanner = new Technique(0)
scanner.scan() 
print scanner.x 
scanner.scan() 
print scanner.x 

class Alarmclock(){
    
    int x   
    function constructor(int x){    
        this.x = x
    }
	
    function alarm(){
        this.x += 1
    }
}

alarmclock = new Technique(0)
alarmclock.alarm() 
print alarmclock.x 
alarmclock.alarm() 
print alarmclock.x 