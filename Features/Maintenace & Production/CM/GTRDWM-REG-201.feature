﻿Feature: 2.0.1 - Assigning a CM Work Order 

AS a Team Leader you need to Assign A single CM Work Order where there is no planned labour requirement generating an assignment.

@Feature:2.0.1-AssigningaCMWorkOrder
Scenario: 01) Create a CM Work Order
Given I sign as maxadmin
	And I open application Work Order Tracking (BRDA)
	And I select create new record
	And I set CM Work Order Description field to 'MWE TEST'
	And I choose Select Value from Detail Menu of Location field
	And I filter table Location:
      | Location |
      | 387102 |
	And I select no. 1 from Location table records
	And I open Select Value lookup for Work Type field
	And I filter table Work Type:
      | Type |
      | =CM |
	And I select no. 1 from Work Type table records
	And I choose Select Value from Detail Menu of Repair Facility
	And I filter table Repair Facility:
      | Repair Facility |
      | HORNSEY |
	And I select no. 1 record from Repair Facility table records
	And I open Select Value lookup for Priority field
	And I filter table Priority field:
      | Value |
      | Next Exam |
	And I select no. 1 record from Priority table records
	And I Scheduled Start Date to today's date
	And I save CM record
	And I verify generated work order number
	And I take screenshot of Assigning a CM Work Order Test Scenario one
	

	Examples:
      | role |
      |maxadmin|


 Scenario: 02) Assigning a CM Work Order
 Given I sign as teamlead
  And I open application Work Order Tracking BRDA from Favorite Menu
  And I filter table CM Work Order:
      | Description | Status  |
      | MWE TEST | =WAIT-REV |
  And I select no. 1 record from CM Work Order table records
  And I press route the workflow button
  And I set (Radio) field to Accept this Work Order into the Work Bank
  And I select dialog button ok
  And I press route the workflow button
  And I set (Radio) field to Send Work for Execution
  And I select Ok dialog button
  And I go to Assignments Tab
  And I add new row in Assignments Tab
  And I open Select Value lookup for Labor field
  And I filter table Labor:
      | Labor |
      | AGRAY |
  And I select no. 1 record from Labor table records
  #And I pree Ok dialog system message button
  And I verify CM work order generated
  And I save record
  And I take screenshot of Assigning a CM Work Order Test Scenario two
  
   Examples:
      | role        |
      | teamlead |


	