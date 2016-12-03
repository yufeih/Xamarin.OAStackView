using System;
using ObjCRuntime;

namespace OAStackView
{
	[Native]
	public enum OAStackViewDistribution : nint
	{
		Fill = 0,
		FillEqually,
		FillProportionally,
		EqualSpacing,
		EqualCentering
	}

	[Native]
	public enum OAStackViewAlignment : nint
	{
		Fill,
		Leading,
		Top = Leading,
		FirstBaseline,
		Center,
		Trailing,
		Bottom = Trailing,
		Baseline,
		LastBaseline = Baseline
	}
}
