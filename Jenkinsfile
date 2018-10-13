node {
	stage 'Checkout'
		checkout scm

	stage 'Restore'
		bat 'dotnet restore EquationsOfMotion.sln'
 		
	stage 'Build Release NetCore'
		bat "dotnet build EquationsOfMotion/EquationsOfMotion.csproj --configuration Release"
		
	stage 'Build Debug NetCore'
		bat "dotnet build EquationsOfMotion/EquationsOfMotion.csproj --configuration Debug"
	
	stage 'Unit Tests'
		bat "dotnet test UnitTest.EquationsOfMotion/UnitTest.EquationsOfMotion.csproj --logger:trx"

	stage 'Archive'
		archive 'EquationsOfMotion/bin/**/*'
}
