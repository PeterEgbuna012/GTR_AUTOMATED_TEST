﻿Feature: 0.0.4 - Pausing an EM Work Order

You have been give an Work Order. You have started it but must pause it to take a break

@Feature:0.0.4-PausinganEMWorkOrder
Scenario: 01) Create a EM Work Order
	Given I sign as teamlead
	When I open application Work Orders, Fault Reporting (BRDA)
    And I create new record
    And I choose Select Value from Detail Menu of Location field
    And I filter table Location:
      | Location |
      | HORNSEY |
    And I select no. 1 record from Location table records
    And I open Select Value lookup for Failure Group field
    And I select no. 3 record from Failure Group table
    And I open Select Value lookup for Failure Code field
    And I select no. 1 record from Failure Code table
    And I open Select Value lookup for Problem Code field
    And I select no. 1 record from Problem Code table
    And I open Select Value lookup for Repair Facility field
    And I filter table Repair Facility:
      | Repair Facility |
      | HORNSEY |
	And I select no. 1 record from Repair Facility table
    And I open Select Value lookup for Reported Priority
    And I select no. 8 record from Reported Priority table
    And I enter following data to Headcode:
      | Headcode |
      | TAUTO|
    And I enter following data:
      | Summary | Details |
      | Pausing an EM Work Order | Auto Test EM Work Order |
    And I route the workflow
    #And I press Ok button
    And I press dialog button of Show Duplicate Tickets
    And I route the workflow
    And I set (Radio) field to Raise a Depot Work Order
    Then I press dialog button OK
    When I go to Related Records tab
    And I view Related Work Order
    Then field Status has value WAIT-REV
    And I take screenshot of Pausing an EM Work Order scenario one


	  Examples:
      | role |
      | teamlead | 




Scenario:  02) Accepting An EM Work Order into the Work Bank
	 Given I sign as teamlead
	 And I open application Work Order Tracking BRDA from Fav Menu
     When I filter table EM:
		| Description | Status | Work Type |
		| Pausing an EM Work Order | =WAIT-REV | =EM |
    And I select no. 1 record from EM table
    And I press route the workflow button
	And I set (Radio) Box to Accept this Work Order into the Work Bank
	And I press OK dialog button
	And  work order Status field has value REVIEWED
	And I take screenshot of Pausing an EM Work Order scenario two


	 Examples:
      | role |
      | teamlead | 




Scenario: 03)  Assigning an EM Work Orderr
	Given I sign as teamlead
	  And I open application Work Order Tracking BRDA from Fav Menu
      When I filter table EM:
		| Description | Status | Work Type |
		| Pausing an EM Work Order | =REVIEWED | =EM |
     And I select no. 1 record from EM table
     And I go to Assignment tab
	 And I press add new row under Assignments tab
	 And I select Value lookup for Labor field
      And I filter table labor:
      | labor |
      | ISCOTT |
	 And I select no.2 from labor table record
	 And I save
	 And I press route the workflow button
	 And I set (Radio) Box to Send Work For Execution
	 And I click OK dialog button
	 And I verify Status field has value SCHEDULED
	 And I take screenshot of Pausing an EM Work Order scenario three

	 Examples:
      | role  |
      | teamlead | 


Scenario: 04) Pausing an EM Work Order
	Given I sign as teamlead
	And I open application Work Order Tracking BRDA from Fav Menu
	 When I filter table EM:
		| Description | Status | Work Type |
		| Pausing an EM Work Order | =SCHEDULED | =EM |
	And I select no. 1 record from EM table
	And I press route the workflow button
	And I set (Radio) Box to Start Work order
	And I press dialog Ok
	And I verify Work Order status has value INPRG
	And I return to Maintainer Start Center
	And I open application Work Order Tracking BRDA from Fav Menu
	 When I filter table EM:
		| Description | Status | Work Type |
		| Pausing an EM Work Order | =INPRG | =EM |
	And I select no. 1 record from EM table
	And I press route the workflow button
	And I set (Radio) Box to Pause Work order
	And I click dialog Ok
	And I verify Status field has value INPRG-HOLD
	And I take screenshot of Pausing an EM Work Order test test scenario four
	And I return to Maintainer Start Center
	
	
	 Examples:
      | role        |
      | teamlead | 
