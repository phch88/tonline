pipeline{
	agent any
	
	stages {
		stage("build"){
			steps {
				echo 'building'
				bat "\"${tool 'MSBuild'}\\MsBuild.exe\" tonline.sln"
			}
		}

		stage("test"){
			steps {
				echo 'testing'
				bat "\"${tool 'MSTest'}\\MSTest.exe\" tonline.test\\bin\\Debug\\tonline.test.dll"
			}
		}
	}
}
