CriarDiretoriosGlobo();
CriarArquivo();


var Origem = Path.Combine(Environment.CurrentDirectory, "brasil.txt");
var Destino = Path.Combine(Environment.CurrentDirectory, "Globo", "América do Sul", "brasil.txt");

MoverArquivo(Origem, Destino);

static void MoverArquivo(string pathOrigem, string pathDestino)
{
    if (!File.Exists(pathOrigem))
    {
        Console.WriteLine("Arquivo de origem não existe");
        return;
    }

    if (File.Exists(pathDestino))
    {
        Console.WriteLine("Arquivo de origem já existe");
        return;

    }
    File.Move(pathOrigem, pathDestino);

}

static void CriarArquivo()
{
    var path = Path.Combine(Environment.CurrentDirectory, "brasil.txt");

    if (!File.Exists(path))
    {
        using var sw = File.CreateText(path);
        sw.WriteLine("Fundado em 1500");
        sw.WriteLine("População atual 213 milhões");
        sw.WriteLine("Exa campeão do Mundo");

    }

}

static void CriarDiretoriosGlobo()
{
    var path = Path.Combine(Environment.CurrentDirectory, "Globo");
    if (!Directory.Exists(path))
    {
        var dirGlobo = Directory.CreateDirectory(path);
        var dirAmNorte = dirGlobo.CreateSubdirectory("América do Norte");
        var dirAmCentral = dirGlobo.CreateSubdirectory("América Central");
        var dirAmSul = dirGlobo.CreateSubdirectory("América do Sul");

        dirAmNorte.CreateSubdirectory("USA");
        dirAmCentral.CreateSubdirectory("Panamá");
        dirAmSul.CreateSubdirectory("Brasil");
    }



}

