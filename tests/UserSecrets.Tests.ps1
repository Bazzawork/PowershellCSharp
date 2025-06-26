Describe 'UsingSecrets' -Tag 'UnitTest' {
    BeforeAll {
        # Put any mocking code here etc.
        . $PSScriptRoot/Shared.ps1
        Initialize-TestEnvironment -ProjectName 'UsingSecrets'
    }
    It 'should do something' {
        # arrange
        $expected = "This Is A Test Secret"

        # act
        $actual = Get-BazSecret

        # assert
        $actual | Should -Be $expected

    }
}