int totalExercises = 1;

for (int number = 8; number >= totalExercises; number--){
    Console.WriteLine($"Упражнение {number}");
}

Console.WriteLine("Домашнее задание готово");

Console.WriteLine();
for (int room = 0; room <= 50; room+=5){
    Console.WriteLine($"Кабинет {room}");
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