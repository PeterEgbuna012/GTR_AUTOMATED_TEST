Feature: GTR-UAT-TAS-006 - Update status of  locked Toilet Asset

Toilet Checker tries to update a status of a locked asset. 


@Feature:GTR-UAT-TAS-006-UpdatestatusoflockedToiletAsset
Scenario: Update status of  locked Toilet Asset
	Given I sign as clean master
	And I open application Toilet Checker (MXR)
	And I filter table Toilet Checker:
      | Toilet Checker |
      | 171729 |
	And I change toilet asset statuse button
	And I press ok dialog system message button
	And I take screenshot of Update status of  locked Toilet Asset Test



	Examples:
      | role |
      | clean master |
	
