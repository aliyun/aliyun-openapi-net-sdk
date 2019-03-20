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
using Aliyun.Acs.Cms.Model.V20180308;

namespace Aliyun.Acs.Cms.Transform.V20180308
{
    public class ListMyGroupInstancesDetailsResponseUnmarshaller
    {
        public static ListMyGroupInstancesDetailsResponse Unmarshall(UnmarshallerContext context)
        {
			ListMyGroupInstancesDetailsResponse listMyGroupInstancesDetailsResponse = new ListMyGroupInstancesDetailsResponse();

			listMyGroupInstancesDetailsResponse.HttpResponse = context.HttpResponse;
			listMyGroupInstancesDetailsResponse.RequestId = context.StringValue("ListMyGroupInstancesDetails.RequestId");
			listMyGroupInstancesDetailsResponse.Success = context.BooleanValue("ListMyGroupInstancesDetails.Success");
			listMyGroupInstancesDetailsResponse.ErrorCode = context.IntegerValue("ListMyGroupInstancesDetails.ErrorCode");
			listMyGroupInstancesDetailsResponse.ErrorMessage = context.StringValue("ListMyGroupInstancesDetails.ErrorMessage");
			listMyGroupInstancesDetailsResponse.PageNumber = context.IntegerValue("ListMyGroupInstancesDetails.PageNumber");
			listMyGroupInstancesDetailsResponse.PageSize = context.IntegerValue("ListMyGroupInstancesDetails.PageSize");
			listMyGroupInstancesDetailsResponse.Total = context.IntegerValue("ListMyGroupInstancesDetails.Total");

			List<ListMyGroupInstancesDetailsResponse.ListMyGroupInstancesDetails_Resource> listMyGroupInstancesDetailsResponse_resources = new List<ListMyGroupInstancesDetailsResponse.ListMyGroupInstancesDetails_Resource>();
			for (int i = 0; i < context.Length("ListMyGroupInstancesDetails.Resources.Length"); i++) {
				ListMyGroupInstancesDetailsResponse.ListMyGroupInstancesDetails_Resource resource = new ListMyGroupInstancesDetailsResponse.ListMyGroupInstancesDetails_Resource();
				resource.AliUid = context.LongValue("ListMyGroupInstancesDetails.Resources["+ i +"].AliUid");
				resource.InstanceName = context.StringValue("ListMyGroupInstancesDetails.Resources["+ i +"].InstanceName");
				resource.InstanceId = context.StringValue("ListMyGroupInstancesDetails.Resources["+ i +"].InstanceId");
				resource.Desc = context.StringValue("ListMyGroupInstancesDetails.Resources["+ i +"].Desc");
				resource.NetworkType = context.StringValue("ListMyGroupInstancesDetails.Resources["+ i +"].NetworkType");
				resource.Category = context.StringValue("ListMyGroupInstancesDetails.Resources["+ i +"].Category");
				resource.Dimension = context.StringValue("ListMyGroupInstancesDetails.Resources["+ i +"].Dimension");

				ListMyGroupInstancesDetailsResponse.ListMyGroupInstancesDetails_Resource.ListMyGroupInstancesDetails_Region region = new ListMyGroupInstancesDetailsResponse.ListMyGroupInstancesDetails_Resource.ListMyGroupInstancesDetails_Region();
				region.RegionId = context.StringValue("ListMyGroupInstancesDetails.Resources["+ i +"].Region.RegionId");
				region.AvailabilityZone = context.StringValue("ListMyGroupInstancesDetails.Resources["+ i +"].Region.AvailabilityZone");
				resource.Region = region;

				ListMyGroupInstancesDetailsResponse.ListMyGroupInstancesDetails_Resource.ListMyGroupInstancesDetails_Vpc vpc = new ListMyGroupInstancesDetailsResponse.ListMyGroupInstancesDetails_Resource.ListMyGroupInstancesDetails_Vpc();
				vpc.VpcInstanceId = context.StringValue("ListMyGroupInstancesDetails.Resources["+ i +"].Vpc.VpcInstanceId");
				vpc.VswitchInstanceId = context.StringValue("ListMyGroupInstancesDetails.Resources["+ i +"].Vpc.VswitchInstanceId");
				resource.Vpc = vpc;

				List<ListMyGroupInstancesDetailsResponse.ListMyGroupInstancesDetails_Resource.ListMyGroupInstancesDetails_Tag> resource_tags = new List<ListMyGroupInstancesDetailsResponse.ListMyGroupInstancesDetails_Resource.ListMyGroupInstancesDetails_Tag>();
				for (int j = 0; j < context.Length("ListMyGroupInstancesDetails.Resources["+ i +"].Tags.Length"); j++) {
					ListMyGroupInstancesDetailsResponse.ListMyGroupInstancesDetails_Resource.ListMyGroupInstancesDetails_Tag tag = new ListMyGroupInstancesDetailsResponse.ListMyGroupInstancesDetails_Resource.ListMyGroupInstancesDetails_Tag();
					tag.Key = context.StringValue("ListMyGroupInstancesDetails.Resources["+ i +"].Tags["+ j +"].Key");
					tag._Value = context.StringValue("ListMyGroupInstancesDetails.Resources["+ i +"].Tags["+ j +"].Value");

					resource_tags.Add(tag);
				}
				resource.Tags = resource_tags;

				listMyGroupInstancesDetailsResponse_resources.Add(resource);
			}
			listMyGroupInstancesDetailsResponse.Resources = listMyGroupInstancesDetailsResponse_resources;
        
			return listMyGroupInstancesDetailsResponse;
        }
    }
}
