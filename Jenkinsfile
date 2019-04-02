pipeline {
    agent { docker { image 'mcr.microsoft.com/dotnet/core/sdk:2.2-alpine' } }
    environment {HOME = '/tmp'} 
    stages {
    stage('Git') {
      // Get some code from a GitHub repository
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
               sh "dotnet test"
          }
    }
}
}
