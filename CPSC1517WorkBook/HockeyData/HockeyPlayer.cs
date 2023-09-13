namespace Hockey.Data
{
    public class HockeyPlayer
    {
        // data fields
        private string _firstName;
        private string _lastName;
        private string _birthPlace;
        private DateOnly _dateOfBirth;
        private int _heightInInches;
        private int _weightInPounds;
        //We don't need the following two fields anymore
        //private Position _position;
        //private Shot _shot;

        // properties
        public string BirthPlace
        {
            get
            {
                return _birthPlace;
            }

            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Birth place cannot be null or empty.");
                }

                // if we get here, then no execption happened
                _birthPlace = value;
            }
        }

        //TODO: complete the remaining string property

        public int HeightInInches
        {
            get
            {
                return _heightInInches;
            }

            set
            {
                if(value <= 0)
                {
                    throw new ArgumentException("Height must be positive.");
                }

                _heightInInches = value;
            }
        }

        // TODO: complete the remaining int property

        public DateOnly DateOfBirth
        {
            get
            {
                return _dateOfBirth;
            }

            set
            {
                if( // TODO: implement a validty check for dates in the future
                    // Check the documentation for DateOnly 
                    )
                {
                    throw new ArgumentException("Date of birth cannot be in the future.");
                }

                _dateOfBirth = value;
            }
        }

        // Auto=implemented property

        public Position Position { get; set; }


        /// <summary>
        /// Creates a default instance of a HockeyPlayer
        /// </summary>
        public HockeyPlayer()
        {
            _firstName = string.Empty;
            _lastName = string.Empty;
            _birthPlace = string.Empty;
            _dateOfBirth = new DateOnly();
            _weightInPounds = 0;
            _heightInInches = 0;
            Shot = Shot.Left;
            Position = Position.Goalie;

        }


        public HockeyPlayer(string firstName, string lastName, string birthPlace, DateOnly dateOfBirth,
            int weightInPounds, int heightInInches, Position position, Shot shot)
        {
            BirthPlace = birthPlace;
            // finish
        }

        // constructors

    }
}