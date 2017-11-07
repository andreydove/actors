using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Actors.Model
{

    interface IIdentifiable
    {
        int Id { get; set; }
    }

    interface INameble
    {
        string CommonName { get; set; }
    }

    interface IDescribable
    {
        string Description { get; set; }
        string Site { get; set; }
    }

    public abstract class Entity
    {
        public string Note { get; set; }
    }

    public abstract class IdentifiedEntity
        : Entity, IIdentifiable
    {
        public int Id { get; set; }
    }

    public abstract class NamedEntity
        : Entity, INameble
    {
        public string CommonName { get; set; }
        public string EnglishName { get; set; }
    }

    public abstract class IdentifiedNamedEntity
        : NamedEntity, IIdentifiable
    {
        public int Id { get; set; }
    }

    public abstract class DescribedEntity
            : Entity, IDescribable
    {
        public string Description { get; set; }
        public string Site { get; set; }
    }

    public abstract class DescribedNamedEntity
            : NamedEntity, IDescribable
    {
        public string Description { get; set; }
        public string Site { get; set; }
    }

    public abstract class DescribedIdentifiedNamedEntity
        : IdentifiedNamedEntity, IDescribable
    {
        public string Description { get; set; }
        public string Site { get; set; }
    }


}
