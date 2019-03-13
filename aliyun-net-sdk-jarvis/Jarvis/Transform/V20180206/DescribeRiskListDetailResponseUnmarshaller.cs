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
using Aliyun.Acs.jarvis.Model.V20180206;

namespace Aliyun.Acs.jarvis.Transform.V20180206
{
    public class DescribeRiskListDetailResponseUnmarshaller
    {
        public static DescribeRiskListDetailResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeRiskListDetailResponse describeRiskListDetailResponse = new DescribeRiskListDetailResponse();

			describeRiskListDetailResponse.HttpResponse = context.HttpResponse;
			describeRiskListDetailResponse.RequestId = context.StringValue("DescribeRiskListDetail.RequestId");
			describeRiskListDetailResponse.Module = context.StringValue("DescribeRiskListDetail.Module");

			DescribeRiskListDetailResponse.DescribeRiskListDetail_PageInfo pageInfo = new DescribeRiskListDetailResponse.DescribeRiskListDetail_PageInfo();
			pageInfo.Total = context.IntegerValue("DescribeRiskListDetail.PageInfo.Total");
			pageInfo.PageSize = context.IntegerValue("DescribeRiskListDetail.PageInfo.PageSize");
			pageInfo.CurrentPage = context.IntegerValue("DescribeRiskListDetail.PageInfo.CurrentPage");
			describeRiskListDetailResponse.PageInfo = pageInfo;

			List<DescribeRiskListDetailResponse.DescribeRiskListDetail_Data> describeRiskListDetailResponse_dataList = new List<DescribeRiskListDetailResponse.DescribeRiskListDetail_Data>();
			for (int i = 0; i < context.Length("DescribeRiskListDetail.DataList.Length"); i++) {
				DescribeRiskListDetailResponse.DescribeRiskListDetail_Data data = new DescribeRiskListDetailResponse.DescribeRiskListDetail_Data();
				data.RiskId = context.IntegerValue("DescribeRiskListDetail.DataList["+ i +"].RiskId");
				data.UpdateTime = context.StringValue("DescribeRiskListDetail.DataList["+ i +"].UpdateTime");
				data.RiskDescribe = context.StringValue("DescribeRiskListDetail.DataList["+ i +"].RiskDescribe");
				data.RiskType = context.StringValue("DescribeRiskListDetail.DataList["+ i +"].RiskType");
				data.RiskInstance = context.StringValue("DescribeRiskListDetail.DataList["+ i +"].RiskInstance");
				data.Product = context.StringValue("DescribeRiskListDetail.DataList["+ i +"].Product");
				data.RegionId = context.StringValue("DescribeRiskListDetail.DataList["+ i +"].RegionId");
				data.TacticsName = context.StringValue("DescribeRiskListDetail.DataList["+ i +"].TacticsName");
				data.Status = context.StringValue("DescribeRiskListDetail.DataList["+ i +"].Status");
				data.IgnoreTime = context.StringValue("DescribeRiskListDetail.DataList["+ i +"].IgnoreTime");

				List<string> data_instanceList = new List<string>();
				for (int j = 0; j < context.Length("DescribeRiskListDetail.DataList["+ i +"].InstanceList.Length"); j++) {
					data_instanceList.Add(context.StringValue("DescribeRiskListDetail.DataList["+ i +"].InstanceList["+ j +"]"));
				}
				data.InstanceList = data_instanceList;

				List<DescribeRiskListDetailResponse.DescribeRiskListDetail_Data.DescribeRiskListDetail_EcsSecGroupRiskItem> data_ecsSecGroupRisk = new List<DescribeRiskListDetailResponse.DescribeRiskListDetail_Data.DescribeRiskListDetail_EcsSecGroupRiskItem>();
				for (int j = 0; j < context.Length("DescribeRiskListDetail.DataList["+ i +"].EcsSecGroupRisk.Length"); j++) {
					DescribeRiskListDetailResponse.DescribeRiskListDetail_Data.DescribeRiskListDetail_EcsSecGroupRiskItem ecsSecGroupRiskItem = new DescribeRiskListDetailResponse.DescribeRiskListDetail_Data.DescribeRiskListDetail_EcsSecGroupRiskItem();
					ecsSecGroupRiskItem.NetType = context.StringValue("DescribeRiskListDetail.DataList["+ i +"].EcsSecGroupRisk["+ j +"].NetType");
					ecsSecGroupRiskItem.Direction = context.StringValue("DescribeRiskListDetail.DataList["+ i +"].EcsSecGroupRisk["+ j +"].Direction");
					ecsSecGroupRiskItem.DstPortRange = context.StringValue("DescribeRiskListDetail.DataList["+ i +"].EcsSecGroupRisk["+ j +"].DstPortRange");
					ecsSecGroupRiskItem.SrcIpRange = context.StringValue("DescribeRiskListDetail.DataList["+ i +"].EcsSecGroupRisk["+ j +"].SrcIpRange");

					data_ecsSecGroupRisk.Add(ecsSecGroupRiskItem);
				}
				data.EcsSecGroupRisk = data_ecsSecGroupRisk;

				List<DescribeRiskListDetailResponse.DescribeRiskListDetail_Data.DescribeRiskListDetail_RdsWhitelistRiskItem> data_rdsWhitelistRisk = new List<DescribeRiskListDetailResponse.DescribeRiskListDetail_Data.DescribeRiskListDetail_RdsWhitelistRiskItem>();
				for (int j = 0; j < context.Length("DescribeRiskListDetail.DataList["+ i +"].RdsWhitelistRisk.Length"); j++) {
					DescribeRiskListDetailResponse.DescribeRiskListDetail_Data.DescribeRiskListDetail_RdsWhitelistRiskItem rdsWhitelistRiskItem = new DescribeRiskListDetailResponse.DescribeRiskListDetail_Data.DescribeRiskListDetail_RdsWhitelistRiskItem();
					rdsWhitelistRiskItem.RdsWhitelistGroup = context.StringValue("DescribeRiskListDetail.DataList["+ i +"].RdsWhitelistRisk["+ j +"].RdsWhitelistGroup");
					rdsWhitelistRiskItem.RiskDetail = context.StringValue("DescribeRiskListDetail.DataList["+ i +"].RdsWhitelistRisk["+ j +"].RiskDetail");

					data_rdsWhitelistRisk.Add(rdsWhitelistRiskItem);
				}
				data.RdsWhitelistRisk = data_rdsWhitelistRisk;

				describeRiskListDetailResponse_dataList.Add(data);
			}
			describeRiskListDetailResponse.DataList = describeRiskListDetailResponse_dataList;
        
			return describeRiskListDetailResponse;
        }
    }
}
