//методы и их виды 

//данный метод не принимает аргументы и ни чего не возвращает, выводит заданный текст
void Method1(){
    Console.WriteLine("Method1");
}
Method1();

//данный метод принимает аргумент в ввиде текса(переменной) и выводит ее 
void Methot2(string msg){
    Console.WriteLine(msg);
}
//присваевание определеннной переменной нужного значения, в таком случае можно не соблюдать порядок аргументов
//если не делать такое присваивание, то необходимо соблюдать порядок аргументов 
Methot2(msg: "Method2");

//данный метод принимает 2 аргумента и выводит результат, ничего не возвращая
void Methot21(string msg, int count){
    int i = 0;
    while(i < count){
    Console.WriteLine(msg);
    i++;
    }
}
Methot21("Method21", 4);

//данный метод не принимает аргументы, но возвращает результат выполнения функции как год
int Method3(){
    return DateTime.Now.Year;
}
int year = Method3();
Console.WriteLine(year);

//данный метод и принимает аргументы и возвращает результат
string Method4(int count, string c){
    int i =0;
    string result = String.Empty; //обозначение пустой строки, схоже с "", но более верно
    while(i < count){
        result = result + c;
        i++;
    }
    return result;
}
string res = Method4(10, "Method4 ");
Console.WriteLine(res);