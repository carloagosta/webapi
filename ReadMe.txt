
- Il progetto consiste in una soluzione Visual Studio 2017 contenente una Asp.NET Core Web Api

- La soluzione può essere aperta tramite il file .sln presente all'interno della cartella WebApplication1

- Il progetto può essere testato in debug avviandolo direttamente tramite Visual Studio oppure pubblicato 
  e installato come applicazione web all interno di un web server (x es. IIS)

- Il metodo oggetto dell'esercizio è disponibile (x es. in debug) all'indirizzo:
  https://localhost:44354/api/prices/getoilpricetrend

- Il metodo prevede il passaggio di due parametri, "startDateISO8601" ed "endDateISO8601", entrambi
  in formato yyyy-MM-dd

- Per effettuare una chiamata di test è possibile utilizzare uno specifico sw (x es. SoapUI),
  oppure un browser web, passando i parametri direttamente all'interno dell'url, come l'esempio che segue:
  https://localhost:44354/api/prices/getoilpricetrend?startDateISO8601=2020-01-01&endDateISO8601=2021-02-01
