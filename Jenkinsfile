pipeline{
    agent any
    stages{
        stage("Clone"){
            steps{
                git url: 'https://github.com/leminhduc201299/hello-devops.git', branch: 'main'
            }
        }
        stage("Buld image"){
            steps{
                // This step should not normally be used in your script. Consult the inline help for details.
                withDockerRegistry(credentialsId: 'docker-hub', url: 'https://index.docker.io/v1/') {
                    sh 'ls'
                }
            }
        }
    }
}