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
using Aliyun.Acs.Sas.Model.V20181203;

namespace Aliyun.Acs.Sas.Transform.V20181203
{
    public class DescribeAssetDetailByUuidsResponseUnmarshaller
    {
        public static DescribeAssetDetailByUuidsResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeAssetDetailByUuidsResponse describeAssetDetailByUuidsResponse = new DescribeAssetDetailByUuidsResponse();

			describeAssetDetailByUuidsResponse.HttpResponse = context.HttpResponse;
			describeAssetDetailByUuidsResponse.RequestId = context.StringValue("DescribeAssetDetailByUuids.RequestId");

			List<DescribeAssetDetailByUuidsResponse.DescribeAssetDetailByUuids_Asset> describeAssetDetailByUuidsResponse_assetList = new List<DescribeAssetDetailByUuidsResponse.DescribeAssetDetailByUuids_Asset>();
			for (int i = 0; i < context.Length("DescribeAssetDetailByUuids.AssetList.Length"); i++) {
				DescribeAssetDetailByUuidsResponse.DescribeAssetDetailByUuids_Asset asset = new DescribeAssetDetailByUuidsResponse.DescribeAssetDetailByUuids_Asset();
				asset.InternetIp = context.StringValue("DescribeAssetDetailByUuids.AssetList["+ i +"].InternetIp");
				asset.IntranetIp = context.StringValue("DescribeAssetDetailByUuids.AssetList["+ i +"].IntranetIp");
				asset.InstanceName = context.IntegerValue("DescribeAssetDetailByUuids.AssetList["+ i +"].InstanceName");
				asset.InstanceId = context.IntegerValue("DescribeAssetDetailByUuids.AssetList["+ i +"].InstanceId");
				asset.Ip = context.StringValue("DescribeAssetDetailByUuids.AssetList["+ i +"].Ip");
				asset.Uuid = context.StringValue("DescribeAssetDetailByUuids.AssetList["+ i +"].Uuid");
				asset.AssetType = context.StringValue("DescribeAssetDetailByUuids.AssetList["+ i +"].AssetType");
				asset.Os = context.StringValue("DescribeAssetDetailByUuids.AssetList["+ i +"].Os");
				asset.ClientStatus = context.StringValue("DescribeAssetDetailByUuids.AssetList["+ i +"].ClientStatus");
				asset.Region = context.StringValue("DescribeAssetDetailByUuids.AssetList["+ i +"].Region");
				asset.RegionName = context.StringValue("DescribeAssetDetailByUuids.AssetList["+ i +"].RegionName");
				asset.VpcInstanceId = context.StringValue("DescribeAssetDetailByUuids.AssetList["+ i +"].VpcInstanceId");
				asset.OsName = context.StringValue("DescribeAssetDetailByUuids.AssetList["+ i +"].OsName");

				describeAssetDetailByUuidsResponse_assetList.Add(asset);
			}
			describeAssetDetailByUuidsResponse.AssetList = describeAssetDetailByUuidsResponse_assetList;
        
			return describeAssetDetailByUuidsResponse;
        }
    }
}
