using System;
using System.Drawing;

using Foundation;
using UIKit;
using ObjCRuntime;
using CoreAnimation;
using CoreGraphics;

namespace OAStackView {

	// @interface OAStackView : UIView
	[BaseType (typeof (UIView))]
	interface OAStackView {

		// -(instancetype)initWithArrangedSubviews:(NSArray *)views;
		[Export ("initWithArrangedSubviews:")]
		IntPtr Constructor (NSObject [] views);

		// @property (readonly, copy, nonatomic) NSArray * arrangedSubviews;
		[Export ("arrangedSubviews", ArgumentSemantic.Copy)]
		NSObject [] ArrangedSubviews { get; }

		// @property (nonatomic) UILayoutConstraintAxis axis;
		[Export ("axis")]
		UILayoutConstraintAxis Axis { get; set; }

		// @property (nonatomic) NSInteger axisValue;
		[Export ("axisValue")]
		nint AxisValue { get; set; }

		// @property (nonatomic) CGFloat spacing;
		[Export ("spacing")]
		nfloat Spacing { get; set; }

		// @property (nonatomic) OAStackViewAlignment alignment;
		[Export ("alignment")]
		OAStackViewAlignment Alignment { get; set; }

		// @property (nonatomic) NSInteger alignmentValue;
		[Export ("alignmentValue")]
		nint AlignmentValue { get; set; }

		// @property (nonatomic) OAStackViewDistribution distribution;
		[Export ("distribution")]
		OAStackViewDistribution Distribution { get; set; }

		// @property (nonatomic) NSInteger distributionValue;
		[Export ("distributionValue")]
		nint DistributionValue { get; set; }

		// @property (nonatomic) UIEdgeInsets layoutMargins;
		[Export ("layoutMargins")]
		UIEdgeInsets LayoutMargins { get; set; }

		// @property (nonatomic, getter = isLayoutMarginsRelativeArrangement) BOOL layoutMarginsRelativeArrangement;
		[Export ("layoutMarginsRelativeArrangement")]
		bool LayoutMarginsRelativeArrangement { [Bind ("isLayoutMarginsRelativeArrangement")] get; set; }

		// -(void)addArrangedSubview:(UIView *)view;
		[Export ("addArrangedSubview:")]
		void AddArrangedSubview (UIView view);

		// -(void)removeArrangedSubview:(UIView *)view;
		[Export ("removeArrangedSubview:")]
		void RemoveArrangedSubview (UIView view);

		// -(void)insertArrangedSubview:(UIView *)view atIndex:(NSUInteger)stackIndex;
		[Export ("insertArrangedSubview:atIndex:")]
		void InsertArrangedSubview (UIView view, nuint stackIndex);
	}

	// @interface Constraint (OAStackView)
	[Category]
	[BaseType (typeof (OAStackView))]
	interface Constraint {

		// -(NSArray *)constraintsAffectingView:(UIView *)view;
		[Export ("constraintsAffectingView:")]
		NSObject [] ConstraintsAffectingView (UIView view);

		// -(NSArray *)constraintsAffectingView:(UIView *)view inAxis:(UILayoutConstraintAxis)axis;
		[Export ("constraintsAffectingView:inAxis:")]
		NSObject [] ConstraintsAffectingView (UIView view, UILayoutConstraintAxis axis);

		// -(NSArray *)constraintsBetweenView:(UIView *)firstView andView:(UIView *)otherView inAxis:(UILayoutConstraintAxis)axis;
		[Export ("constraintsBetweenView:andView:inAxis:")]
		NSObject [] ConstraintsBetweenView (UIView firstView, UIView otherView, UILayoutConstraintAxis axis);

		// -(NSArray *)constraintsBetweenView:(UIView *)firstView andView:(UIView *)otherView inAxis:(UILayoutConstraintAxis)axis includeReversed:(BOOL)includeReversed;
		[Export ("constraintsBetweenView:andView:inAxis:includeReversed:")]
		NSObject [] ConstraintsBetweenView (UIView firstView, UIView otherView, UILayoutConstraintAxis axis, bool includeReversed);

		// -(void)removeDecendentConstraints;
		[Export ("removeDecendentConstraints")]
		void RemoveDecendentConstraints ();

		// -(NSArray *)firstConstraintAffectingView:(UIView *)superView andView:(UIView *)childView inAxis:(UILayoutConstraintAxis)axis;
		[Export ("firstConstraintAffectingView:andView:inAxis:")]
		NSObject [] FirstConstraintAffectingView (UIView superView, UIView childView, UILayoutConstraintAxis axis);

		// -(NSArray *)lastConstraintAffectingView:(UIView *)superView andView:(UIView *)childView inAxis:(UILayoutConstraintAxis)axis;
		[Export ("lastConstraintAffectingView:andView:inAxis:")]
		NSObject [] LastConstraintAffectingView (UIView superView, UIView childView, UILayoutConstraintAxis axis);
	}

