<Query Kind="Statements">
  <Connection>
    <ID>85e005ee-afee-4220-a54b-48309a19fbe9</ID>
    <Persist>true</Persist>
    <Server>.\SQLEXPRESS</Server>
    <SqlSecurity>true</SqlSecurity>
    <UserName>sa</UserName>
    <Password>AQAAANCMnd8BFdERjHoAwE/Cl+sBAAAApIpboxkMi0KXQm107ZYAoQAAAAACAAAAAAAQZgAAAAEAACAAAAA+o+wHUy4p9YtPQHc6h3Z2iDT27pglGNufB4QfBcSsjgAAAAAOgAAAAAIAACAAAACzh0XHY0HGZRWj2OtOHIb5sql57QDheDKHaViWbjvUNxAAAADAXx61ZFnJ/kwA+/G+4QhGQAAAAKSn7scekFSBo+9qFy6+vWGupy1VlDQav9CAYcj5Z47lyfLG1RdXZuM/UIN6Cgu9tDkN+nBnHtGbRH6iF37G9F4=</Password>
    <Database>uspostalcodes</Database>
    <ShowServer>true</ShowServer>
  </Connection>
  <Reference Relative="..\customassembly\bin\Debug\customassembly.dll">C:\LINQPad_Succinctly\customassembly\bin\Debug\customassembly.dll</Reference>
</Query>

var counties = new List<Counties>();
var totalRows = Counties.Count();
var rowIndex = 0;

foreach (var row in Counties)
{
      Util.Progress =  (rowIndex * 100) / totalRows;
       counties.Add(row);
	   rowIndex++;
	   Thread.Sleep(2);  //A small delay to watch the progress 
}
Util.Progress = 100;
counties.Dump();