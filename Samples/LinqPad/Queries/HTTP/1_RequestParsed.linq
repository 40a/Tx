<Query Kind="Expression">
  <Connection>
    <ID>bceb0ed6-52bc-45f7-b629-a9ea8ae98bbb</ID>
    <Persist>true</Persist>
    <Driver Assembly="TxLinqPadDriver" PublicKeyToken="3d3a4b0768c9178e">TxLinqPadDriver.TxDataContextDriver</Driver>
    <DriverData>
      <ContextName>http</ContextName>
      <Files>c:\TxSamples\LINQPad\Traces\HTTP_Server.etl;</Files>
      <MetadataFiles>c:\TxSamples\LINQPad\Manifests\HTTP_Server.man;</MetadataFiles>
      <IsRealTime>false</IsRealTime>
      <IsUsingDirectoryLookup>false</IsUsingDirectoryLookup>
    </DriverData>
  </Connection>
  <Namespace>Microsoft.Etw.Microsoft_Windows_HttpService</Namespace>
</Query>


from p in playback.GetObservable<Parse>()
select new
{
	p.Header.ActivityId,
	p.Url
}