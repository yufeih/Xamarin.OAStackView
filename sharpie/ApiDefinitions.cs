using System;
using CoreAnimation;
using Foundation;
using ObjCRuntime;
using UIKit;

namespace OAStackView
{
	// @interface OAStackView : UIView
	[BaseType (typeof(UIView))]
	interface OAStackView
	{
		// @property (readonly, copy, nonatomic) NSArray<__kindof UIView *> * _Nonnull arrangedSubviews;
		[Export ("arrangedSubviews", ArgumentSemantic.Copy)]
		UIView[] ArrangedSubviews { get; }

		// @property (nonatomic) UILayoutConstraintAxis axis;
		[Export ("axis", ArgumentSemantic.Assign)]
		UILayoutConstraintAxis Axis { get; set; }

		// @property (nonatomic) NSInteger axisValue;
		[Export ("axisValue")]
		nint AxisValue { get; set; }

		// @property (nonatomic) CGFloat spacing;
		[Export ("spacing")]
		nfloat Spacing { get; set; }

		// @property (nonatomic) OAStackViewAlignment alignment;
		[Export ("alignment", ArgumentSemantic.Assign)]
		OAStackViewAlignment Alignment { get; set; }

		// @property (nonatomic) NSInteger alignmentValue;
		[Export ("alignmentValue")]
		nint AlignmentValue { get; set; }

		// @property (nonatomic) OAStackViewDistribution distribution;
		[Export ("distribution", ArgumentSemantic.Assign)]
		OAStackViewDistribution Distribution { get; set; }

		// @property (nonatomic) NSInteger distributionValue;
		[Export ("distributionValue")]
		nint DistributionValue { get; set; }

		// @property (nonatomic) UIEdgeInsets layoutMargins;
		[Export ("layoutMargins", ArgumentSemantic.Assign)]
		UIEdgeInsets LayoutMargins { get; set; }

		// @property (getter = isLayoutMarginsRelativeArrangement, nonatomic) BOOL layoutMarginsRelativeArrangement;
		[Export ("layoutMarginsRelativeArrangement")]
		bool LayoutMarginsRelativeArrangement { [Bind ("isLayoutMarginsRelativeArrangement")] get; set; }

		// -(instancetype _Nonnull)initWithArrangedSubviews:(NSArray<__kindof UIView *> * _Nonnull)views __attribute__((objc_designated_initializer));
		[Export ("initWithArrangedSubviews:")]
		[DesignatedInitializer]
		IntPtr Constructor (UIView[] views);

		// -(instancetype _Nonnull)initWithCoder:(NSCoder * _Nonnull)coder __attribute__((objc_designated_initializer));
		[Export ("initWithCoder:")]
		[DesignatedInitializer]
		IntPtr Constructor (NSCoder coder);

		// -(void)addArrangedSubview:(UIView * _Nonnull)view;
		[Export ("addArrangedSubview:")]
		void AddArrangedSubview (UIView view);

		// -(void)removeArrangedSubview:(UIView * _Nonnull)view;
		[Export ("removeArrangedSubview:")]
		void RemoveArrangedSubview (UIView view);

		// -(void)insertArrangedSubview:(UIView * _Nonnull)view atIndex:(NSUInteger)stackIndex;
		[Export ("insertArrangedSubview:atIndex:")]
		void InsertArrangedSubview (UIView view, nuint stackIndex);
	}

	// @interface Constraint (OAStackView)
	[Category]
	[BaseType (typeof(OAStackView))]
	interface OAStackView_Constraint
	{
		// -(NSArray *)constraintsAffectingView:(UIView *)view;
		[Export ("constraintsAffectingView:")]
		[Verify (StronglyTypedNSArray)]
		NSObject[] ConstraintsAffectingView (UIView view);

		// -(NSArray *)constraintsAffectingView:(UIView *)view inAxis:(UILayoutConstraintAxis)axis;
		[Export ("constraintsAffectingView:inAxis:")]
		[Verify (StronglyTypedNSArray)]
		NSObject[] ConstraintsAffectingView (UIView view, UILayoutConstraintAxis axis);

