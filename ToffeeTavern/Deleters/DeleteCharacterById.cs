using ToffeeTavern.Data;
using ToffeeTavern.Deleters.Interfaces;

namespace ToffeeTavern.Deleters
{
    public class DeleteCharacterById : IDeleteCharacterById
    {
        private readonly ToffeeContext context;

        public DeleteCharacterById(ToffeeContext context)
        {
            this.context = context;
        }

        public void Delete(int id)
        {
            var character = context.Characters.Find(id);
            if (character != null)
            {
                context.Characters.Remove(character);
                context.SaveChanges();
            }
        }
    }
}
