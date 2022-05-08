namespace eTickets.Data.DataConstants
{
    public class DataConstants
    {
        public class Actor
        {
            public const int ProfilePictureURLMaxLength = 350;
            public const int FullNameMaxLength = 40;
            public const int FullNameMinLength = 3;
            public const int BioMaxLength = 200;
            public const int BioMinLength = 5;
        }

        public class Cinema
        {
            public const int LogoURLMaxLength = 350;
            public const int NameMaxLength = 40;
            public const int NameMinLength = 3;
            public const int DescriptionMaxLength = 200;
            public const int DescriptionMinLength = 5;
        }

        public class Producer
        {
            public const int ProfilePictureURLMaxLength = 350;
            public const int FullNameMaxLength = 40;
            public const int FullNameMinLength = 3;
            public const int BioMaxLength = 200;
            public const int BioMinLength = 5;
        }

        public class Movie
        {
            public const int ImageURLMaxLength = 350;
            public const int NameMaxLength = 40;
            public const int NameMinLength = 3;
            public const int DescriptionMaxLength = 200;
            public const int DescriptionMinLength = 5;
            public const int MinPrice = 1;
            public const int MaxPrice = 1000;
        }
    }
}
