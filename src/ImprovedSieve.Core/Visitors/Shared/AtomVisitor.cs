﻿using System.Linq;
using System.Linq.Expressions;
using ImprovedSieve.Core.Antlr;

namespace ImprovedSieve.Core.Visitors.Shared
{
    public class AtomVisitor<TInput> : VisitorBase<TInput>
    {
        public Expression Visit(IQueryable query, Expression expression, AutoFilterParser.AtomContext context, Expression item = null)
        {
            AutoParser = new AutoParser<TInput>(query, expression, item);

            return VisitChildren(context);
        }
    }
}