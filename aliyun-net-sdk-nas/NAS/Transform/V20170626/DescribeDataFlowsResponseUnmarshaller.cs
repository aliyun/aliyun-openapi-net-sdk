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
using Aliyun.Acs.NAS.Model.V20170626;

namespace Aliyun.Acs.NAS.Transform.V20170626
{
    public class DescribeDataFlowsResponseUnmarshaller
    {
        public static DescribeDataFlowsResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeDataFlowsResponse describeDataFlowsResponse = new DescribeDataFlowsResponse();

			describeDataFlowsResponse.HttpResponse = _ctx.HttpResponse;
			describeDataFlowsResponse.RequestId = _ctx.StringValue("DescribeDataFlows.RequestId");
			describeDataFlowsResponse.NextToken = _ctx.StringValue("DescribeDataFlows.NextToken");

			List<DescribeDataFlowsResponse.DescribeDataFlows_DataFlow> describeDataFlowsResponse_dataFlowInfo = new List<DescribeDataFlowsResponse.DescribeDataFlows_DataFlow>();
			for (int i = 0; i < _ctx.Length("DescribeDataFlows.DataFlowInfo.Length"); i++) {
				DescribeDataFlowsResponse.DescribeDataFlows_DataFlow dataFlow = new DescribeDataFlowsResponse.DescribeDataFlows_DataFlow();
				dataFlow.FileSystemId = _ctx.StringValue("DescribeDataFlows.DataFlowInfo["+ i +"].FileSystemId");
				dataFlow.DataFlowId = _ctx.StringValue("DescribeDataFlows.DataFlowInfo["+ i +"].DataFlowId");
				dataFlow.FsetId = _ctx.StringValue("DescribeDataFlows.DataFlowInfo["+ i +"].FsetId");
				dataFlow.Status = _ctx.StringValue("DescribeDataFlows.DataFlowInfo["+ i +"].Status");
				dataFlow.ErrorMessage = _ctx.StringValue("DescribeDataFlows.DataFlowInfo["+ i +"].ErrorMessage");
				dataFlow.SourceStorage = _ctx.StringValue("DescribeDataFlows.DataFlowInfo["+ i +"].SourceStorage");
				dataFlow.SourceSecurityType = _ctx.StringValue("DescribeDataFlows.DataFlowInfo["+ i +"].SourceSecurityType");
				dataFlow.Throughput = _ctx.LongValue("DescribeDataFlows.DataFlowInfo["+ i +"].Throughput");
				dataFlow.Description = _ctx.StringValue("DescribeDataFlows.DataFlowInfo["+ i +"].Description");
				dataFlow.CreateTime = _ctx.StringValue("DescribeDataFlows.DataFlowInfo["+ i +"].CreateTime");
				dataFlow.UpdateTime = _ctx.StringValue("DescribeDataFlows.DataFlowInfo["+ i +"].UpdateTime");
				dataFlow.FileSystemPath = _ctx.StringValue("DescribeDataFlows.DataFlowInfo["+ i +"].FileSystemPath");
				dataFlow.FsetDescription = _ctx.StringValue("DescribeDataFlows.DataFlowInfo["+ i +"].FsetDescription");
				dataFlow.AutoRefreshInterval = _ctx.LongValue("DescribeDataFlows.DataFlowInfo["+ i +"].AutoRefreshInterval");
				dataFlow.AutoRefreshPolicy = _ctx.StringValue("DescribeDataFlows.DataFlowInfo["+ i +"].AutoRefreshPolicy");

				List<DescribeDataFlowsResponse.DescribeDataFlows_DataFlow.DescribeDataFlows_AutoRefreshItem> dataFlow_autoRefresh = new List<DescribeDataFlowsResponse.DescribeDataFlows_DataFlow.DescribeDataFlows_AutoRefreshItem>();
				for (int j = 0; j < _ctx.Length("DescribeDataFlows.DataFlowInfo["+ i +"].AutoRefresh.Length"); j++) {
					DescribeDataFlowsResponse.DescribeDataFlows_DataFlow.DescribeDataFlows_AutoRefreshItem autoRefreshItem = new DescribeDataFlowsResponse.DescribeDataFlows_DataFlow.DescribeDataFlows_AutoRefreshItem();
					autoRefreshItem.RefreshPath = _ctx.StringValue("DescribeDataFlows.DataFlowInfo["+ i +"].AutoRefresh["+ j +"].RefreshPath");

					dataFlow_autoRefresh.Add(autoRefreshItem);
				}
				dataFlow.AutoRefresh = dataFlow_autoRefresh;

				describeDataFlowsResponse_dataFlowInfo.Add(dataFlow);
			}
			describeDataFlowsResponse.DataFlowInfo = describeDataFlowsResponse_dataFlowInfo;
        
			return describeDataFlowsResponse;
        }
    }
}
