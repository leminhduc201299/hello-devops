pipeline{
    agent any
    stages{
        stage("Clone"){
            steps{
                git url: 'https://github.com/leminhduc201299/hello-devops.git', branch: 'main', credentialsId: 'github-account'
            }
        }
        stage("Buld image"){
            steps{
                sh 'docker ps'
                
                // This step should not normally be used in your script. Consult the inline help for details.
                withDockerRegistry(registry: [url: 'https://index.docker.io/v1/', credentialsId: 'docker-hub'], toolName: 'docker'){
                    sh 'ls'
                }
            }
        }
    }
}