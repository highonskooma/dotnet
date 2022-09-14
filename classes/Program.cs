using Classes;

var account = new BankAccount("Joao", 1000);
Console.WriteLine($"Account {account.Number} was created for {account.Owner} with {account.Balance} initial balance.");

account.MakeDeposit(1000,DateTime.Now,"initial deposit");
Console.WriteLine($"Account {account.Number} was deposited 1000 with {account.Balance} current balance.");