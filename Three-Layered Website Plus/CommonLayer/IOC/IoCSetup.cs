using System.Web.Mvc;
using StructureMap;

namespace $safeprojectname$.IOC
{
    public static class IoCSetup
    {
        public static void Now()
        {
            var container = new Container(config =>
            {
                config.Scan(scan =>
                {
                    scan.With(new DefaultConventionWithProxyScanner());
                    scan.AssembliesFromApplicationBaseDirectory();
                    scan.IncludeNamespace(@"$ext_safeprojectname$.Common");
                    scan.IncludeNamespace(@"$ext_safeprojectname$.Web");
                    scan.IncludeNamespace(@"$ext_safeprojectname$.Business");
                    scan.IncludeNamespace(@"$ext_safeprojectname$.Data");
                });
            });
            DependencyResolver.SetResolver(new StructureMapDependencyResolver(container));
        }
    }
}
