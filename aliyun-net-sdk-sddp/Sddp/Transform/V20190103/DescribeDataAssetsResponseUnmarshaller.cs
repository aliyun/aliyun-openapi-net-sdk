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
        public static DescribeDataAssetsResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeDataAssetsResponse describeDataAssetsResponse = new DescribeDataAssetsResponse();

			describeDataAssetsResponse.HttpResponse = context.HttpResponse;
			describeDataAssetsResponse.RequestId = context.StringValue("DescribeDataAssets.RequestId");
			describeDataAssetsResponse.PageSize = context.IntegerValue("DescribeDataAssets.PageSize");
			describeDataAssetsResponse.CurrentPage = context.IntegerValue("DescribeDataAssets.CurrentPage");
			describeDataAssetsResponse.TotalCount = context.IntegerValue("DescribeDataAssets.TotalCount");

			List<DescribeDataAssetsResponse.DescribeDataAssets_Asset> describeDataAssetsResponse_items = new List<DescribeDataAssetsResponse.DescribeDataAssets_Asset>();
			for (int i = 0; i < context.Length("DescribeDataAssets.Items.Length"); i++) {
				DescribeDataAssetsResponse.DescribeDataAssets_Asset asset = new DescribeDataAssetsResponse.DescribeDataAssets_Asset();
				asset.Id = context.StringValue("DescribeDataAssets.Items["+ i +"].Id");
				asset.Name = context.StringValue("DescribeDataAssets.Items["+ i +"].Name");
				asset.Owner = context.StringValue("DescribeDataAssets.Items["+ i +"].Owner");
				asset.CreationTime = context.LongValue("DescribeDataAssets.Items["+ i +"].CreationTime");
				asset.ProductId = context.StringValue("DescribeDataAssets.Items["+ i +"].ProductId");
				asset.ProductCode = context.StringValue("DescribeDataAssets.Items["+ i +"].ProductCode");
				asset.Protection = context.BooleanValue("DescribeDataAssets.Items["+ i +"].Protection");
				asset.Labelsec = context.IntegerValue("DescribeDataAssets.Items["+ i +"].Labelsec");
				asset.OdpsRiskLevelName = context.StringValue("DescribeDataAssets.Items["+ i +"].OdpsRiskLevelName");
				asset.Sensitive = context.BooleanValue("DescribeDataAssets.Items["+ i +"].Sensitive");
				asset.RiskLevelId = context.LongValue("DescribeDataAssets.Items["+ i +"].RiskLevelId");
				asset.RiskLevelName = context.StringValue("DescribeDataAssets.Items["+ i +"].RiskLevelName");
				asset.RuleName = context.StringValue("DescribeDataAssets.Items["+ i +"].RuleName");
				asset.DepartName = context.StringValue("DescribeDataAssets.Items["+ i +"].DepartName");
				asset.TotalCount = context.IntegerValue("DescribeDataAssets.Items["+ i +"].TotalCount");
				asset.SensitiveCount = context.IntegerValue("DescribeDataAssets.Items["+ i +"].SensitiveCount");
				asset.Acl = context.StringValue("DescribeDataAssets.Items["+ i +"].Acl");
				asset.SensitiveRatio = context.StringValue("DescribeDataAssets.Items["+ i +"].SensitiveRatio");
				asset.DataType = context.StringValue("DescribeDataAssets.Items["+ i +"].DataType");
				asset.ObjectKey = context.StringValue("DescribeDataAssets.Items["+ i +"].ObjectKey");

				describeDataAssetsResponse_items.Add(asset);
			}
			describeDataAssetsResponse.Items = describeDataAssetsResponse_items;
        
			return describeDataAssetsResponse;
        }
    }
}
