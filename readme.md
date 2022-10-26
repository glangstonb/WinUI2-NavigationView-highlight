#### WinUI2 NavigationView highlight bug

Build and run the application, you should see a window with a NavigationView with some navigation items in it. The top two are fixed and have no children, then there's a root with a randomly generated tree of descendant items. Inside the actual page contents you will see some brief instructions and 3 buttons arranged vertically.

Click on one of the fixed items at the top and notice that it becomes highlighted. Then click the top button on the page, which will call `RefreshFixedItems()`. (This clears and repopulates the ObservableCollection that the NavigationView.MenuItemsSource is bound to.) Then click on one of the items in the random tree. Notice that the fixed item you originally clicked remains highlighted as if it is selected, even though the new item you clicked also becomes highlighted.

If you click on other (non-highlighted) items and then click the buttons on the page, you may be able to get multiple items to incorrectly highlight at once. Try playing around with the items and the buttons to see variations on the bug behavior.