		// -(NSArray *)constraintsBetweenView:(UIView *)firstView andView:(UIView *)otherView inAxis:(UILayoutConstraintAxis)axis;
		[Export ("constraintsBetweenView:andView:inAxis:")]
		[Verify (StronglyTypedNSArray)]
		NSObject[] ConstraintsBetweenView (UIView firstView, UIView otherView, UILayoutConstraintAxis axis);

		// -(NSArray *)constraintsBetweenView:(UIView *)firstView andView:(UIView *)otherView inAxis:(UILayoutConstraintAxis)axis includeReversed:(BOOL)includeReversed;
		[Export ("constraintsBetweenView:andView:inAxis:includeReversed:")]
		[Verify (StronglyTypedNSArray)]
		NSObject[] ConstraintsBetweenView (UIView firstView, UIView otherView, UILayoutConstraintAxis axis, bool includeReversed);

		// -(NSArray *)firstConstraintAffectingView:(UIView *)superView andView:(UIView *)childView inAxis:(UILayoutConstraintAxis)axis;
		[Export ("firstConstraintAffectingView:andView:inAxis:")]
		[Verify (StronglyTypedNSArray)]
		NSObject[] FirstConstraintAffectingView (UIView superView, UIView childView, UILayoutConstraintAxis axis);

		// -(NSArray *)lastConstraintAffectingView:(UIView *)superView andView:(UIView *)childView inAxis:(UILayoutConstraintAxis)axis;
		[Export ("lastConstraintAffectingView:andView:inAxis:")]
		[Verify (StronglyTypedNSArray)]
		NSObject[] LastConstraintAffectingView (UIView superView, UIView childView, UILayoutConstraintAxis axis);
	}

	// @interface Hiding (OAStackView)
	[Category]
	[BaseType (typeof(OAStackView))]
	interface OAStackView_Hiding
	{
		// -(void)addObserverForView:(UIView *)view;
		[Export ("addObserverForView:")]
		void AddObserverForView (UIView view);

		// -(void)addObserverForViews:(NSArray<__kindof UIView *> *)views;
		[Export ("addObserverForViews:")]
		void AddObserverForViews (UIView[] views);

		// -(void)removeObserverForView:(UIView *)view;
		[Export ("removeObserverForView:")]
		void RemoveObserverForView (UIView view);

		// -(void)removeObserverForViews:(NSArray<__kindof UIView *> *)views;
		[Export ("removeObserverForViews:")]
		void RemoveObserverForViews (UIView[] views);
	}

	// @interface Traversal (OAStackView)
	[Category]
	[BaseType (typeof(OAStackView))]
	interface OAStackView_Traversal
	{
		// -(UIView *)visibleViewBeforeIndex:(NSInteger)index;
		[Export ("visibleViewBeforeIndex:")]
		UIView VisibleViewBeforeIndex (nint index);

		// -(UIView *)visibleViewBeforeView:(UIView *)view;
		[Export ("visibleViewBeforeView:")]
		UIView VisibleViewBeforeView (UIView view);

		// -(UIView *)visibleViewAfterIndex:(NSInteger)index;
		[Export ("visibleViewAfterIndex:")]
		UIView VisibleViewAfterIndex (nint index);

		// -(UIView *)visibleViewAfterView:(UIView *)view;
		[Export ("visibleViewAfterView:")]
		UIView VisibleViewAfterView (UIView view);

		// -(void)iterateVisibleViews:(void (^)(UIView *, UIView *))block;
		[Export ("iterateVisibleViews:")]
		void IterateVisibleViews (Action<UIView, UIView> block);

		// -(NSArray *)currentVisibleViews;
		[Export ("currentVisibleViews")]
		[Verify (MethodToProperty), Verify (StronglyTypedNSArray)]
		NSObject[] CurrentVisibleViews { get; }

		// -(UIView *)lastVisibleItem;
		[Export ("lastVisibleItem")]
		[Verify (MethodToProperty)]
		UIView LastVisibleItem { get; }

		// -(NSLayoutConstraint *)firstViewConstraint;
		[Export ("firstViewConstraint")]
		[Verify (MethodToProperty)]
		NSLayoutConstraint FirstViewConstraint { get; }

		// -(NSLayoutConstraint *)lastViewConstraint;
		[Export ("lastViewConstraint")]
		[Verify (MethodToProperty)]
		NSLayoutConstraint LastViewConstraint { get; }

