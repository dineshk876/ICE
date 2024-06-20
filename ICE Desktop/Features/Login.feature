Feature: Login with valid and invalid credentials

	//@DataSource:..\TestData\ReportPart.xlsx
	@Behavior
	Scenario: Login with valid credentials
		Given Login with credentials <UserName> and <Password>
		Then Verify home page is dispalyed

		Examples:
			| UserName| Password  |
			| ice\sunquest | ice4dmin |
		
	@Behavior
	Scenario: Login with invalid credentials
		Given Login with credentials <UserName> and <Password>
		Then Verify invalid credential message is displaying

		Examples:
			| UserName| Password  |
			| ice\sunquest | icedmin |

