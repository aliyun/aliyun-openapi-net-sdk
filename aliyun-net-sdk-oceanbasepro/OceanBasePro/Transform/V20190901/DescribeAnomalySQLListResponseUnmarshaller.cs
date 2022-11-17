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
    public class DescribeAnomalySQLListResponseUnmarshaller
    {
        public static DescribeAnomalySQLListResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeAnomalySQLListResponse describeAnomalySQLListResponse = new DescribeAnomalySQLListResponse();

			describeAnomalySQLListResponse.HttpResponse = _ctx.HttpResponse;
			describeAnomalySQLListResponse.TotalCount = _ctx.LongValue("DescribeAnomalySQLList.TotalCount");
			describeAnomalySQLListResponse.RequestId = _ctx.StringValue("DescribeAnomalySQLList.RequestId");

			List<DescribeAnomalySQLListResponse.DescribeAnomalySQLList_Data> describeAnomalySQLListResponse_anomalySQLList = new List<DescribeAnomalySQLListResponse.DescribeAnomalySQLList_Data>();
			for (int i = 0; i < _ctx.Length("DescribeAnomalySQLList.AnomalySQLList.Length"); i++) {
				DescribeAnomalySQLListResponse.DescribeAnomalySQLList_Data data = new DescribeAnomalySQLListResponse.DescribeAnomalySQLList_Data();
				data.Key = _ctx.LongValue("DescribeAnomalySQLList.AnomalySQLList["+ i +"].Key");
				data.DiagnosisRule = _ctx.StringValue("DescribeAnomalySQLList.AnomalySQLList["+ i +"].DiagnosisRule");
				data.SQLText = _ctx.StringValue("DescribeAnomalySQLList.AnomalySQLList["+ i +"].SQLText");
				data.Suggestion = _ctx.StringValue("DescribeAnomalySQLList.AnomalySQLList["+ i +"].Suggestion");
				data.DbName = _ctx.StringValue("DescribeAnomalySQLList.AnomalySQLList["+ i +"].DbName");
				data.RequestTimeUTCString = _ctx.StringValue("DescribeAnomalySQLList.AnomalySQLList["+ i +"].RequestTimeUTCString");
				data.CpuTime = _ctx.FloatValue("DescribeAnomalySQLList.AnomalySQLList["+ i +"].CpuTime");
				data.SQLId = _ctx.StringValue("DescribeAnomalySQLList.AnomalySQLList["+ i +"].SQLId");
				data.Diagnosis = _ctx.StringValue("DescribeAnomalySQLList.AnomalySQLList["+ i +"].Diagnosis");
				data.RequestTime = _ctx.FloatValue("DescribeAnomalySQLList.AnomalySQLList["+ i +"].RequestTime");
				data.Executions = _ctx.LongValue("DescribeAnomalySQLList.AnomalySQLList["+ i +"].Executions");
				data.UserName = _ctx.StringValue("DescribeAnomalySQLList.AnomalySQLList["+ i +"].UserName");

				describeAnomalySQLListResponse_anomalySQLList.Add(data);
			}
			describeAnomalySQLListResponse.AnomalySQLList = describeAnomalySQLListResponse_anomalySQLList;
        
			return describeAnomalySQLListResponse;
        }
    }
}
