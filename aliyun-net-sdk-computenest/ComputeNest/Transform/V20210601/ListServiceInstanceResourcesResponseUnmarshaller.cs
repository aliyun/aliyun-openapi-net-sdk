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
using System;
using System.Collections.Generic;

using Aliyun.Acs.Core.Transform;
using Aliyun.Acs.ComputeNest.Model.V20210601;

namespace Aliyun.Acs.ComputeNest.Transform.V20210601
{
    public class ListServiceInstanceResourcesResponseUnmarshaller
    {
        public static ListServiceInstanceResourcesResponse Unmarshall(UnmarshallerContext _ctx)
        {
			ListServiceInstanceResourcesResponse listServiceInstanceResourcesResponse = new ListServiceInstanceResourcesResponse();

			listServiceInstanceResourcesResponse.HttpResponse = _ctx.HttpResponse;
			listServiceInstanceResourcesResponse.NextToken = _ctx.StringValue("ListServiceInstanceResources.NextToken");
			listServiceInstanceResourcesResponse.RequestId = _ctx.StringValue("ListServiceInstanceResources.RequestId");
			listServiceInstanceResourcesResponse.MaxResults = _ctx.IntegerValue("ListServiceInstanceResources.MaxResults");

			List<ListServiceInstanceResourcesResponse.ListServiceInstanceResources_ResourcesItem> listServiceInstanceResourcesResponse_resources = new List<ListServiceInstanceResourcesResponse.ListServiceInstanceResources_ResourcesItem>();
			for (int i = 0; i < _ctx.Length("ListServiceInstanceResources.Resources.Length"); i++) {
				ListServiceInstanceResourcesResponse.ListServiceInstanceResources_ResourcesItem resourcesItem = new ListServiceInstanceResourcesResponse.ListServiceInstanceResources_ResourcesItem();
				resourcesItem.ResourceARN = _ctx.StringValue("ListServiceInstanceResources.Resources["+ i +"].ResourceARN");
				resourcesItem.PayType = _ctx.StringValue("ListServiceInstanceResources.Resources["+ i +"].PayType");
				resourcesItem.RenewStatus = _ctx.StringValue("ListServiceInstanceResources.Resources["+ i +"].RenewStatus");
				resourcesItem.CreateTime = _ctx.StringValue("ListServiceInstanceResources.Resources["+ i +"].CreateTime");
				resourcesItem.ExpireTime = _ctx.StringValue("ListServiceInstanceResources.Resources["+ i +"].ExpireTime");
				resourcesItem.RenewalPeriod = _ctx.IntegerValue("ListServiceInstanceResources.Resources["+ i +"].RenewalPeriod");
				resourcesItem.RenewalPeriodUnit = _ctx.StringValue("ListServiceInstanceResources.Resources["+ i +"].RenewalPeriodUnit");
				resourcesItem.ProductType = _ctx.StringValue("ListServiceInstanceResources.Resources["+ i +"].ProductType");
				resourcesItem.ProductCode = _ctx.StringValue("ListServiceInstanceResources.Resources["+ i +"].ProductCode");
				resourcesItem.Status = _ctx.StringValue("ListServiceInstanceResources.Resources["+ i +"].Status");

				listServiceInstanceResourcesResponse_resources.Add(resourcesItem);
			}
			listServiceInstanceResourcesResponse.Resources = listServiceInstanceResourcesResponse_resources;
        
			return listServiceInstanceResourcesResponse;
        }
    }
}
