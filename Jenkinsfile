pipeline {
    //Use the following docker image to run your dotnet app.
    agent { docker { image 'mcr.microsoft.com/dotnet/core/sdk:2.2-alpine' } }
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
        //sh "restore nugets C:/Program Files (x86)/Jenkins/tools/nuget/NuGet.exe"
        sh "dotnet restore DeliverySite/DeliverySite/DeliverySite.csproj"
        }
    }
    
    stage('Build'){
          steps{
              sh "dotnet build DeliverySite/DeliverySite/DeliverySite.csproj"
           }
    }
    
    stage('Run Tests'){
          steps{
               sh "dotnet test DeliverySite/DeliverySite.sln"
          }
    }
}
}
