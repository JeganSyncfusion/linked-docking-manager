# Linked DockingManager
The windows from one DockingManager cannot be dragged and dropped to another DockingManager by default. But Linked Manager support allows to drag and drop the windows from one DockingManager to another by setting TargetDockingManager list.

## C#

    <syncfusion:DockingManager x:Name="DockingManager1" UseDocumentContainer="True">

    <ContentControl syncfusion:DockingManager.State="Document" syncfusion:DockingManager.Header="Window1" />

    <ContentControl syncfusion:DockingManager.State="Dock" syncfusion:DockingManager.Header="Window2" />

    <ContentControl syncfusion:DockingManager.State="AutoHidden" syncfusion:DockingManager.Header="Window3" />

    </syncfusion:DockingManager>

## C#

    <syncfusion:DockingManager x:Name="DockingManager2" UseDocumentContainer="True">

    <ContentControl syncfusion:DockingManager.State="Dock" syncfusion:DockingManager.Header="Window1"></ContentControl>

    <ContentControl syncfusion:DockingManager.State="Dock" syncfusion:DockingManager.Header="Window2"></ContentControl>

    <ContentControl syncfusion:DockingManager.State="AutoHidden" syncfusion:DockingManager.Header="Window3"></ContentControl>

    </syncfusion:DockingManager>

## Adding TargetManager list of DockingManager
To add TargetManager list in the DockingManager, call AddToTargetManagersList method of the DockingManager with the valid DockingManager instance as argument.

When only one DockingManager has TargetManagerList, the window drop to TargetManager cannot drag back to Owner DockingManger. For example DockingManager1 and DockingManager2 are the DockingManager instance and the DockingManager2 is added to TargetManagerList of DockingManager1, but the DockingManager2 is not aware of its TargetManager.

Here, the windows from DockingManager1 are only allowed to be dragged and dropped in DockingManager2,

## C#

    this.DockingManager1.AddToTargetManagersList(MainWindow.DockingManager2);

## C#

    this.DockingManager1.AddToTargetManagersList(MainWindow.DockingManager2);

    MainWindow.DockingManager2.AddToTargetManagersList(this.DockingManager1);

## Removing Target Manager list
To remove DockingManager from the TargetManagerList, call RemoveFromTargetManagerList of DockingManager with the valid DockingManager instance argument. 

## C#

    MainWindow.DockingManager2.RemoveFromTargetManagersList(this.DockingManager1);

For more details please click [Linked DockingManager](https://help.syncfusion.com/wpf/docking/linked-manager)
