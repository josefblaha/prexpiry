& az deployment sub create `
    --location GermanyWestCentral `
    --name createE2EEnvironment `
    --template-file environment.bicep `
    --parameters envName=e2e appPlanSku=B1
