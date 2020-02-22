namespace fnbot.shop.Web
{
    public static class Client
    {
        public static IClient Create(bool useCookies = false, bool useProxy = true) =>
            new BaseClient(useCookies, useProxy);
    }
}
