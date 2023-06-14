namespace finalProject.Api.Data
{
    public static class Seeder
    {
        public static void Seed(AppDbContext context)
        {
            SeedUsers(context);
            SeedCharacters(context);
        }

        public static void SeedUsers(AppDbContext db)
        {
            db.Users.Add(new User { UserName = "Vulpyx", MagicWord = "IHateThis"});
        }
        public static void SeedCharacters(AppDbContext db)
        {
            PDCharacter char1 = new PDCharacter();
            PDCharacter char2 = new PDCharacter();

            db.PDCharacters.Add(char1);
            db.PDCharacters.Add(char2);
        }
    }
}
