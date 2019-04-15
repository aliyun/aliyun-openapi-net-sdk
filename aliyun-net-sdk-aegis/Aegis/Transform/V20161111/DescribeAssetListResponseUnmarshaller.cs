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
using Aliyun.Acs.aegis.Model.V20161111;

namespace Aliyun.Acs.aegis.Transform.V20161111
{
    public class DescribeAssetListResponseUnmarshaller
    {
        public static DescribeAssetListResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeAssetListResponse describeAssetListResponse = new DescribeAssetListResponse();

			describeAssetListResponse.HttpResponse = context.HttpResponse;
			describeAssetListResponse.RequestId = context.StringValue("DescribeAssetList.RequestId");
			describeAssetListResponse.PageSize = context.IntegerValue("DescribeAssetList.PageSize");
			describeAssetListResponse.CurrentPage = context.IntegerValue("DescribeAssetList.CurrentPage");
			describeAssetListResponse.TotalCount = context.IntegerValue("DescribeAssetList.TotalCount");

			List<DescribeAssetListResponse.DescribeAssetList_Asset> describeAssetListResponse_assetList = new List<DescribeAssetListResponse.DescribeAssetList_Asset>();
			for (int i = 0; i < context.Length("DescribeAssetList.AssetList.Length"); i++) {
				DescribeAssetListResponse.DescribeAssetList_Asset asset = new DescribeAssetListResponse.DescribeAssetList_Asset();
				asset.InternetIp = context.StringValue("DescribeAssetList.AssetList["+ i +"].InternetIp");
				asset.IntranetIp = context.StringValue("DescribeAssetList.AssetList["+ i +"].IntranetIp");
				asset.InstanceName = context.StringValue("DescribeAssetList.AssetList["+ i +"].InstanceName");
				asset.Ip = context.StringValue("DescribeAssetList.AssetList["+ i +"].Ip");
				asset.Uuid = context.StringValue("DescribeAssetList.AssetList["+ i +"].Uuid");
				asset.AssetType = context.StringValue("DescribeAssetList.AssetList["+ i +"].AssetType");
				asset.Os = context.StringValue("DescribeAssetList.AssetList["+ i +"].Os");
				asset.ClientStatus = context.StringValue("DescribeAssetList.AssetList["+ i +"].ClientStatus");
				asset.Region = context.StringValue("DescribeAssetList.AssetList["+ i +"].Region");
				asset.RegionName = context.StringValue("DescribeAssetList.AssetList["+ i +"].RegionName");

				describeAssetListResponse_assetList.Add(asset);
			}
			describeAssetListResponse.AssetList = describeAssetListResponse_assetList;
        
			return describeAssetListResponse;
        }
    }
}
