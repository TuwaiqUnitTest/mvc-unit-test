const el = document.getElementById("citiesMap");


const queryString = window.location.search;

const urlParams = new URLSearchParams(queryString);

const countryId = urlParams.get("country")

var currentMap;

if (am4geodata_data_countries2[countryId] !== undefined) {
    currentMap = am4geodata_data_countries2[countryId]["maps"][0];
} else {
    currentMap = am4geodata_data_countries2["SA"]["maps"][0];
}


const polygonSeries = makeMap(el, {
    geoDataSourceUrl: "https://www.amcharts.com/lib/4/geodata/json/" + currentMap + ".json",
    projection: new am4maps.projections.Mercator(),
    tooltip: {
        html: "<b style='font-size: 26px;'>{name}</b> {details}",
        color: "#67b7dc"
    }});



const psd = polygonSeries.data;


const addCases = (region, index) => {

    if (psd[index]) {
        psd[index].new_confirmed = region.newConfirmed.toString();
        psd[index].total_confirmed = region.totalConfirmed.toString();
        psd[index].new_deaths = region.newDeaths.toString();
        psd[index].total_deaths = region.totalDeaths.toString();
        psd[index].new_recovered = region.newRecovered.toString();
        psd[index].total_recovered = region.totalRecovered.toString();

        psd[index].recovery_rate = Math.round(
            (region.totalRecovered / region.totalConfirmed) * 100
        ).toString();
        psd[index].death_rate = Math.round(
            (region.totalDeaths / region.totalConfirmed) * 100
        ).toString();

        psd[index].details = `
          <div style="margin-top: 10px;">
            <div>
              Total Confirmed:
              <span style="color:#FFEEAA; font-weight: bold;">
                ${region.totalConfirmed}
              </span>
            </div>
            <div>
              New Confirmed: 
              <span style="color:#FFEEAA; font-weight: bold;">
                ${region.newConfirmed}
              </span>
            </div>
            <div>
              Total Deaths:
              <span style="color:red; font-weight: bold;">
                ${region.totalDeaths}
              </span>
            </div>
            <div>
              New Deaths: 
              <span style="color:red; font-weight: bold;">
                ${region.newDeaths}
              </span>
            </div>
            <div>
              Total Recovered:
              <span style="color:#8ACA2B; font-weight: bold;">
                ${region.totalRecovered}
              </span>
            </div>
            <div>
              New Recovered: 
              <span style="color:#8ACA2B; font-weight: bold;">
                ${region.newRecovered}
              </span>
            </div>            
          </div>

          `;
    }
};

const asyncTimeout = amount => new Promise(res => setTimeout(res, amount));

async function getCases() {
    try {

        let res = await fetch("/api/region?country=" + countryId);
        let data = await res.json();

        if (data.length < 1) {
            await asyncTimeout(3000);
            return getCases();
        }

        data.forEach(addCases);

    } catch (e) {
        console.error(e);
        await asyncTimeout(3000);
        return getCases();
    }
}

polygonSeries.mapPolygons.template.events.on("ready", ev => {

    getCases()

});



