pipeline{
	agent any
	
	stages {
		stage("build"){
			steps {
				bat 'msbuild tonline.sln'
			}
		}

		stage("test"){
			steps {
				echo 'testing'
			}
		}
	}
}
