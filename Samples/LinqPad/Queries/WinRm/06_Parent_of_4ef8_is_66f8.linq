<Query Kind="Expression">
  <Connection>
    <ID>ceda4c03-6947-41d1-a094-c8f70c6efa7f</ID>
    <Persist>true</Persist>
    <Driver Assembly="TxLinqPadDriver" PublicKeyToken="3d3a4b0768c9178e">TxLinqPadDriver.TxDataContextDriver</Driver>
    <DriverData>
      <ContextName>WinRm</ContextName>
      <Files>C:\TxSamples\LinqPad\Traces\WsRm01.etl;</Files>
      <MetadataFiles>C:\TxSamples\LinqPad\Manifests\Web-Services-for-Management-Core.man;</MetadataFiles>
      <IsRealTime>false</IsRealTime>
      <IsUsingDirectoryLookup>false</IsUsingDirectoryLookup>
    </DriverData>
  </Connection>
  <Namespace>Microsoft.Etw.Microsoft_Windows_WinRM</Namespace>
</Query>

from e in playback.GetObservable<SystemEvent>()
where e.Header.RelatedActivityId == new Guid("ad23c1a1-bcf5-0001-4ef8-2aadf5bccb01")
select e.Header.ActivityId
