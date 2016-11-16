// Base de datos a utilizar

['unDia', 'unMes', 'tresMeses', 'seisMeses', 'unAyo'];

db.unMes.updateMany({ grupo01: { $exists: false } }, { $set: { "grupo01": "N/A" } })
db.unMes.updateMany({ grupo02: { $exists: false } }, { $set: { "grupo02": "N/A" } })
db.unMes.updateMany({ grupo03: { $exists: false } }, { $set: { "grupo03": "N/A" } })
db.unMes.updateMany({ grupo04: { $exists: false } }, { $set: { "grupo04": "N/A" } })
db.unMes.updateMany({ grupo05: { $exists: false } }, { $set: { "grupo05": "N/A" } })
db.unMes.updateMany({ grupo06: { $exists: false } }, { $set: { "grupo06": "N/A" } })
db.unMes.updateMany({ grupo07: { $exists: false } }, { $set: { "grupo07": "N/A" } })
db.unMes.updateMany({ grupo08: { $exists: false } }, { $set: { "grupo08": "N/A" } })
db.unMes.updateMany({ grupo09: { $exists: false } }, { $set: { "grupo09": "N/A" } })
db.unMes.updateMany({ grupo10: { $exists: false } }, { $set: { "grupo10": "N/A" } })
db.unMes.updateMany({ grupo11: { $exists: false } }, { $set: { "grupo11": "N/A" } })

// Null or ""
db.unMes.updateMany({ grupo01: null }, { $set: { "grupo01": "N/A" } })
db.unMes.updateMany({ grupo02: null }, { $set: { "grupo02": "N/A" } })
db.unMes.updateMany({ grupo03: null }, { $set: { "grupo03": "N/A" } })
db.unMes.updateMany({ grupo04: null }, { $set: { "grupo04": "N/A" } })
db.unMes.updateMany({ grupo05: null }, { $set: { "grupo05": "N/A" } })
db.unMes.updateMany({ grupo06: null }, { $set: { "grupo06": "N/A" } })
db.unMes.updateMany({ grupo07: null }, { $set: { "grupo07": "N/A" } })
db.unMes.updateMany({ grupo08: null }, { $set: { "grupo08": "N/A" } })
db.unMes.updateMany({ grupo09: null }, { $set: { "grupo09": "N/A" } })
db.unMes.updateMany({ grupo10: null }, { $set: { "grupo10": "N/A" } })
db.unMes.updateMany({ grupo11: null }, { $set: { "grupo11": "N/A" } })

db.unMes.updateMany({ grupo01: "" }, { $set: { "grupo01": "N/A" } })
db.unMes.updateMany({ grupo02: "" }, { $set: { "grupo02": "N/A" } })
db.unMes.updateMany({ grupo03: "" }, { $set: { "grupo03": "N/A" } })
db.unMes.updateMany({ grupo04: "" }, { $set: { "grupo04": "N/A" } })
db.unMes.updateMany({ grupo05: "" }, { $set: { "grupo05": "N/A" } })
db.unMes.updateMany({ grupo06: "" }, { $set: { "grupo06": "N/A" } })
db.unMes.updateMany({ grupo07: "" }, { $set: { "grupo07": "N/A" } })
db.unMes.updateMany({ grupo08: "" }, { $set: { "grupo08": "N/A" } })
db.unMes.updateMany({ grupo09: "" }, { $set: { "grupo09": "N/A" } })
db.unMes.updateMany({ grupo10: "" }, { $set: { "grupo10": "N/A" } })
db.unMes.updateMany({ grupo11: "" }, { $set: { "grupo11": "N/A" } })

db.unMes.updateMany({ grupo01: "null" }, { $set: { "grupo01": "N/A" } })
db.unMes.updateMany({ grupo02: "null" }, { $set: { "grupo02": "N/A" } })
db.unMes.updateMany({ grupo03: "null" }, { $set: { "grupo03": "N/A" } })
db.unMes.updateMany({ grupo04: "null" }, { $set: { "grupo04": "N/A" } })
db.unMes.updateMany({ grupo05: "null" }, { $set: { "grupo05": "N/A" } })
db.unMes.updateMany({ grupo06: "null" }, { $set: { "grupo06": "N/A" } })
db.unMes.updateMany({ grupo07: "null" }, { $set: { "grupo07": "N/A" } })
db.unMes.updateMany({ grupo08: "null" }, { $set: { "grupo08": "N/A" } })
db.unMes.updateMany({ grupo09: "null" }, { $set: { "grupo09": "N/A" } })
db.unMes.updateMany({ grupo10: "null" }, { $set: { "grupo10": "N/A" } })
db.unMes.updateMany({ grupo11: "null" }, { $set: { "grupo11": "N/A" } })

db.unDia.createIndex({ fecha: -1 })
db.unDia.createIndex({ fecha: 1 })
db.unMes.createIndex({ fecha: -1 })
db.unMes.createIndex({ fecha: 1 })
db.seisMeses.createIndex({ fecha: -1 })
db.seisMeses.createIndex({ fecha: 1 })
db.tresMeses.createIndex({ fecha: -1 })
db.tresMeses.createIndex({ fecha: 1 })
db.newCubo2.createIndex({ fecha: -1 })
db.newCubo2.createIndex({ fecha: 1 })

db.unMes.updateMany({}, { $rename:
    {
        'grupo01': 'g01',
        'grupo02': 'g02',
        'grupo03': 'g03',
        'grupo04': 'g04',
        'grupo05': 'g05',
        'grupo06': 'g06',
        'grupo07': 'g07',
        'grupo08': 'g08',
        'grupo09': 'g09',
        'grupo10': 'g10',
        'grupo11': 'g11'
    }    
})

// Change the fields name

// unDia
db.newCubo2.aggregate([
{
    $match: { fecha: { $gte: ISODate("2016-01-01"), $lte: ISODate("2016-01-02") } }
},
{
    $out: "unDia"
}
])

// unMes
db.newCubo2.aggregate([
{
    $match: { fecha: { $gte: ISODate("2016-01-01"), $lte: ISODate("2016-01-31") } }
},
{
    $out: "unMes"
}
])

//tresMeses
db.newCubo2.aggregate([
{
    $match: { fecha: { $gte: ISODate("2016-01-01"), $lte: ISODate("2016-03-31") } }
},
{
    $out: "tresMeses"
}
])

// seisMeses
db.newCubo2.aggregate([
{
    $match: { fecha: { $gte: ISODate("2016-01-01"), $lte: ISODate("2016-06-31") } }
},
{
    $out: "seisMeses"
}
])

// unAyo - 2015
db.newCubo2.aggregate([
{
    $match: { fecha: { $gte: ISODate("2015-01-01"), $lte: ISODate("2015-12-31") } }
},
{
    $out: "unAyo"
}
])
