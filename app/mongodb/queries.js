db.unMes.updateMany({ grupo04: { $exists: false } }, { $set: { "grupo04": "N/A" } })
db.unMes.updateMany({ grupo05: { $exists: false } }, { $set: { "grupo05": "N/A" } })
db.unMes.updateMany({ grupo06: { $exists: false } }, { $set: { "grupo06": "N/A" } })
db.unMes.updateMany({ grupo07: { $exists: false } }, { $set: { "grupo07": "N/A" } })
db.unMes.updateMany({ grupo09: { $exists: false } }, { $set: { "grupo09": "N/A" } })
db.unMes.updateMany({ grupo10: { $exists: false } }, { $set: { "grupo10": "N/A" } })
db.unMes.updateMany({ grupo11: { $exists: false } }, { $set: { "grupo11": "N/A" } })

// Null or ""
db.unMes.updateMany({ grupo02: null }, { $set: { "grupo02": "N/A" } })
db.unMes.updateMany({ grupo04: null }, { $set: { "grupo04": "N/A" } })

db.unMes.updateMany({ grupo02: "" }, { $set: { "grupo02": "N/A" } })
db.unMes.updateMany({ grupo04: "" }, { $set: { "grupo04": "N/A" } })
db.unMes.updateMany({ grupo05: "" }, { $set: { "grupo05": "N/A" } })
db.unMes.updateMany({ grupo06: "" }, { $set: { "grupo06": "N/A" } })
db.unMes.updateMany({ grupo07: "" }, { $set: { "grupo07": "N/A" } })
db.unMes.updateMany({ grupo10: "" }, { $set: { "grupo10": "N/A" } })
db.unMes.updateMany({ grupo11: "" }, { $set: { "grupo11": "N/A" } })


db.newCubo2.aggregate([
{
    $match: { fecha: { $gte: ISODate("2016-01-01"), $lte: ISODate("2016-03-31") } }
},
{
    $out: "tresMeses"
}
])

db.newCubo2.aggregate([
{
    $match: { fecha: { $gte: ISODate("2016-01-01"), $lte: ISODate("2016-06-31") } }
},
{
        $out: "seisMeses"
}
])

db.newCubo2.aggregate([
{
    $match: { fecha: { $gte: ISODate("2016-01-01"), $lte: ISODate("2016-01-02") } }
},
{
    $out: "unDia"
}
])