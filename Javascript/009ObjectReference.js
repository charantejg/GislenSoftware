let myAccount = 
{
    name: 'Tej',
    expense: 100,
    balance: 0
}

let addExpense = function(account, amount)
{
    account.expense = account.expense + amount
}

let resetAccount = function(account)
{
    account.expense = 0
    account.balance = 0
}

console.log(myAccount)
addExpense(myAccount, 200)
console.log(myAccount)

