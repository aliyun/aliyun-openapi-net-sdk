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
using Aliyun.Acs.Smartag.Model.V20180313;

namespace Aliyun.Acs.Smartag.Transform.V20180313
{
    public class DescribeCloudConnectNetworksResponseUnmarshaller
    {
        public static DescribeCloudConnectNetworksResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeCloudConnectNetworksResponse describeCloudConnectNetworksResponse = new DescribeCloudConnectNetworksResponse();

			describeCloudConnectNetworksResponse.HttpResponse = context.HttpResponse;
			describeCloudConnectNetworksResponse.RequestId = context.StringValue("DescribeCloudConnectNetworks.RequestId");
			describeCloudConnectNetworksResponse.TotalCount = context.IntegerValue("DescribeCloudConnectNetworks.TotalCount");
			describeCloudConnectNetworksResponse.PageNumber = context.IntegerValue("DescribeCloudConnectNetworks.PageNumber");
			describeCloudConnectNetworksResponse.PageSize = context.IntegerValue("DescribeCloudConnectNetworks.PageSize");

			List<DescribeCloudConnectNetworksResponse.DescribeCloudConnectNetworks_CloudConnectNetwork> describeCloudConnectNetworksResponse_cloudConnectNetworks = new List<DescribeCloudConnectNetworksResponse.DescribeCloudConnectNetworks_CloudConnectNetwork>();
			for (int i = 0; i < context.Length("DescribeCloudConnectNetworks.CloudConnectNetworks.Length"); i++) {
				DescribeCloudConnectNetworksResponse.DescribeCloudConnectNetworks_CloudConnectNetwork cloudConnectNetwork = new DescribeCloudConnectNetworksResponse.DescribeCloudConnectNetworks_CloudConnectNetwork();
				cloudConnectNetwork.CcnId = context.StringValue("DescribeCloudConnectNetworks.CloudConnectNetworks["+ i +"].CcnId");
				cloudConnectNetwork.Name = context.StringValue("DescribeCloudConnectNetworks.CloudConnectNetworks["+ i +"].Name");
				cloudConnectNetwork.AssociatedCloudBoxCount = context.StringValue("DescribeCloudConnectNetworks.CloudConnectNetworks["+ i +"].AssociatedCloudBoxCount");
				cloudConnectNetwork.AvailableCloudBoxCount = context.StringValue("DescribeCloudConnectNetworks.CloudConnectNetworks["+ i +"].AvailableCloudBoxCount");
				cloudConnectNetwork.AssociatedCenId = context.StringValue("DescribeCloudConnectNetworks.CloudConnectNetworks["+ i +"].AssociatedCenId");
				cloudConnectNetwork.AssociatedCenOwnerId = context.StringValue("DescribeCloudConnectNetworks.CloudConnectNetworks["+ i +"].AssociatedCenOwnerId");
				cloudConnectNetwork.Description = context.StringValue("DescribeCloudConnectNetworks.CloudConnectNetworks["+ i +"].Description");
				cloudConnectNetwork.CreateTime = context.LongValue("DescribeCloudConnectNetworks.CloudConnectNetworks["+ i +"].CreateTime");
				cloudConnectNetwork.IsDefault = context.BooleanValue("DescribeCloudConnectNetworks.CloudConnectNetworks["+ i +"].IsDefault");
				cloudConnectNetwork.CidrBlock = context.StringValue("DescribeCloudConnectNetworks.CloudConnectNetworks["+ i +"].CidrBlock");
				cloudConnectNetwork.SnatCidrBlock = context.StringValue("DescribeCloudConnectNetworks.CloudConnectNetworks["+ i +"].SnatCidrBlock");
				cloudConnectNetwork.InterworkingStatus = context.StringValue("DescribeCloudConnectNetworks.CloudConnectNetworks["+ i +"].InterworkingStatus");

				List<DescribeCloudConnectNetworksResponse.DescribeCloudConnectNetworks_CloudConnectNetwork.DescribeCloudConnectNetworks_Tag> cloudConnectNetwork_tags = new List<DescribeCloudConnectNetworksResponse.DescribeCloudConnectNetworks_CloudConnectNetwork.DescribeCloudConnectNetworks_Tag>();
				for (int j = 0; j < context.Length("DescribeCloudConnectNetworks.CloudConnectNetworks["+ i +"].Tags.Length"); j++) {
					DescribeCloudConnectNetworksResponse.DescribeCloudConnectNetworks_CloudConnectNetwork.DescribeCloudConnectNetworks_Tag tag = new DescribeCloudConnectNetworksResponse.DescribeCloudConnectNetworks_CloudConnectNetwork.DescribeCloudConnectNetworks_Tag();
					tag.Key = context.StringValue("DescribeCloudConnectNetworks.CloudConnectNetworks["+ i +"].Tags["+ j +"].Key");
					tag._Value = context.StringValue("DescribeCloudConnectNetworks.CloudConnectNetworks["+ i +"].Tags["+ j +"].Value");

					cloudConnectNetwork_tags.Add(tag);
				}
				cloudConnectNetwork.Tags = cloudConnectNetwork_tags;

				describeCloudConnectNetworksResponse_cloudConnectNetworks.Add(cloudConnectNetwork);
			}
			describeCloudConnectNetworksResponse.CloudConnectNetworks = describeCloudConnectNetworksResponse_cloudConnectNetworks;
        
			return describeCloudConnectNetworksResponse;
        }
    }
}
