using UIKit;
using Foundation;

namespace TPKeyboardAvoiding
{
    [BaseType (typeof(UIScrollView))]
	[Protocol]
    public partial interface TPKeyboardAvoidingScrollView
    {
        [Export ("contentSizeToFit")]
        void ContentSizeToFit ();

        [Export ("focusNextTextField")]
        bool FocusNextTextField { get; }

        [Export ("scrollToActiveTextField")]
        void ScrollToActiveTextField ();
    }

    [Category, BaseType (typeof(UIScrollView))]
    public partial interface TPKeyboardAvoidingAdditions_UIScrollView
    {
        [Export ("TPKeyboardAvoiding_scrollToActiveTextField")]
        void TPKeyboardAvoiding_scrollToActiveTextField ();

        [Export ("TPKeyboardAvoiding_keyboardWillShow:")]
        void TPKeyboardAvoiding_keyboardWillShow (NSNotification notification);

        [Export ("TPKeyboardAvoiding_keyboardWillHide:")]
        void TPKeyboardAvoiding_keyboardWillHide (NSNotification notification);

        [Export ("TPKeyboardAvoiding_updateContentInset")]
        void TPKeyboardAvoiding_updateContentInset ();

        [Export ("TPKeyboardAvoiding_updateFromContentSizeChange")]
        void TPKeyboardAvoiding_updateFromContentSizeChange ();

        [Export ("TPKeyboardAvoiding_assignTextDelegateForViewsBeneathView:")]
        void TPKeyboardAvoiding_assignTextDelegateForViewsBeneathView (UIView view);

        [Export ("TPKeyboardAvoiding_findFirstResponderBeneathView:")]
        UIView TPKeyboardAvoiding_findFirstResponderBeneathView (UIView view);
    }
}
