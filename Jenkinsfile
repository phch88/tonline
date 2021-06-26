pipeline{
	agent any
	
	stages {
		stage("build"){
			steps {
				sh 'msbuild tonline.sln'
			}
		}

		stage("test"){
			steps {
				echo 'testing'
			}
		}
	}
}
