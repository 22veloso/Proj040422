namespace Model
{
    public abstract class Person: IPerson
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Telephone { get; set; }

        public string PrintTelephone()
        {
            return Telephone;

        }

        public override string ToString()
        {

            return "id: " + Id +
                "\nNome: " + Name +
                "\nTelefone: " + Telephone;


        }
        public virtual int GetNumberOfCaracters(string text)
        {
            return text.Length;

        }

    }
}