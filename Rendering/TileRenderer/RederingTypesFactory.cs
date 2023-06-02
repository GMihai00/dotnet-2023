using Mapster.Common.MemoryMappedTypes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mapster.Rendering
{
    internal static class RederingTypesFactory
    {
        public static BaseShape? Build(this MapFeatureData feature, ref PriorityQueue<BaseShape, int> shapes)
        {
            BaseShape? baseShape = null;

            var featureType = feature.Type;
            if (feature.Properties.Any(p => p.Key == MapFeatureDataTypes.Highway && MapFeature.HighwayTypes.Any(v => p.Value.Any(value => value == v))))
            {
                var coordinates = feature.Coordinates;
                var road = new Road(coordinates);
                baseShape = road;
                shapes.Enqueue(road, road.ZIndex);
            }
            else if (feature.Properties.Any(p => p.Key == MapFeatureDataTypes.Water) && feature.Type != GeometryType.Point)
            {
                var coordinates = feature.Coordinates;

                var waterway = new Waterway(coordinates, feature.Type == GeometryType.Polygon);
                baseShape = waterway;
                shapes.Enqueue(waterway, waterway.ZIndex);
            }
            else if (Border.ShouldBeBorder(feature))
            {
                var coordinates = feature.Coordinates;
                var border = new Border(coordinates);
                baseShape = border;
                shapes.Enqueue(border, border.ZIndex);
            }
            else if (PopulatedPlace.ShouldBePopulatedPlace(feature))
            {
                var coordinates = feature.Coordinates;
                var popPlace = new PopulatedPlace(coordinates, feature);
                baseShape = popPlace;
                shapes.Enqueue(popPlace, popPlace.ZIndex);
            }
            else if (feature.Properties.Any(p => p.Key == MapFeatureDataTypes.Railway))
            {
                var coordinates = feature.Coordinates;
                var railway = new Railway(coordinates);
                baseShape = railway;
                shapes.Enqueue(railway, railway.ZIndex);
            }
            else if (feature.Properties.Any(p => p.Key == MapFeatureDataTypes.Natural && featureType == GeometryType.Polygon))
            {
                var coordinates = feature.Coordinates;
                var geoFeature = new GeoFeature(coordinates, feature);
                baseShape = geoFeature;
                shapes.Enqueue(geoFeature, geoFeature.ZIndex);
            }
            else if (feature.Properties.Any(p => p.Key == MapFeatureDataTypes.Boundary && p.Value.Any(value => value == MapFeatureDataTypes.Forest)))
            {
                var coordinates = feature.Coordinates;
                var geoFeature = new GeoFeature(coordinates, GeoFeature.GeoFeatureType.Forest);
                baseShape = geoFeature;
                shapes.Enqueue(geoFeature, geoFeature.ZIndex);
            }
            else if (feature.Properties.Any(p => p.Key == MapFeatureDataTypes.Landuse && MapFeature.ForestTypes.Any(v => p.Value.Any(value => value == v))))
            {
                var coordinates = feature.Coordinates;
                var geoFeature = new GeoFeature(coordinates, GeoFeature.GeoFeatureType.Forest);
                baseShape = geoFeature;
                shapes.Enqueue(geoFeature, geoFeature.ZIndex);
            }
            else if (feature.Type == GeometryType.Polygon && feature.Properties.Any(p
                         => p.Key == MapFeatureDataTypes.Landuse && MapFeature.ResidentialLanduseTypes.Any(v => p.Value.Any(value => value == v))))
            {
                var coordinates = feature.Coordinates;
                var geoFeature = new GeoFeature(coordinates, GeoFeature.GeoFeatureType.Residential);
                baseShape = geoFeature;
                shapes.Enqueue(geoFeature, geoFeature.ZIndex);
            }
            else if (feature.Type == GeometryType.Polygon && feature.Properties.Any(p
                         => p.Key == MapFeatureDataTypes.Landuse && MapFeature.PlainLanduseTypes.Any(v => p.Value.Any(value => value == v))))
            {
                var coordinates = feature.Coordinates;
                var geoFeature = new GeoFeature(coordinates, GeoFeature.GeoFeatureType.Plain);
                baseShape = geoFeature;
                shapes.Enqueue(geoFeature, geoFeature.ZIndex);
            }
            else if (feature.Type == GeometryType.Polygon &&
                     feature.Properties.Any(p => p.Key == MapFeatureDataTypes.Landuse && MapFeature.WaterLanduseTypes.Any(v => p.Value.Any(value => value == v))))
            {
                var coordinates = feature.Coordinates;
                var geoFeature = new GeoFeature(coordinates, GeoFeature.GeoFeatureType.Water);
                baseShape = geoFeature;
                shapes.Enqueue(geoFeature, geoFeature.ZIndex);
            }
            else if (feature.Type == GeometryType.Polygon && feature.Properties.Any(p => p.Key == MapFeatureDataTypes.Building))
            {
                var coordinates = feature.Coordinates;
                var geoFeature = new GeoFeature(coordinates, GeoFeature.GeoFeatureType.Residential);
                baseShape = geoFeature;
                shapes.Enqueue(geoFeature, geoFeature.ZIndex);
            }
            else if (feature.Type == GeometryType.Polygon && feature.Properties.Any(p => p.Key == MapFeatureDataTypes.Leisure))
            {
                var coordinates = feature.Coordinates;
                var geoFeature = new GeoFeature(coordinates, GeoFeature.GeoFeatureType.Residential);
                baseShape = geoFeature;
                shapes.Enqueue(geoFeature, geoFeature.ZIndex);
            }
            else if (feature.Type == GeometryType.Polygon && feature.Properties.Any(p => p.Key == MapFeatureDataTypes.Amenity))
            {
                var coordinates = feature.Coordinates;
                var geoFeature = new GeoFeature(coordinates, GeoFeature.GeoFeatureType.Residential);
                baseShape = geoFeature;
                shapes.Enqueue(geoFeature, geoFeature.ZIndex);
            }

            return baseShape;
        }
    }
}
