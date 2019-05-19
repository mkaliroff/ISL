pipeline {
    //Use the following docker image to run your dotnet app.
    agent { docker { image 'mcr.microsoft.com/dotnet/core/sdk:2.2' } }
    environment {HOME = '/tmp'} 
    stages {
    // Get some code from a GitHub repository
    stage('Git') {
      steps{
          git 'https://github.com/mkaliroff/ISL.git'
      }
   }
    stage('Dotnet Restore'){
        steps{
        sh "dotnet restore"
        }
    }
    
   stage('Build'){
          steps{
               sh "dotnet build"
               }
    }
    stage('Run Tests'){
          steps{
               sh "HomeControllerTests.cs"
                
          }
    }
    }
  post {
    always {
      step ([$class: 'MSTestPublisher', testResultsFile:"**/TestResults/UnitTests.trx", failOnError: true, keepLongStdio: true])
    }
  }
  tools {
    msbuild '.NET Core 2.2.103'
  }
  environment {
    ASPNETCORE_ENVIRONMENT = 'Production'
  }
}
