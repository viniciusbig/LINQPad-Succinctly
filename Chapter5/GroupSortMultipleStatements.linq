<Query Kind="Statements">
  <Connection>
    <ID>4622f248-c135-4ab6-b5cc-3c902ba74b1a</ID>
    <Persist>true</Persist>
    <Server>.\SQLEXPRESS</Server>
    <SqlSecurity>true</SqlSecurity>
    <Database>uspostalcodes</Database>
    <UserName>sa</UserName>
    <Password>AQAAANCMnd8BFdERjHoAwE/Cl+sBAAAApIpboxkMi0KXQm107ZYAoQAAAAACAAAAAAAQZgAAAAEAACAAAABEztiU1HQ+CPaM4reYnQPcF33FuDpNcQL0fgSe6xmOrQAAAAAOgAAAAAIAACAAAAChaXjgVwwDgZBT5Q1w6Ph0yWP9aBNgg56OnVWi+lIf8RAAAACtnt5966RViBrJw1cup05mQAAAAN87RLNTMpfRfQWOhD2XPKa8etee1q8FpJGpIowu1OCjP1C2yHhtptg7TVlgFIiYLDjEQ0kbsHTALDU5r05Wt30=</Password>
  </Connection>
</Query>

var places = Places.GroupBy(row => row.County_id);
var  placesSorted = from place in places orderby place.Key
                                   select place;
placesSorted.Dump();
