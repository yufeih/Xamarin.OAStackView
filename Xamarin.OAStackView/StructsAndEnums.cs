using Foundation;
using ObjCRuntime;

using System;

namespace OAStackView {

	[Native]
	public enum OAStackViewDistribution : long /* nint */ {
		Fill = 0,
		FillEqually,
		FillProportionally,
		EqualSpacing,
		EqualCentering
	}

	[Native]
	public enum OAStackViewAlignment : long /* nint */ {
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
