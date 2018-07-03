using AutoMapper;
using AutoMapper.QueryableExtensions;
using System;
using System.Collections.Generic;
using System.Linq;

namespace SoftwareAG.Infrastructure
{
    public class MappingProvider : IMappingProvider
    {
        private IMapper mapper;

        public MappingProvider(IMapper mapper)
        {            
            this.mapper = mapper;
        }

        /// <summary>
        /// Automatically map object from one model to another.
        /// </summary>
        public TDestination MapTo<TDestination>(object source)
        {
            return this.mapper.Map<TDestination>(source);
        }

        /// <summary>
        /// Automatically map IQueryable list of objects from one model to another.
        /// </summary>
        public IQueryable<TDestination> ProjectTo<TDestination>(IQueryable<object> source)
        {
            return source.ProjectTo<TDestination>();
        }

        /// <summary>
        /// Change the Collection type to Queryable.
        /// Automatically map IQueryable list of objects from one model to another.
        /// </summary>
        public IEnumerable<TDestination> EnumerableProjectTo<TSource, TDestination>(IEnumerable<TSource> source)
        {
            return source.AsQueryable().ProjectTo<TDestination>();
        }
    }
}
