namespace BankRPEF.DataLayer
{
    internal class MYBANKContext
    {
        public object CheckingAccounts { get; internal set; }
        public object TransactionHistories { get; internal set; }
        public object TransactionTypes { get; internal set; }
    }
}