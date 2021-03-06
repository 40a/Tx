<Query Kind="Statements">
  <Connection>
    <ID>88a04bb7-535c-43a6-99c6-385c238126df</ID>
    <Driver Assembly="Tx.LinqPad" PublicKeyToken="3d3a4b0768c9178e">Tx.LinqPad.TxDataContextDriver</Driver>
    <DriverData>
      <ContextName>http</ContextName>
      <Files>($SampleTraces)HTTP_Server.etl;</Files>
      <MetadataFiles>($SampleTraces)HTTP_Server.man;</MetadataFiles>
      <IsRealTime>false</IsRealTime>
      <IsUsingDirectoryLookup>false</IsUsingDirectoryLookup>
    </DriverData>
  </Connection>
  <Namespace>Tx.Windows.Microsoft_Windows_HttpService</Namespace>
</Query>

playback.KnownTypes = typeof(Parse).Assembly.GetTypes();

var formatted = from e in playback.GetObservable<SystemEvent>()
			    where e.Header.ActivityId == new Guid("80000146-0000-fe00-b63f-84710c7967bb")
				select new { 
					e.OccurenceTime, 
					Type = e.GetType().Name, 
					Message = e.ToString() 
				};
				
				
formatted.Dump();