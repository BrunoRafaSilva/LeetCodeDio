string sectorsInput = Console.ReadLine();

List<String> SectorsList = sectorsInput.Split(',').ToList();

Dictionary<string, int> count = CountFuncionarysDepartaments(SectorsList);

foreach (var item in count)
{
    Console.WriteLine($"{item.Key}: {item.Value}");
}

static Dictionary<string, int> CountFuncionarysDepartaments(List<String> SectorsList){
    var countSectors = new Dictionary<string, int>();

    for (int index = 0; index < SectorsList.Count; index++)
    {
        if(countSectors.ContainsKey(SectorsList[index])){
            countSectors[SectorsList[index]]++;
                    }
        else{
            countSectors.Add(SectorsList[index], 1);
        }
    }

    return countSectors;
}



// Descrição
// Você precisa desenvolver um sistema que conte o número de funcionários em cada departamento. Dada uma lista que representa o departamento de cada funcionário, seu objetivo é calcular a quantidade de funcionários em cada departamento e apresentar esse número.

// Entrada
// A entrada é uma string onde cada valor, separado por vírgulas, representa o nome do departamento ao qual um funcionário pertence.

// Saída
// Deverá retornar os nomes dos departamentos em ordem alfabética seguidos pela contagem de funcionários em cada departamento, um por linha.

// Exemplos
// A tabela abaixo apresenta exemplos com alguns dados de entrada e suas respectivas saídas esperadas. Certifique-se de testar seu programa com esses exemplos e com outros casos possíveis.

// Entrada	Saída
// TI, RH, TI, Financeiro
// Financeiro: 1
// RH: 1
// TI: 2
// Financeiro, RH, RH, TI	Financeiro: 1
// RH: 2
// TI: 1
// TI, TI, TI, RH, Financeiro, RH	Financeiro: 1
// RH: 2
// TI: 3
// Atenção: É extremamente importante que as entradas e saídas sejam exatamente iguais às descritas na descrição do desafio de código.

