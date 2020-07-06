using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BookWeb.Entities
{
    public class User
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Username { get; set; }
        public string Email { get; set; }
        public string PhoneNo { get; set; }
        public byte[] PasswordHash { get; set; }
        public byte[] PasswordSalt { get; set; }
        public DateTime? Dateregistered { get; set; }

        /*
           {
    "id": 1,
    "firstName": "Jamie",
    "lastName": "Grace",
    "username": "_jamieeee",
    "email": "jamie@gmail.com",
    "phoneNo": "08012345678",
    "passwordHash": "cjk4r2H7nWDvZlFLs/OYeiF9Z/J9LgKnScOc09IxeIeFGzLS8LgqG0x6R8YTuUrL7xhWWLS0YZaRJvJJmLeFHQ==",
    "passwordSalt": "5fo4OoahSeovcaSd+nDE2uMQc4aOrRznK5VBTakLq+r48CS1KWC3BiF096n+9+PknpQkKX2p0T1MxpEAtCpDZ1OsZdtkVeM7BGd5boeqXfyTokNcXuwTTTdsCN9MzFH8WcdXFQ5EeIsXDoqeDQuMGMX8zuf/deLxRQSRqoJ92RY=",
    "dateregistered": null
  },
  {
    "id": 2,
    "firstName": "Ayo",
    "lastName": "Vincent",
    "username": "ayo",
    "email": "vinco@gmail.com",
    "phoneNo": "0802345678",
    "passwordHash": "N88gyD6Fpp7W/13EOZGdrgLsYmQ5nntFVm8B8zoStn1Dlu5sJ4WpZrmFVogkSD1KdUS+BVeZQ1ahaE7fRYyqBQ==",
    "passwordSalt": "fWhTdLEHlHV3nZsoiyuGLKo2V81siNkBVkY1G2SApT4BlfArJjlcxC3SgPet3X7D0uL/bu3g2lD6snvxWn+KheMcHTEuCNkI6c9+7jzTECruBPBZ2dx3vZVjsuSL+TtRWfXJ+YZWHkXG15/Pw8gioE7d5M4JgyHJU2AWeePaXII=",
    "dateregistered": null
  },
  {
    "id": 3,
    "firstName": "Ellie",
    "lastName": "Drake",
    "username": "ells",
    "email": "elie@gmail.com",
    "phoneNo": "07069875463",
    "passwordHash": "kQLxzo4JS/t8jnE01k/sdSG8xdrkCzHEzESgjtmg7zubVM9Q/flkhvmL0b5E8By435EsUsI+e9TDtgi32GoxBQ==",
    "passwordSalt": "SKkyT4lBsDWFWqc/yytzp0DWwRBvwW3H6AC472pr/Mee64icpVAxBCnrWQ7zZ9C/MhKvb6n1vSMSvKFryBFiCffak4h270WLZBZJr/UUBPV+p5vXqlsVX/o0hpa+2lcBda4kb6LNi1rTo/QvHLOFxqMAKpXtB88uFGKdW6N3qk8=",
    "dateregistered": null
  },
  {
    "id": 4,
    "firstName": "zoey",
    "lastName": "richard",
    "username": "zoey",
    "email": "zoeyrichard@gmail.com",
    "phoneNo": "08056974621",
    "passwordHash": "1NjanfUmHQFxhbSezhFVF+WiXNX86UeHuczTPjuhZ2j2S909iPsugO/uVPO8sBYfNeLUYPOrt8PJ67r+GB187Q==",
    "passwordSalt": "WZXwkfZ+cUy7dL9ICawDpYJERwZSVZnZyARrSPpRa6OMo5HWbIHRPuf59ktrvBdd7nXr0SOKM8kwQ3xZUNt9IuYCuQh1vNTEzaAvpIl+17hX708RIwToQg9D5G4KVdOBhes9XdBDblot3qCTy+MmKxLyF1i8uMkhx1r3q2mbScg=",
    "dateregistered": null
  }
         */

    }
}
