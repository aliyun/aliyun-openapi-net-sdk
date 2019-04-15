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
    public class DescribeWhiteListAssetResponseUnmarshaller
    {
        public static DescribeWhiteListAssetResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeWhiteListAssetResponse describeWhiteListAssetResponse = new DescribeWhiteListAssetResponse();

			describeWhiteListAssetResponse.HttpResponse = context.HttpResponse;
			describeWhiteListAssetResponse.RequestId = context.StringValue("DescribeWhiteListAsset.RequestId");

			List<DescribeWhiteListAssetResponse.DescribeWhiteListAsset_Asset> describeWhiteListAssetResponse_assets = new List<DescribeWhiteListAssetResponse.DescribeWhiteListAsset_Asset>();
			for (int i = 0; i < context.Length("DescribeWhiteListAsset.Assets.Length"); i++) {
				DescribeWhiteListAssetResponse.DescribeWhiteListAsset_Asset asset = new DescribeWhiteListAssetResponse.DescribeWhiteListAsset_Asset();
				asset.Id = context.LongValue("DescribeWhiteListAsset.Assets["+ i +"].Id");
				asset.Uuid = context.StringValue("DescribeWhiteListAsset.Assets["+ i +"].Uuid");
				asset.GroupId = context.LongValue("DescribeWhiteListAsset.Assets["+ i +"].GroupId");
				asset.MachineName = context.StringValue("DescribeWhiteListAsset.Assets["+ i +"].MachineName");
				asset.MachineIp = context.StringValue("DescribeWhiteListAsset.Assets["+ i +"].MachineIp");
				asset.Selected = context.IntegerValue("DescribeWhiteListAsset.Assets["+ i +"].Selected");
				asset.AllowSelected = context.IntegerValue("DescribeWhiteListAsset.Assets["+ i +"].AllowSelected");

				describeWhiteListAssetResponse_assets.Add(asset);
			}
			describeWhiteListAssetResponse.Assets = describeWhiteListAssetResponse_assets;
        
			return describeWhiteListAssetResponse;
        }
    }
}