	// @interface Hiding (OAStackView)
	[Category]
	[BaseType (typeof (OAStackView))]
	interface Hiding {

		// -(void)addObserverForView:(UIView *)view;
		[Export ("addObserverForView:")]
		void AddObserverForView (UIView view);

		// -(void)addObserverForViews:(NSArray *)views;
		[Export ("addObserverForViews:")]
		void AddObserverForViews (NSObject [] views);

		// -(void)removeObserverForView:(UIView *)view;
		[Export ("removeObserverForView:")]
		void RemoveObserverForView (UIView view);

		// -(void)removeObserverForViews:(NSArray *)views;
		[Export ("removeObserverForViews:")]
		void RemoveObserverForViews (NSObject [] views);
	}

	// @interface Traversal (OAStackView)
	[Category]
	[BaseType (typeof (OAStackView))]
	interface Traversal {

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
		NSObject [] CurrentVisibleViews ();

		// -(UIView *)lastVisibleItem;
		[Export ("lastVisibleItem")]
		UIView LastVisibleItem ();

		// -(NSLayoutConstraint *)firstViewConstraint;
		[Export ("firstViewConstraint")]
		NSLayoutConstraint FirstViewConstraint ();

		// -(NSLayoutConstraint *)lastViewConstraint;
		[Export ("lastViewConstraint")]
		NSLayoutConstraint LastViewConstraint ();

		// -(BOOL)isViewLastItem:(UIView *)view excludingItem:(UIView *)excludingItem;
		[Export ("isViewLastItem:excludingItem:")]
		bool IsViewLastItem (UIView view, UIView excludingItem);
	}

	// @interface OAStackViewAlignmentStrategy : NSObject
	[BaseType (typeof (NSObject))]
	interface OAStackViewAlignmentStrategy {

		// +(OAStackViewAlignmentStrategy *)strategyWithStackView:(OAStackView *)stackView;
		[Static, Export ("strategyWithStackView:")]
		OAStackViewAlignmentStrategy StrategyWithStackView (OAStackView stackView);

		// -(void)addConstraintsOnOtherAxis:(UIView *)view;
		[Export ("addConstraintsOnOtherAxis:")]
		void AddConstraintsOnOtherAxis (UIView view);

		// -(void)alignView:(UIView *)view withPreviousView:(UIView *)previousView;
		[Export ("alignView:withPreviousView:")]
		void AlignView (UIView view, UIView previousView);

		// -(void)removeAddedConstraints;
		[Export ("removeAddedConstraints")]
		void RemoveAddedConstraints ();
	}

	// @interface Subclassing (OAStackViewAlignmentStrategy)
	[Category]
	[BaseType (typeof (OAStackViewAlignmentStrategy))]
	interface Subclassing {

		// -(NSString *)otherAxisString;
		[Export ("otherAxisString")]
		string OtherAxisString ();
	}

	// @interface OAStackViewAlignmentStrategyBaseline : OAStackViewAlignmentStrategy
	[BaseType (typeof (OAStackViewAlignmentStrategy))]
	interface OAStackViewAlignmentStrategyBaseline {

		// -(NSLayoutAttribute)baselineAttribute;
		[Export ("baselineAttribute")]
		NSLayoutAttribute BaselineAttribute ();
	}

	// @interface OAStackViewAlignmentStrategyLastBaseline : OAStackViewAlignmentStrategyBaseline
	[BaseType (typeof (OAStackViewAlignmentStrategyBaseline))]
	interface OAStackViewAlignmentStrategyLastBaseline {

	}

	// @interface OAStackViewAlignmentStrategyFirstBaseline : OAStackViewAlignmentStrategyBaseline
	[BaseType (typeof (OAStackViewAlignmentStrategyBaseline))]
	interface OAStackViewAlignmentStrategyFirstBaseline {

	}

	// @interface OAStackViewDistributionStrategy : NSObject
	[BaseType (typeof (NSObject))]
	interface OAStackViewDistributionStrategy {

		// +(OAStackViewDistributionStrategy *)strategyWithStackView:(OAStackView *)stackView;
		[Static, Export ("strategyWithStackView:")]
		OAStackViewDistributionStrategy StrategyWithStackView (OAStackView stackView);

		// -(void)alignView:(UIView *)view afterView:(UIView *)previousView;
		[Export ("alignView:afterView:")]
		void AlignView (UIView view, UIView previousView);

		// -(void)removeAddedConstraints;
		[Export ("removeAddedConstraints")]
		void RemoveAddedConstraints ();
	}

	// @interface OATransformLayer : CATransformLayer
	[BaseType (typeof (CATransformLayer))]
	interface OATransformLayer {

	}

	// @interface _OALayoutGuide : UIView
	[BaseType (typeof (UIView))]
	interface _OALayoutGuide {

	}
}
