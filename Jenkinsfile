pipeline{
	agent any
	
	stages {
		stage("build"){
			steps {
				echo 'building'
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