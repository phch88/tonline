pipeline{
	agent any
	
	stages {
		stage("build"){
			steps {
				bat 'C:\Program Files (x86)\Microsoft Visual Studio\2019\Community\MSBuild\Current\Bin\msbuild tonline.sln'
			}
		}

		stage("test"){
			steps {
				echo 'testing'
			}
		}
	}
}
