namespace WpfApp4.DataModel
{
    using System;
    using System.Data.Entity;
    using System.Linq;
    public class codefirst : DbContext
    {
        // Контекст настроен для использования строки подключения "CodeFirstModel" из файла конфигурации  
        // приложения (App.config или Web.config). По умолчанию эта строка подключения указывает на базу данных 
        // "WpfApp3.CodeFirstModel" в экземпляре LocalDb. 
        // 
        // Если требуется выбрать другую базу данных или поставщик базы данных, измените строку подключения "CodeFirstModel" 
        // в файле конфигурации приложения.
        public codefirst()
            : base("name=codefirst")
        {
        }

        // Добавьте DbSet для каждого типа сущности, который требуется включить в модель. Дополнительные сведения 
        // о настройке и использовании модели Code First см. в статье http://go.microsoft.com/fwlink/?LinkId=390109.

        public DbSet<DataModel.Dolj> Doljs { get; set; }
        public DbSet<DataModel.Sotr> Sotrs { get; set; }
    }

    //public class MyEntity
    //{
    //    public int Id { get; set; }
    //    public string Name { get; set; }
    //}
}