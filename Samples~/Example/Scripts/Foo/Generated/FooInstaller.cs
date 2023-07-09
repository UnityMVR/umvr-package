// <auto-generated>
//	 This code was generated by a tool.
//
//	 Changes to this file may cause incorrect behavior and will be lost if
//	 the code is regenerated.
// </auto-generated>

using pindwin.umvr.Model;
using pindwin.umvr.Reactor;
using pindwin.umvr.Repository;
using pindwin.umvr.Serialization;
using Zenject;

namespace pindwin.umvr.example
{
	public partial class FooFactory : ModelFactory<IFoo, FooModel, System.String, pindwin.umvr.example.IFoo>
	{
		public FooFactory(IRepository<IFoo> repository, [InjectOptional] ISerializer<FooModel> serializer) : base(repository, serializer)
		{ }
	}

	public partial class FooRepository : SingletonRepository<IFoo, FooModel, FooReactor>
	{
		public FooRepository(FooReactorFactory fooReactorFactory) : base(fooReactorFactory)
		{ }
	}
	
	public class FooReactorFactory : ReactorFactory<FooModel, FooReactor>
	{ }
}

namespace pindwin.umvr.example.Generated
{
	public class FooInstallerBase : Installer<FooInstallerBase>
	{
		public override void InstallBindings()
		{
			Container.BindFactory<Id, System.String, pindwin.umvr.example.IFoo, FooModel, FooFactory>();
			Container.Bind<IModelFactory<IFoo, System.String, pindwin.umvr.example.IFoo>>().To<FooFactory>().FromResolve();
			Container.BindFactory<FooModel, FooReactor, FooReactorFactory>();
			Container.BindInterfacesAndSelfTo<FooRepository>().AsSingle();
		}
	}
}