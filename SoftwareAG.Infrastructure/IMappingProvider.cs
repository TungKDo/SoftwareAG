using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SoftwareAG.Infrastructure
{
    public interface IMappingProvider
    {
        /// <summary>
        /// Automatically map object from one model to another.
        /// </summary>
        TDestination MapTo<TDestination>(object source);

        /// <summary>
        /// Automatically map IQueryable list of objects from one model to another.
        /// </summary>
        IQueryable<TDestination> ProjectTo<TDestination>(IQueryable<object> source);


        /// <summary>
        /// Change the Collection type to Queryable.
        /// Automatically map IQueryable list of objects from one model to another.
        /// </summary>
        IEnumerable<TDestination> EnumerableProjectTo<TSource, TDestination>(IEnumerable<TSource> source);
    }
}
