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
using Aliyun.Acs.Emr.Model.V20160408;

namespace Aliyun.Acs.Emr.Transform.V20160408
{
    public class ListApmApplicationResponseUnmarshaller
    {
        public static ListApmApplicationResponse Unmarshall(UnmarshallerContext _ctx)
        {
			ListApmApplicationResponse listApmApplicationResponse = new ListApmApplicationResponse();

			listApmApplicationResponse.HttpResponse = _ctx.HttpResponse;
			listApmApplicationResponse.RequestId = _ctx.StringValue("ListApmApplication.RequestId");
			listApmApplicationResponse.Total = _ctx.IntegerValue("ListApmApplication.Total");
			listApmApplicationResponse.PageSize = _ctx.IntegerValue("ListApmApplication.PageSize");
			listApmApplicationResponse.PageNumber = _ctx.IntegerValue("ListApmApplication.PageNumber");

			List<ListApmApplicationResponse.ListApmApplication_ApmAppInfo> listApmApplicationResponse_apmAppInfoList = new List<ListApmApplicationResponse.ListApmApplication_ApmAppInfo>();
			for (int i = 0; i < _ctx.Length("ListApmApplication.ApmAppInfoList.Length"); i++) {
				ListApmApplicationResponse.ListApmApplication_ApmAppInfo apmAppInfo = new ListApmApplicationResponse.ListApmApplication_ApmAppInfo();
				apmAppInfo.ApplicationId = _ctx.StringValue("ListApmApplication.ApmAppInfoList["+ i +"].ApplicationId");
				apmAppInfo.ClusterBizId = _ctx.StringValue("ListApmApplication.ApmAppInfoList["+ i +"].ClusterBizId");
				apmAppInfo.ApplicationType = _ctx.StringValue("ListApmApplication.ApmAppInfoList["+ i +"].ApplicationType");
				apmAppInfo.Name = _ctx.StringValue("ListApmApplication.ApmAppInfoList["+ i +"].Name");
				apmAppInfo.State = _ctx.StringValue("ListApmApplication.ApmAppInfoList["+ i +"].State");
				apmAppInfo.FinalStatus = _ctx.StringValue("ListApmApplication.ApmAppInfoList["+ i +"].FinalStatus");
				apmAppInfo.Queue = _ctx.StringValue("ListApmApplication.ApmAppInfoList["+ i +"].Queue");
				apmAppInfo.User = _ctx.StringValue("ListApmApplication.ApmAppInfoList["+ i +"].User");
				apmAppInfo.AllocatedVcore = _ctx.LongValue("ListApmApplication.ApmAppInfoList["+ i +"].AllocatedVcore");
				apmAppInfo.AllocatedMemory = _ctx.LongValue("ListApmApplication.ApmAppInfoList["+ i +"].AllocatedMemory");
				apmAppInfo.Progress = _ctx.FloatValue("ListApmApplication.ApmAppInfoList["+ i +"].Progress");
				apmAppInfo.VcoreSeconds = _ctx.LongValue("ListApmApplication.ApmAppInfoList["+ i +"].VcoreSeconds");
				apmAppInfo.MemorySeconds = _ctx.LongValue("ListApmApplication.ApmAppInfoList["+ i +"].MemorySeconds");
				apmAppInfo.StartTime = _ctx.LongValue("ListApmApplication.ApmAppInfoList["+ i +"].StartTime");
				apmAppInfo.SubmitTime = _ctx.LongValue("ListApmApplication.ApmAppInfoList["+ i +"].SubmitTime");
				apmAppInfo.FinishedTime = _ctx.LongValue("ListApmApplication.ApmAppInfoList["+ i +"].FinishedTime");
				apmAppInfo.Duration = _ctx.IntegerValue("ListApmApplication.ApmAppInfoList["+ i +"].Duration");
				apmAppInfo.Diagnostics = _ctx.StringValue("ListApmApplication.ApmAppInfoList["+ i +"].Diagnostics");
				apmAppInfo.ClusterUsagePercent = _ctx.FloatValue("ListApmApplication.ApmAppInfoList["+ i +"].ClusterUsagePercent");
				apmAppInfo.QueueUsagePercent = _ctx.FloatValue("ListApmApplication.ApmAppInfoList["+ i +"].QueueUsagePercent");
				apmAppInfo.RunningContainers = _ctx.IntegerValue("ListApmApplication.ApmAppInfoList["+ i +"].RunningContainers");
				apmAppInfo.RunningDuration = _ctx.IntegerValue("ListApmApplication.ApmAppInfoList["+ i +"].RunningDuration");
				apmAppInfo.ResourceRequests = _ctx.StringValue("ListApmApplication.ApmAppInfoList["+ i +"].ResourceRequests");
				apmAppInfo.DiagnoseResult = _ctx.StringValue("ListApmApplication.ApmAppInfoList["+ i +"].DiagnoseResult");
				apmAppInfo.DiagnoseCode = _ctx.StringValue("ListApmApplication.ApmAppInfoList["+ i +"].DiagnoseCode");

				listApmApplicationResponse_apmAppInfoList.Add(apmAppInfo);
			}
			listApmApplicationResponse.ApmAppInfoList = listApmApplicationResponse_apmAppInfoList;
        
			return listApmApplicationResponse;
        }
    }
}
