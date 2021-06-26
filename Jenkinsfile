pipeline{
	agent any
	
	stages {
		stage("build"){
			steps {
				bat "\"${tool 'MSBuild'}\\MsBuild.exe\" tonline.sln"
			}
		}

		stage("test"){
			steps {
				echo 'testing'
			}
		}
	}
}
