using System;

namespace ToDone.Cli
{
    class Program
    {
        static void Main(string[] args)
        {
            try{
                Api.ValidateInputLength(args);
                Api.ValidateCommand(args[Consts.CommandPosition]);
                Console.WriteLine(Api.ExtractCommand(args));
            
            } catch(ApiException e) {
                Console.WriteLine($"ApiException: {e.Message}");
            } catch (Exception e) {
                Console.WriteLine($"Exception: {e.Message}");
            }
        }
    }
}