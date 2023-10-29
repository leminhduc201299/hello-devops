pipeline{
    agent any
    stages{
        stage("Clone"){
            steps{
                git url: 'https://github.com/leminhduc201299/hello-devops.git', branch: 'main'
            }
        }
        stage("Clone"){
            steps{
                // This step should not normally be used in your script. Consult the inline help for details.
                withDockerRegistry(credentialsId: 'docker-hub', url: 'https://index.docker.io/v1/') {
                    sh 'call MISA.Fresher.CukCuk.Api/buildlocal.bat 1.0.0.10'
                }
            }
        }
    }
}