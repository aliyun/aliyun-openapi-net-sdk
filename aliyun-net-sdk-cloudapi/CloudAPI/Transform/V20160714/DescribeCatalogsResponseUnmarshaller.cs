/*
 * Licensed to the Apache Software Foundation (ASF) under one
 * or more contributor license agreements.  See the NOTICE file
 * distributed with this work for additional information
 * regarding copyright ownership.  The ASF licenses this file
 * to you under the Apache License, Version 2.0 (the
 * "License"); you may not use this file except in compliance
 * with the License.  You may obtain a copy of the License at
 *
 *     http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing,
 * software distributed under the License is distributed on an
 * "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY
 * KIND, either express or implied.  See the License for the
 * specific language governing permissions and limitations
 * under the License.
 */
using Aliyun.Acs.Core.Transform;
using Aliyun.Acs.CloudAPI.Model.V20160714;
using System;
using System.Collections.Generic;

namespace Aliyun.Acs.CloudAPI.Transform.V20160714
{
    public class DescribeCatalogsResponseUnmarshaller
    {
        public static DescribeCatalogsResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeCatalogsResponse describeCatalogsResponse = new DescribeCatalogsResponse();

			describeCatalogsResponse.HttpResponse = context.HttpResponse;
			describeCatalogsResponse.RequestId = context.StringValue("DescribeCatalogs.RequestId");
			describeCatalogsResponse.TotalCount = context.IntegerValue("DescribeCatalogs.TotalCount");
			describeCatalogsResponse.PageSize = context.IntegerValue("DescribeCatalogs.PageSize");
			describeCatalogsResponse.PageNumber = context.IntegerValue("DescribeCatalogs.PageNumber");

			List<DescribeCatalogsResponse.CatalogAttribute> catalogAttributes = new List<DescribeCatalogsResponse.CatalogAttribute>();
			for (int i = 0; i < context.Length("DescribeCatalogs.CatalogAttributes.Length"); i++) {
				DescribeCatalogsResponse.CatalogAttribute catalogAttribute = new DescribeCatalogsResponse.CatalogAttribute();
				catalogAttribute.CatalogId = context.StringValue("DescribeCatalogs.CatalogAttributes["+ i +"].CatalogId");
				catalogAttribute.CatalogName = context.StringValue("DescribeCatalogs.CatalogAttributes["+ i +"].CatalogName");
				catalogAttribute.Description = context.StringValue("DescribeCatalogs.CatalogAttributes["+ i +"].Description");
				catalogAttribute.ParentId = context.StringValue("DescribeCatalogs.CatalogAttributes["+ i +"].ParentId");
				catalogAttribute.CreatedTime = context.StringValue("DescribeCatalogs.CatalogAttributes["+ i +"].CreatedTime");
				catalogAttribute.ModifiedTime = context.StringValue("DescribeCatalogs.CatalogAttributes["+ i +"].ModifiedTime");
				catalogAttribute.RegionId = context.StringValue("DescribeCatalogs.CatalogAttributes["+ i +"].RegionId");

				catalogAttributes.Add(catalogAttribute);
			}
			describeCatalogsResponse.CatalogAttributes = catalogAttributes;
        
			return describeCatalogsResponse;
        }
    }
}