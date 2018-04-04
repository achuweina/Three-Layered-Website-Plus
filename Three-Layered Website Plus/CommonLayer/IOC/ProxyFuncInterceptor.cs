﻿using System;
using System.Linq.Expressions;
using Castle.DynamicProxy;
using StructureMap;
using StructureMap.Building.Interception;

namespace $safeprojectname$.IOC
{
    internal class ProxyFuncInterceptor<T> : FuncInterceptor<T> where T : class
    {
        public ProxyFuncInterceptor() : base(x => MakeProxy(x), "")
        {
        }

        protected ProxyFuncInterceptor(Expression<Func<T, T>> expression, string description = null) : base(expression, description)
        {
        }

        protected ProxyFuncInterceptor(Expression<Func<IContext, T, T>> expression, string description = null) : base(expression, description)
        {
        }

        private static T MakeProxy(T instance)
        {
            var proxyGenerator = new ProxyGenerator();
            return proxyGenerator.CreateInterfaceProxyWithTarget(instance);
        }
    }
}
