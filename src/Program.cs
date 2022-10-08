var fileOpt = new Option<FileInfo?>(
    name: "--file",
    description: "The file to read and display on the terminal.");

var rootCmd = new RootCommand("Your simple command line app");
rootCmd.AddOption(fileOpt);

rootCmd.SetHandler((file) =>
{
    ReadFile(file!);

}, fileOpt);

await rootCmd.InvokeAsync(args);

void ReadFile(FileInfo file)
{
    File.ReadLines(file.FullName)
        .ToList()
        .ForEach(line => Console.WriteLine(line));
}