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
using Aliyun.Acs.Sddp.Model.V20190103;

namespace Aliyun.Acs.Sddp.Transform.V20190103
{
    public class DescribeDataAssetsResponseUnmarshaller
    {
        public static DescribeDataAssetsResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeDataAssetsResponse describeDataAssetsResponse = new DescribeDataAssetsResponse();

			describeDataAssetsResponse.HttpResponse = _ctx.HttpResponse;
			describeDataAssetsResponse.CurrentPage = _ctx.IntegerValue("DescribeDataAssets.CurrentPage");
			describeDataAssetsResponse.RequestId = _ctx.StringValue("DescribeDataAssets.RequestId");
			describeDataAssetsResponse.PageSize = _ctx.IntegerValue("DescribeDataAssets.PageSize");
			describeDataAssetsResponse.TotalCount = _ctx.IntegerValue("DescribeDataAssets.TotalCount");

			List<DescribeDataAssetsResponse.DescribeDataAssets_Asset> describeDataAssetsResponse_items = new List<DescribeDataAssetsResponse.DescribeDataAssets_Asset>();
			for (int i = 0; i < _ctx.Length("DescribeDataAssets.Items.Length"); i++) {
				DescribeDataAssetsResponse.DescribeDataAssets_Asset asset = new DescribeDataAssetsResponse.DescribeDataAssets_Asset();
				asset.Acl = _ctx.StringValue("DescribeDataAssets.Items["+ i +"].Acl");
				asset.CreationTime = _ctx.LongValue("DescribeDataAssets.Items["+ i +"].CreationTime");
				asset.DataType = _ctx.StringValue("DescribeDataAssets.Items["+ i +"].DataType");
				asset.Owner = _ctx.StringValue("DescribeDataAssets.Items["+ i +"].Owner");
				asset.SensitiveRatio = _ctx.StringValue("DescribeDataAssets.Items["+ i +"].SensitiveRatio");
				asset.Protection = _ctx.BooleanValue("DescribeDataAssets.Items["+ i +"].Protection");
				asset.DepartName = _ctx.StringValue("DescribeDataAssets.Items["+ i +"].DepartName");
				asset.Labelsec = _ctx.BooleanValue("DescribeDataAssets.Items["+ i +"].Labelsec");
				asset.TotalCount = _ctx.IntegerValue("DescribeDataAssets.Items["+ i +"].TotalCount");
				asset.RiskLevelId = _ctx.LongValue("DescribeDataAssets.Items["+ i +"].RiskLevelId");
				asset.RuleName = _ctx.StringValue("DescribeDataAssets.Items["+ i +"].RuleName");
				asset.Sensitive = _ctx.BooleanValue("DescribeDataAssets.Items["+ i +"].Sensitive");
				asset.ObjectKey = _ctx.StringValue("DescribeDataAssets.Items["+ i +"].ObjectKey");
				asset.RiskLevelName = _ctx.StringValue("DescribeDataAssets.Items["+ i +"].RiskLevelName");
				asset.OdpsRiskLevelName = _ctx.StringValue("DescribeDataAssets.Items["+ i +"].OdpsRiskLevelName");
				asset.ProductId = _ctx.StringValue("DescribeDataAssets.Items["+ i +"].ProductId");
				asset.Name = _ctx.StringValue("DescribeDataAssets.Items["+ i +"].Name");
				asset.SensitiveCount = _ctx.IntegerValue("DescribeDataAssets.Items["+ i +"].SensitiveCount");
				asset.Id = _ctx.StringValue("DescribeDataAssets.Items["+ i +"].Id");
				asset.ProductCode = _ctx.StringValue("DescribeDataAssets.Items["+ i +"].ProductCode");

				describeDataAssetsResponse_items.Add(asset);
			}
			describeDataAssetsResponse.Items = describeDataAssetsResponse_items;
        
			return describeDataAssetsResponse;
        }
    }
}
