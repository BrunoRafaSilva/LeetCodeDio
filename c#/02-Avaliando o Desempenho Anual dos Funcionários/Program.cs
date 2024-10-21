// Descrição
// Uma empresa realiza uma avaliação anual de desempenho de seus funcionários, utilizando três critérios principais: produtividade, qualidade do trabalho e pontualidade. Cada critério recebe uma nota que varia de 0 a 10. O objetivo do sistema é calcular a média das notas e determinar se o funcionário é elegível para receber um bônus anual.

// Para ser elegível ao bônus, o funcionário precisa obter uma média igual ou superior a 7,0.

// Entrada
// Você receberá uma string contendo três valores inteiros separados por vírgula (,). Esses valores representam as notas atribuídas a cada critério, na seguinte ordem:

// Produtividade
// Qualidade do Trabalho
// Pontualidade
// Saída
// O programa deve imprimir duas linhas:

// A primeira linha deve mostrar a média das três notas, formatada com duas casas decimais.
// A segunda linha deve informar se o funcionário é elegível para o bônus, exibindo Sim ou Nao.
// Exemplos
// A tabela abaixo apresenta exemplos com alguns dados de entrada e suas respectivas saídas esperadas. Certifique-se de testar seu programa com esses exemplos e com outros casos possíveis.

// Entrada	Saída
// 8,7,9	Media: 8
// Elegivel para bonus: Sim
// 6,5,7	Media: 6
// Elegivel para bonus: Nao
// 10,9,8	Media: 9
// Elegivel para bonus: Sim
// Atenção: É extremamente importante que as entradas e saídas sejam exatamente iguais às descritas na descrição do desafio de código.

var notes = Console.ReadLine().Split(',');

var doubleNotes = notes.Select(x => int.Parse(x)).ToList();

var someNotes = 0.0;

foreach (var note in doubleNotes)
{
    someNotes += note;
}

var finalAverage = (someNotes / doubleNotes.Count).ToString("0");

var bonusEligible = someNotes / doubleNotes.Count >= 7 ? "Sim" : "Nao";

Console.WriteLine($"Media: {finalAverage}");
Console.WriteLine($"Elegivel para bonus: {bonusEligible}");