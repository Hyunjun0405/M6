﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;
using M6.Data.Models;
using M6.Web.Models;
using Microsoft.AspNet.OData.Builder;
using Microsoft.AspNet.OData.Extensions;

namespace M6.Web
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            // Web API configuration and services

            // Web API routes
            config.MapHttpAttributeRoutes();

            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );

            ODataModelBuilder builder = new ODataConventionModelBuilder();
            builder.EntitySet<M6.Web.Models.Product>("Products");
            builder.EntitySet<CODE>("코드");
            config.MapODataServiceRoute(
                routeName: "OData",
                routePrefix: "odata",
                model: builder.GetEdmModel());
        }
    }
}
