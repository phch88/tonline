pipeline{
	agent any
	
	stages {
		stage("build"){
			steps {
				bat "${tool 'MSBuild'} tonline.sln"
			}
		}

		stage("test"){
			steps {
				echo 'testing'
			}
		}
	}
}
