﻿using System.Collections.Generic;
using TeamleaderDotNet.Utils;

namespace TeamleaderDotNet.Crm
{
    public class Contact : Entity
    {

        [TeamleaderDataType(Name = "contact_id")]
        public int Id { get; set; }

        [TeamleaderDataType(Name = "forename")]
        public string Forename { get; set; }

        [TeamleaderDataType(Name = "surname")]
        public string Surname { get; set; }

        [TeamleaderDataType(Name = "email")]
        public string Email { get; set; }

        [TeamleaderDataType(Name = "telephone")]
        public string Telephone { get; set; }

        [TeamleaderDataType(Name = "gsm")]
        public string Gsm { get; set; }

        [TeamleaderDataType(Name = "fax")]
        public string Fax { get; set; }

        [TeamleaderDataType(Name = "website")]
        public string Website { get; set; }

        [TeamleaderDataType(Name = "street")]
        public string Street { get; set; }

        [TeamleaderDataType(Name = "number")]
        public string Number { get; set; }

        [TeamleaderDataType(Name = "zipcode")]
        public string Zipcode { get; set; }

        [TeamleaderDataType(Name = "city")]
        public string City { get; set; }

        [TeamleaderDataType(Name = "country")]
        public string Country { get; set; }

        [TeamleaderDataType(Name = "extraaddresses")]
        public string[] ExtraAddresses { get; set; }

        [TeamleaderDataType(Name = "language")]
        public string Language { get; set; }

        [TeamleaderDataType(Name = "gender")]
        public string Gender { get; set; }

        [TeamleaderDataType(Name = "dob")]
        public int Dob { get; set; }

        [TeamleaderDataType(Name = "iban")]
        public string Iban { get; set; }

        [TeamleaderDataType(Name = "bic")]
        public string Bic { get; set; }

        [TeamleaderDataType(Name = "dateadded")]
        public int DateAdded { get; set; }

        [TeamleaderDataType(Name = "dateedited")]
        public int DateEdited { get; set; }

        [TeamleaderDataType(Name = "deleted")]
        public bool Deleted { get; set; }

        [TeamleaderDataType(Name = "status")]
        public string Status { get; set; }

        public string[] CustomFields { get; set; }

        [TeamleaderDataType(Name = "getLinkedCompanyIds")]
        public string[] LinkedCompanyIds { get; set; }

        public string[] Tags { get; set; }



    }
}
