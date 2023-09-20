using Utils;

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

            private set
            {
                if (Utilities.IsNullEmptyOrWhiteSpace(value))
                {
                    throw new ArgumentException("Birth place cannot be null or empty.");
                }

                // if we get here, then no execption happened
                _birthPlace = value;
            }
        }

        public string FirstName
        {
            get
            {
                return _firstName;
            }

            private set
            {
                if (Utilities.IsNullEmptyOrWhiteSpace(value))
                {
                    throw new ArgumentException("First name cannot be left blank");
                }

                // if we get here, then no execption happened
                _firstName = value;
            }
        }


        public string LastName
        {
            get
            {
                return _lastName;
            }

            private set
            {
                if (Utilities.IsNullEmptyOrWhiteSpace(value))
                {
                    throw new ArgumentException("Birth place cannot be null or empty.");
                }

                // if we get here, then no execption happened
                _lastName = value;
            }
        }



        //TODO: complete the remaining string property

        public int HeightInInches
        {
            get
            {
                return _heightInInches;
            }

            private set
            {
                if(Utilities.IsZeroOrNegative(value))
                {
                    throw new ArgumentException("Height must be positive.");
                }

                _heightInInches = value;
            }
        }

        public int WeightInPounds
        {
            get
            {
                return _weightInPounds;
            }

            private set
            {
                if (!Utilities.IsPositive(value))
                {
                    throw new ArgumentException("Height must be positive.");
                }

                _weightInPounds = value;
            }
        }

        // TODO: complete the remaining int property

        public DateOnly DateOfBirth
        {
            get
            {
                return _dateOfBirth;
            }

            private set
            {
                if (Utilities.IsInFuture(value))
                {
                    throw new ArgumentException("Date of birth cannot be in the future.");
                }

                _dateOfBirth = value;
            }
        }

        // Auto=implemented property

        public Position Position { get; set; }
        public Shot Shot { get; set; }


        /// <summary>
        /// Creates a default instance of a HockeyPlayer
        /// </summary>
       
 //       public HockeyPlayer()
  //      {
  //          _firstName = string.Empty;
   //         _lastName = string.Empty;
   //         _birthPlace = string.Empty;
   //         _dateOfBirth = new DateOnly();
   //         _weightInPounds = 0;
   //         _heightInInches = 0;
   //         Shot = Shot.Left;
   //         Position = Position.Goalie;

  //      }


        public HockeyPlayer(string firstName, string lastName, string birthPlace, DateOnly dateOfBirth,
            int weightInPounds, int heightInInches, Position position, Shot shot)
        {
            FirstName = firstName; 
            LastName = lastName;
            BirthPlace = birthPlace;
            DateOfBirth = dateOfBirth;
            WeightInPounds = weightInPounds;
            HeightInInches = heightInInches;
            Position = position;
            Shot = shot;

        }

     public override string ToString()
        {
            return$"{FirstName} {LastName}, {BirthPlace}, {DateOfBirth}, {WeightInPounds}, {HeightInInches}, {Position}, {Shot}";
        }
        
    }
}