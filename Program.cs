string opcao;
string nome;
int idade;
double peso, altura, imc;
do{
    Console.Clear();
    //PEGANDO O NOME E A IDADE DO USUARIO
    Console.WriteLine("Digite o seu nome.");
    nome = Console.ReadLine()!;

    Console.WriteLine("Digite a sua Idade.");
    idade = Convert.ToInt32(Console.ReadLine());
    Console.Clear();

    //PEGANDO INFORMAÇÕES SOBRE O SEU PESO E A SUA ALTURA
    Console.WriteLine("Digite o seu peso.");
    peso = Convert.ToDouble(Console.ReadLine());
    Console.Clear();

    Console.WriteLine("Digite a sua altura.");
    altura = Convert.ToDouble(Console.ReadLine());
    Console.Clear();

    //CALCULO IMC
    imc = peso / (altura*altura) *100;

    //classificação do IMC
    string classificacao;
    if(imc<18.5)
    {
        classificacao ="Abaixo do peso";
    }else if(imc<24.9)
    {
        classificacao ="Peso Normal";
    }else if(imc<29.9)
    {
        classificacao ="Sobrepeso";
    }else
    {
        classificacao ="Obesidade";
    }

    //CRIANDO FAIXA ETARIA DO USUARIO
    string faixaEtaria;
    if(idade<11)
    {
        faixaEtaria ="criança";
    }else if(idade<20)
    {
        faixaEtaria ="adolecente";
    }else if(idade<60)
    {
        faixaEtaria ="adulto";
    }else
    {
        faixaEtaria ="idoso";
    }
    
    //RELATORIO DO USUARIO
    Console.WriteLine("Nome: "+nome);
    Console.WriteLine("Idade: "+idade+" anos      Faixa Etaria: "+faixaEtaria);
    Console.WriteLine($"Seu Indice de Massa corporal é de: {Math.Round(imc,2)} e sua Classificação é : {classificacao}");
    Console.WriteLine("");
    Console.WriteLine("");

    //REFAZER O CALCULO PARA OUTRO USUARIO
    Console.WriteLine("Gostaria de refazer o calculo para outra pessoa? S/N");
    opcao = Console.ReadLine()! .ToLower();
}while(opcao =="s" || opcao =="sim");
Console.Clear();
Console.WriteLine("Fim do programa");