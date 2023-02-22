namespace ToDone.Cli
{
    class Api
    {
        public static readonly string[] Commands = {"add"};
        public static readonly string[] Options = {"--tags"};

        public static string ExtractCommand(string[] args)
        {
            return args[Consts.CommandPosition];
        }

        public static void ValidateInputLength(string[] args)
        {
            if(args.Count() < Consts.MinInput)
                throw new ApiException(ApiDefaultMessages.MinInputExceptionMessage);
        }

        public static void ValidateCommand(string userCommand)
        {
            if(!Api.Commands.Contains(userCommand))
                throw new ApiException(ApiDefaultMessages.CommandExceptionMessage);
        }

        public static void ValidateOption(string userOption)
        {
            if(!Api.Options.Contains(userOption))
                throw new ApiException(ApiDefaultMessages.OptionsExceptionMessage);
        }

    }
}