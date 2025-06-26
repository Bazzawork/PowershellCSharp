Describe 'BuildScripts Tests' {
  BeforeAll {
    . $PSScriptRoot/Shared.ps1
    Initialize-TestEnvironment -ProjectName 'BuildScripts'
  }

    Context 'Get-PEURandomEmail' {
      It 'Returns a random email using the Lorem Library' {
        $actual = Get-PEURandomEmail
        $actual | Should -Not -BeNullOrEmpty
        [mailaddress]$actual | Should -Not -BeNullOrEmpty
      }

      It '-UsernameOnly switch only returns the username' {
        $actual = Get-PEURandomEmail -UsernameOnly
        $actual | Should -Not -BeNullOrEmpty
        $actual | Should -Not -Contain '@'
        $actual | Should -Not -Contain '.'
      }
    }
  Context 'Get-PEURandonLetter' {
    It 'Returns a random letter' {
      $actual = Get-PEURandomLetter
      $actual | Should -Not -BeNullOrEmpty
      $actual | Should -Match '^[a-zA-Z]$'
    }
  }
  Context 'Get-CeTenableAgentGroup'{
    It 'Returns a Tenable Agent Group' {
      $actual = Get-CeTenableAgentGroup
      $actual | Should -Not -BeNullOrEmpty

    }
  }
}