pipeline{
	agent any
	
	stages {
		stage("build"){
			steps {
				bat "\"${tool 'MSBuild'}MsBuild\" tonline.sln"
			}
		}

		stage("test"){
			steps {
				echo 'testing'
			}
		}
	}
}
