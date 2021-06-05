// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.

const el = document.getElementById("countriesMap");

const polygonSeries = makeMap(el, {
    maxZoomLevel: 1,
    geodata: am4geodata_worldLow,
    tooltip: {
        html: "<b style='font-size: 26px;'>{name}</b> {details}",
        color: "#67b7dc"
    }
});

const psd = polygonSeries.data;

polygonSeries.mapPolygons.template.events.on("hit", ev => {
    const country = psd.find(
        ele => ele.id === ev.target.dataItem.dataContext.id
    );

    if (country.id === "SA") {
        window.location.href = '../regions?country=' + country.id;
    }
});

const addCases = country => {
    const index = psd.findIndex(ele => ele.id === country.countryCode);

    if (psd[index]) {
        psd[index].new_confirmed = country.newConfirmed.toString();
        psd[index].total_confirmed = country.totalConfirmed.toString();
        psd[index].new_deaths = country.newDeaths.toString();
        psd[index].total_deaths = country.totalDeaths.toString();
        psd[index].new_recovered = country.newRecovered.toString();
        psd[index].total_recovered = country.totalRecovered.toString();

        psd[index].recovery_rate = Math.round(
            (country.totalRecovered / country.totalConfirmed) * 100
        ).toString();
        psd[index].death_rate = Math.round(
            (country.totalDeaths / country.totalConfirmed) * 100
        ).toString();

        psd[index].details = `
          <div style="margin-top: 10px;">
            <div>
              Total Confirmed:
              <span style="color:#FFEEAA; font-weight: bold;">
                ${country.totalConfirmed}
              </span>
            </div>
            <div>
              New Confirmed: 
              <span style="color:#FFEEAA; font-weight: bold;">
                ${country.newConfirmed}
              </span>
            </div>
            <div>
              Total Deaths:
              <span style="color:red; font-weight: bold;">
                ${country.totalDeaths}
              </span>
            </div>
            <div>
              New Deaths: 
              <span style="color:red; font-weight: bold;">
                ${country.newDeaths}
              </span>
            </div>
            <div>
              Total Recovered:
              <span style="color:#8ACA2B; font-weight: bold;">
                ${country.totalRecovered}
              </span>
            </div>
            <div>
              New Recovered: 
              <span style="color:#8ACA2B; font-weight: bold;">
                ${country.newRecovered}
              </span>
            </div>            
          </div>

          `;
    }
};

const asyncTimeout = amount => new Promise(res => setTimeout(res, amount));

async function getCases() {
    try {

        let res = await fetch("/api/countries/");
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

getCases()

