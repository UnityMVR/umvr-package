// <auto-generated>
//	 This code was generated by a tool.
//
//	 Changes to this file may cause incorrect behavior and will be lost if
//	 the code is regenerated.
// </auto-generated>

using pindwin.umvr.Model;
using System.Collections.Generic;
using UniRx;

// ReSharper disable once CheckNamespace
namespace pindwin.umvr.example
{
	public partial class FooModel : Model<FooModel>, IFoo
	{
		private ModelSingleProperty<pindwin.umvr.example.IFoo> _otherFoo;
		public pindwin.umvr.example.IFoo OtherFoo
		{
			get => _otherFoo.Value;
			set
			{
				if(_otherFoo.Value != null) { _otherFoo.Value.Disposing -= CascadeDispose; }
				_otherFoo.Value = value;
				if(_otherFoo.Value != null) { _otherFoo.Value.Disposing += CascadeDispose; }
			}
		}


		public FooModel(pindwin.umvr.Model.Id id, System.String text2, pindwin.umvr.example.IFoo otherFoo) : base(id)
		{
			_text = new SingleProperty<System.String>();
			Text = default;

			Text2 = text2;

			_otherFoo = new ModelSingleProperty<pindwin.umvr.example.IFoo>();
			OtherFoo = otherFoo;
			Disposing += _ => OtherFoo?.Dispose();

			RegisterDataStreams(this);
		}
	}
}