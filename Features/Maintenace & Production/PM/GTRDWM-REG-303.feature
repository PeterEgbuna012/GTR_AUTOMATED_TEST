﻿Feature: 3.0.3 - Complete a PM Work Order Task

As a Team Leader, you need to Assign A single PM Work Order where there is a planned labour requirement generating an assignment.

@Feature:3.0.3-CompleteaPMWorkOrderTask
Scenario:01) Create a PM
	Given I sign as maxadmin
    When I open application Preventive Maintenance, Preventative Maintenance (BRDA)
    And I create new record
    And I enter Description:
      | Description |
      |  COMPLETE PM WO AUTOT 3.8.8  |
    And I choose Select Value from Detail Menu of Asset Group field
    And I filter table Asset Group:
      | Asset Group |
      | UNIT 387102 |
    And I select no. 1 record from Asset table records
    And I enter Lead Time Days:
      | Lead Time Days |
      | 182 |
    And I set Include this PM in the Forecast[Checkbox] field to False
    And I open Select Value lookup for Work Type field
    And I filter table:
      | Work Type |
      | =M1   |
    And I select no.1 record PM from table
     And I enter data to following:
      | Priority | Owner Group |
      | 6 | RS |
    And I set Interruptible [Checkbox] field to true
    And I enter GL Account:
      | GL Account |
      | 00000-00000-0000 |
    And I save record
    And I press Change Status button
    And I press the dropdown new status button
    And I select active status
	And I set Roll New Status to All Child PMs[Checkbox] field to True
    And I press dialog button OK
    Then field Status has value ACTIVE
    And I take screenshot of Complete a PM Work Order Task scenario one

	Examples:
      | role        |
      | maxadmin |



  Scenario:02) Generating Ad Hoc PM Work Order
    Given I sign in as teamlead
    When I open application Preventive Maintenance, Preventative Maintenance (BRDA)
    When I filter table PMs:
      | Description | Status  | Parent |
      | COMPLETE PM WO AUTOT 3.8.8 | =ACTIVE | ~Null~ |
    And I select no. 1 record from PMs table
    And I select action Generate Work Orders
    And I set Use Frequency Criteria[Checkbox] field to false
    And I press the button OK
    And the message appears BMXAA3208I
    And I press the button Ok
    And I take screenshot of Complete a PM Work Order Task Scenario two

	 Examples:
      | role        |
      | teamlead |


Scenario: 03) Assigning a PM Work Order Task
  Given I sign as teamlead
  And I open application Work Order Tracking BRDA from Favorite Menu
  When I filter table PM:
		| Description | Status | Work Type |
		| COMPLETE PM WO AUTOT 3.8.8 | =SCHEDULED | =M1 |
  And I select no. 1 record from PMs table
  And I go to Assignments Tab
  And I add new row in Assignments Tab
  And I open Select Value lookup for Labor field
   And I filter Labor table:
      | Labor |
      | CBRUNS |
    And I select no. 1 from Labor table records
  And I save record
  And I take screenshot of Complete a PM Work Order Task Scenario three

   Examples:
      | role        |
      | teamlead |


Scenario: 04) Complete a PM Work Order Task
  Given I sign as teamlead
  And I open application Work Order Tracking BRDA from Favorite Menu
  When I filter table PM:
		| Description | Status | Work Type |
		| COMPLETE PM WO AUTOT 3.8.8 | =SCHEDULED | =M1 |
  And I select no. 1 record from PMs table
  And I press route the workflow button
  And I set (Radio) field to Start Work order
  And I press Ok dialog button
  And I return to Maintainer Start Center
  And I open application Work Order Tracking BRDA from Favorite Menu
  When I filter table PM:
		| Description | Status | Work Type |
		| COMPLETE PM WO AUTOT 3.8.8 | =INPRG | =M1 |
  And I select no. 1 record from PMs table
  And I press route the workflow button
  And I set (Radio) field to Complete Work Assignment
  And I press dialog button Ok
  And I press dialog button Close
  And I go to Tab actuals
  And I add new row in Labor Tab
  And I choose select Value from Detail Menu of Labor field
  And I filter table Labor:
      | Labor |
      | ISCOTT |
  And I select no. 4 record from Labor table records
  And I set Start and End time
  And I save record
  And I press route the workflow button
  Then Status field has value COMP-WREV
  And I take screenshot of Complete a PM Work Order Task scenario four

  Examples:
      | role        |
      | teamlead |
