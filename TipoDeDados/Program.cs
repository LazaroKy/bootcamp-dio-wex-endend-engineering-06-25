//tipo nome = valor;
// string apresentacao = "Olá, seja bem-vindo";
// int quantidade = 1;
// double altura = 1.80;
// decimal preco = 1.80M;
// bool condicao = true;

// Console.WriteLine(apresentacao);
// Console.WriteLine("Valor da variável quantidade: " + quantidade);
// Console.WriteLine("Valor da variável altura: " + altura.ToString("0.00")); 
// Console.WriteLine("Valor da variável preco: " + preco);
// Console.WriteLine("Valor da variável condicao: " + condicao);


DateTime dataEHora = DateTime.Now;
Console.WriteLine(dataEHora);


//somar data 
DateTime plusData = DateTime.Now.AddDays(3);
Console.WriteLine(plusData);

//Formata data
DateTime formataData = DateTime.Now.AddDays(3);
Console.WriteLine(formataData.ToString("dd/MM/yyyy HH:mm"));
