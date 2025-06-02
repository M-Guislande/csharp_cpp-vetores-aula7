/*
A tabela a seguir
mostra a distância de quatro cidades entre
si. Por exemplo, a distância entre Vitória e
Belo Horizonte é de 524 km.

Crie um programa
que leia essa matriz e informe ao usuário a
distância entre duas cidades por ele
fornecidas.
O programa deve ficar repetindo até que o
usuário informe a mesma cidade como
origem e destino.
*/
int[,] locais ={
    {0,524,521,882},
    {524,0,434,586},
    {521,434,0,429},
    {882,586,429,0}

};
static int convercao(string converter)
{
    
    return 0;
}
static void main()
{
    Console.WriteLine("Onde vc esta? ");
    string atual = Console.ReadLine();
    int onde_esta = convercao(atual);
    Console.WriteLine("Onde vc quer ir? ");
    string vai = Console.ReadLine();
    int onde_ir = convercao(vai);
    
}


