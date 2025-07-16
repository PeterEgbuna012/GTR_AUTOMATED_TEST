Feature: 2.0.7 - Automatic work order status transition to WMATL


As a Team Leader when a WO requires a part but it has nil stock the work order should automatically change status to WMATL

@Feature:2.0.7-AutomaticworkorderstatustransitiontoWMATL
Scenario: Automatic work order status transition to WMATL
   Given I sign as teamlead
   And I open application Inventory
   And I filter table Inventory:
      | Item | storeroom  |
      | 093/100225 | =HE-Value |
   And I return to Maintainer Start Center
   And I go to Team Leader Arising Tab
   And I filter table Team Leader Arising Tab Work Type:
      | Type |
      | =CM |
   And I select CM Work Order from table records
   And I go to tab Plan
   And I go to tab materials
   And I press add new row under materials tab
   And I choose Select Value from Detail Menu of Item field
   And I filter table Item:
      | Item |
      | 093/100225 |
   And I select no. 1 record from Item table records
   And I choose Select Value from Detail Menu of Storeroom field
   And I select no. 1 record from Storeroom table records
   And I set Direct Issue active
   And I save record
   And I press route the workflow button
   And I set (Radio) field to Waiting Materials
   And I press ok dialog button
   And I verify Status field has value WMATL
   And I verify generated WMATL work order number
   And I take screenshot of Automatic work order status transition to WMATL test


 Examples:
      | role        |
      | teamlead | 
