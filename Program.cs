int totalExercises = 1;

for (int number = 8; number >= totalExercises; number--){
    Console.WriteLine($"Упражнение {number}");
}

Console.WriteLine("Домашнее задание готово");

Console.WriteLine();
for (int room = 0; room <= 50; room++){
    if (room%5==0 && room!=0) Console.WriteLine($"Кабинет {room}");
}

Console.WriteLine();
int totalWeeks = 3;

for (int week =1; week <= totalWeeks; week++){
    for (int day = 1; day <= 5; day++){
        Console.WriteLine($"Неделя {week}, день {day}");
    }
    Console.WriteLine("^_^");
}


Console.WriteLine();
int cnt = 0;
for (int ticket = 1; ticket <= 30; ticket++){
    if (ticket == 4 || ticket == 12 || ticket == 19){
        cnt++; continue;
    }

    Console.WriteLine($"Первый доступный билет: {ticket}, билетов пропущено: {cnt}");
    break;
}

//
Console.WriteLine();
for (int nech = 1; nech <=19; nech+=2){
    Console.WriteLine(nech);
}

//Б
Console.WriteLine();
for (int obr = 100; obr>=0; obr-=10){
    Console.WriteLine(obr);
}

//3
Console.WriteLine();
for (int cube = 1; cube <= 5; cube++){
    Console.WriteLine(cube*cube*cube);
}



//5
Console.WriteLine();
for (int crot = 1; crot<=100; crot ++){
    if (crot % 5==0 && crot % 3 ==0){
        Console.WriteLine(crot);break;
    } else{
        continue;
    }
}


// //bonus
// Console.WriteLine();
// Console.WriteLine("Введите общее кол-во трен. недель:");
// int week_t = int.Parse(Console.ReadLine()!);
// int cnt_d = 0; cnt_w = 0;

// for (int total = 1; total <= week_t; total++){
//     for (int total_d = 1; total_d <= 7; total_d++){
//         if (cnt_d != 20)
//         {
//             if (total_d == 7)
//             {
//                 continue;
//             }
//             else
//             {
//                 cnt_d++;
//             }
//         }else{
//             break;
//         }
        
//     }
//     cnt_w++;
// }
// Console.WriteLine($"Вы остановились на {cnt_w} неделе {cnt_d%cnt_w}");