Feature: 3.0.0 - Create a PM

You need to create a PM to generate a PM Work Order Ad Hoc out of the frequency sequence

# Setup scenario
@Feature:3.0.0-CreateaPM
Scenario: Create a PM
	Given I sign as maxadmin
    When I open application Preventive Maintenance, Preventative Maintenance (BRDA)
    And I create new record
    And I set PM Description field to "TAUTO PM WO"
    And I choose Select Value from Detail Menu of Asset Group field
    And I filter table Asset Group:
      | Asset Group |
      | UNIT 387102 |
    And I select no. 1 record from Asset table records
    And I set Lead Time Days field to "182"
    And I set Include this PM in the Forecast[Checkbox] field to False
    And I open Select Value lookup for Work Type field
    And I filter table:
      | Work Type |
      | =PM   |
    And I select no.1 record PM from table
    And I set Priority field to "6"
    And I set Owner Group field to "RS"
    And I set Interruptible [Checkbox] field to true
    And I set GL Account field to "00000-00000-0000"
    And I save record
    And I press Change Status button
    And I press the dropdown new status button
    And I select active status
	And I set Roll New Status to All Child PMs[Checkbox] field to True
    And I press dialog button OK
    Then field Status has value ACTIVE
    And I take screenshot of Create a PM test

	Examples:
      | role        |
      | maxadmin |
