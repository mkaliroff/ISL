pipeline {
    //Use the following docker image to run your dotnet app.
    agent { docker { image 'mcr.microsoft.com/dotnet/core/sdk:2.2' } }
    environment {ASPNETCORE_ENVIRONMENT = 'Production'} 
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
               sh "dotnet test --logger "trx;LogFileName=HomeControllerTests.trx""
                
          }
    }
}
