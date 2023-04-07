using SQLite;

namespace People.Models
{
    //sets table for people
    [Table("people")]
    public class Person
    {
        //key, with autoincrement
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }


        //max length and unique entry
        [MaxLength(50), Unique]
        public string Name { get; set; }


    }
}
