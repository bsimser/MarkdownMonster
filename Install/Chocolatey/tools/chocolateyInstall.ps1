$packageName = 'markdownmonster'
$fileType = 'exe'
$url = 'https://github.com/RickStrahl/MarkdownMonsterReleases/raw/master/v1.0/MarkdownMonsterSetup-1.0.19.exe'

$silentArgs = '/SILENT'
$validExitCodes = @(0)


Install-ChocolateyPackage "packageName" "$fileType" "$silentArgs" "$url"  -validExitCodes  $validExitCodes  -checksum "EC72B18379831EFC1899B572204A3D569E6B1352EFA59B5D9DB725C3791A1DF8" -checksumType "sha256"
