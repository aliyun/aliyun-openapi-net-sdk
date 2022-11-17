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
    public class DescribeSQLPlansResponseUnmarshaller
    {
        public static DescribeSQLPlansResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeSQLPlansResponse describeSQLPlansResponse = new DescribeSQLPlansResponse();

			describeSQLPlansResponse.HttpResponse = _ctx.HttpResponse;
			describeSQLPlansResponse.RequestId = _ctx.StringValue("DescribeSQLPlans.RequestId");

			List<DescribeSQLPlansResponse.DescribeSQLPlans_Data> describeSQLPlansResponse_sQLPlans = new List<DescribeSQLPlansResponse.DescribeSQLPlans_Data>();
			for (int i = 0; i < _ctx.Length("DescribeSQLPlans.SQLPlans.Length"); i++) {
				DescribeSQLPlansResponse.DescribeSQLPlans_Data data = new DescribeSQLPlansResponse.DescribeSQLPlans_Data();
				data.HitCount = _ctx.IntegerValue("DescribeSQLPlans.SQLPlans["+ i +"].HitCount");
				data.OutlineData = _ctx.StringValue("DescribeSQLPlans.SQLPlans["+ i +"].OutlineData");
				data.AvgExecutionMS = _ctx.FloatValue("DescribeSQLPlans.SQLPlans["+ i +"].AvgExecutionMS");
				data.PlanUnionHash = _ctx.StringValue("DescribeSQLPlans.SQLPlans["+ i +"].PlanUnionHash");
				data.OutlineId = _ctx.LongValue("DescribeSQLPlans.SQLPlans["+ i +"].OutlineId");
				data.AvgExecutionTimeMS = _ctx.LongValue("DescribeSQLPlans.SQLPlans["+ i +"].AvgExecutionTimeMS");
				data.PlanId = _ctx.IntegerValue("DescribeSQLPlans.SQLPlans["+ i +"].PlanId");
				data.OutlineTime = _ctx.LongValue("DescribeSQLPlans.SQLPlans["+ i +"].OutlineTime");
				data.OutlineTimeUTCString = _ctx.StringValue("DescribeSQLPlans.SQLPlans["+ i +"].OutlineTimeUTCString");
				data.PlanFull = _ctx.StringValue("DescribeSQLPlans.SQLPlans["+ i +"].PlanFull");
				data.NodeIp = _ctx.StringValue("DescribeSQLPlans.SQLPlans["+ i +"].NodeIp");
				data.MergedVersion = _ctx.IntegerValue("DescribeSQLPlans.SQLPlans["+ i +"].MergedVersion");
				data.QuerySQL = _ctx.StringValue("DescribeSQLPlans.SQLPlans["+ i +"].QuerySQL");
				data.FirstLoadTimeUTCString = _ctx.StringValue("DescribeSQLPlans.SQLPlans["+ i +"].FirstLoadTimeUTCString");
				data.FirstLoadTime = _ctx.LongValue("DescribeSQLPlans.SQLPlans["+ i +"].FirstLoadTime");
				data.PlanInfo = _ctx.StringValue("DescribeSQLPlans.SQLPlans["+ i +"].PlanInfo");

				describeSQLPlansResponse_sQLPlans.Add(data);
			}
			describeSQLPlansResponse.SQLPlans = describeSQLPlansResponse_sQLPlans;
        
			return describeSQLPlansResponse;
        }
    }
}
