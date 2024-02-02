using DataAccess.Repositories.Concreds;
using Model.Entitys.Concrets;

Console.WriteLine();


AuthorRepositories authorRepositories = new AuthorRepositories();
//authorRepositories.Add(new Author() { FirstName = "adam_1", LastName="adam_1"});

authorRepositories.Delete(2);