		// -(BOOL)isViewLastItem:(UIView *)view excludingItem:(UIView *)excludingItem;
		[Export ("isViewLastItem:excludingItem:")]
		bool IsViewLastItem (UIView view, UIView excludingItem);
	}

	// @interface OAStackViewAlignmentStrategy : NSObject
	[BaseType (typeof(NSObject))]
	interface OAStackViewAlignmentStrategy
	{
		// @property (readonly, nonatomic) NSArray * addedConstraints;
		[Export ("addedConstraints")]
		[Verify (StronglyTypedNSArray)]
		NSObject[] AddedConstraints { get; }

		// +(OAStackViewAlignmentStrategy *)strategyWithStackView:(OAStackView *)stackView;
		[Static]
		[Export ("strategyWithStackView:")]
		OAStackViewAlignmentStrategy StrategyWithStackView (OAStackView stackView);

		// -(void)addConstraintsOnOtherAxis:(UIView *)view;
		[Export ("addConstraintsOnOtherAxis:")]
		void AddConstraintsOnOtherAxis (UIView view);

		// -(void)alignView:(UIView *)view withPreviousView:(UIView *)previousView;
		[Export ("alignView:withPreviousView:")]
		void AlignView (UIView view, UIView previousView);

		// -(void)alignFirstView:(UIView *)view;
		[Export ("alignFirstView:")]
		void AlignFirstView (UIView view);

		// -(void)alignLastView:(UIView *)view;
		[Export ("alignLastView:")]
		void AlignLastView (UIView view);

		// -(void)removeAddedConstraints;
		[Export ("removeAddedConstraints")]
		void RemoveAddedConstraints ();
	}

	// @interface Subclassing (OAStackViewAlignmentStrategy)
	[Category]
	[BaseType (typeof(OAStackViewAlignmentStrategy))]
	interface OAStackViewAlignmentStrategy_Subclassing
	{
		// -(NSString *)otherAxisString;
		[Export ("otherAxisString")]
		[Verify (MethodToProperty)]
		string OtherAxisString { get; }
	}

	// @interface OAStackViewAlignmentStrategyBaseline : OAStackViewAlignmentStrategy
	[BaseType (typeof(OAStackViewAlignmentStrategy))]
	interface OAStackViewAlignmentStrategyBaseline
	{
		// -(NSLayoutAttribute)baselineAttribute;
		[Export ("baselineAttribute")]
		[Verify (MethodToProperty)]
		NSLayoutAttribute BaselineAttribute { get; }
	}

	// @interface OAStackViewAlignmentStrategyLastBaseline : OAStackViewAlignmentStrategyBaseline
	[BaseType (typeof(OAStackViewAlignmentStrategyBaseline))]
	interface OAStackViewAlignmentStrategyLastBaseline
	{
	}

	// @interface OAStackViewAlignmentStrategyFirstBaseline : OAStackViewAlignmentStrategyBaseline
	[BaseType (typeof(OAStackViewAlignmentStrategyBaseline))]
	interface OAStackViewAlignmentStrategyFirstBaseline
	{
	}

	// @interface OAStackViewDistributionStrategy : NSObject
	[BaseType (typeof(NSObject))]
	interface OAStackViewDistributionStrategy
	{
		// @property (readonly, nonatomic) NSArray * addedConstraints;
		[Export ("addedConstraints")]
		[Verify (StronglyTypedNSArray)]
		NSObject[] AddedConstraints { get; }

		// +(OAStackViewDistributionStrategy *)strategyWithStackView:(OAStackView *)stackView;
		[Static]
		[Export ("strategyWithStackView:")]
		OAStackViewDistributionStrategy StrategyWithStackView (OAStackView stackView);

		// -(void)alignView:(UIView *)view afterView:(UIView *)previousView;
		[Export ("alignView:afterView:")]
		void AlignView (UIView view, UIView previousView);

		// -(void)removeAddedConstraints;
		[Export ("removeAddedConstraints")]
		void RemoveAddedConstraints ();
	}

	// @interface OATransformLayer : CATransformLayer
	[BaseType (typeof(CATransformLayer))]
	interface OATransformLayer
	{
	}

	// @interface _OALayoutGuide : UIView
	[BaseType (typeof(UIView))]
	interface _OALayoutGuide
	{
	}
}
