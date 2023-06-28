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
using Aliyun.Acs.OceanBasePro.Model.V20190901;

namespace Aliyun.Acs.OceanBasePro.Transform.V20190901
{
    public class DescribeOasAnomalySQLListResponseUnmarshaller
    {
        public static DescribeOasAnomalySQLListResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeOasAnomalySQLListResponse describeOasAnomalySQLListResponse = new DescribeOasAnomalySQLListResponse();

			describeOasAnomalySQLListResponse.HttpResponse = _ctx.HttpResponse;
			describeOasAnomalySQLListResponse.RequestId = _ctx.StringValue("DescribeOasAnomalySQLList.RequestId");
			describeOasAnomalySQLListResponse.TotalCount = _ctx.LongValue("DescribeOasAnomalySQLList.TotalCount");

			List<DescribeOasAnomalySQLListResponse.DescribeOasAnomalySQLList_DataItem> describeOasAnomalySQLListResponse_data = new List<DescribeOasAnomalySQLListResponse.DescribeOasAnomalySQLList_DataItem>();
			for (int i = 0; i < _ctx.Length("DescribeOasAnomalySQLList.Data.Length"); i++) {
				DescribeOasAnomalySQLListResponse.DescribeOasAnomalySQLList_DataItem dataItem = new DescribeOasAnomalySQLListResponse.DescribeOasAnomalySQLList_DataItem();
				dataItem.AvgCpuTime = _ctx.DoubleValue("DescribeOasAnomalySQLList.Data["+ i +"].AvgCpuTime");
				dataItem.AvgElapsedTime = _ctx.DoubleValue("DescribeOasAnomalySQLList.Data["+ i +"].AvgElapsedTime");
				dataItem.AvgGetPlanTime = _ctx.DoubleValue("DescribeOasAnomalySQLList.Data["+ i +"].AvgGetPlanTime");
				dataItem.CpuTime = _ctx.DoubleValue("DescribeOasAnomalySQLList.Data["+ i +"].CpuTime");
				dataItem.DbName = _ctx.StringValue("DescribeOasAnomalySQLList.Data["+ i +"].DbName");
				dataItem.Diagnosis = _ctx.StringValue("DescribeOasAnomalySQLList.Data["+ i +"].Diagnosis");
				dataItem.Executions = _ctx.DoubleValue("DescribeOasAnomalySQLList.Data["+ i +"].Executions");
				dataItem.LastExecutedTime = _ctx.DoubleValue("DescribeOasAnomalySQLList.Data["+ i +"].LastExecutedTime");
				dataItem.RiskLevel = _ctx.StringValue("DescribeOasAnomalySQLList.Data["+ i +"].RiskLevel");
				dataItem.SqlId = _ctx.StringValue("DescribeOasAnomalySQLList.Data["+ i +"].SqlId");
				dataItem.SqlTextShort = _ctx.StringValue("DescribeOasAnomalySQLList.Data["+ i +"].SqlTextShort");
				dataItem.Suggestion = _ctx.StringValue("DescribeOasAnomalySQLList.Data["+ i +"].Suggestion");
				dataItem.SumElapsedTime = _ctx.StringValue("DescribeOasAnomalySQLList.Data["+ i +"].SumElapsedTime");
				dataItem.UserName = _ctx.StringValue("DescribeOasAnomalySQLList.Data["+ i +"].UserName");

				List<string> dataItem_diagTypes = new List<string>();
				for (int j = 0; j < _ctx.Length("DescribeOasAnomalySQLList.Data["+ i +"].DiagTypes.Length"); j++) {
					dataItem_diagTypes.Add(_ctx.StringValue("DescribeOasAnomalySQLList.Data["+ i +"].DiagTypes["+ j +"]"));
				}
				dataItem.DiagTypes = dataItem_diagTypes;

				describeOasAnomalySQLListResponse_data.Add(dataItem);
			}
			describeOasAnomalySQLListResponse.Data = describeOasAnomalySQLListResponse_data;
        
			return describeOasAnomalySQLListResponse;
        }
    }
}
