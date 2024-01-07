targetScope='subscription'

param envName string
param location string = 'germanywestcentral'
param appPlanSku string

resource rg 'Microsoft.Resources/resourceGroups@2023-07-01' = {
  name: 'rg-prexpiry-${envName}'
  location: location
}

module app 'app.bicep' = {
  name: 'appModule'
  scope: rg
  params: {
    envName: envName
    location: location
    appPlanSku: appPlanSku
  }
}
