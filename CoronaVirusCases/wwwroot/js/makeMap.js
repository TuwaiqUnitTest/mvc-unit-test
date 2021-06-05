am4core.useTheme(am4themes_animated);

function makeMap(DOM, opts) {

    if (!opts) opts = { }

    const map = am4core.create(DOM, am4maps.MapChart);

    if (opts.maxZoomLevel) {
        map.maxZoomLevel = opts.maxZoomLevel;
    }

    if (opts.geoDataSourceUrl) {
        map.geodataSource.url = opts.geoDataSourceUrl;
    }

    if (opts.geodata) {
        map.geodata = opts.geodata;
    }

    if (opts.projection) {
        map.projection = opts.projection;
    } else {
        map.projection = new am4maps.projections.Miller()
    }

    map.seriesContainer.draggable = false;
    map.chartContainer.wheelable = false;


    const polygonSeries = new am4maps.MapPolygonSeries();
    polygonSeries.useGeodata = true;
    map.series.push(polygonSeries);

    const polygonTemplate = polygonSeries.mapPolygons.template;
    polygonTemplate.fill = am4core.color("#E5E5E5");

    const hs = polygonTemplate.states.create("hover");
    hs.properties.fill = am4core.color("#fca311");

    if (opts.tooltip) {
        polygonTemplate.tooltipHTML = opts.tooltip.html
        polygonSeries.tooltip.getFillFromObject = false;
        polygonSeries.tooltip.background.fill = am4core.color(opts.tooltip.color);
    }

    polygonSeries.exclude = [
        "AQ",
        "PW",
        "VU",
        "FM",
        "NR",
        "MH",
        "TV",
        "CX",
        "HM",
        "GO",
        "JU",
        "NU",
        "TK",
        "KI",
        "PF",
        "PN",
        "CK",
        "TO",
        "SJ",
        "WF",
        "BV",
        "GS",
        "TF",
        "MU",
        "YT",
        "MP",
        "NC",
        "RE",
        "UM-DQ",
        "UM-FQ",
        "UM-HQ",
        "UM-JQ",
        "UM-MQ",
        "UM-WQ"
    ];

    return polygonSeries
}