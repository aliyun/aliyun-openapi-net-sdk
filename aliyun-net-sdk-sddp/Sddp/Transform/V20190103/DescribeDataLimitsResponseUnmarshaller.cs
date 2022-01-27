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
    public class DescribeDataLimitsResponseUnmarshaller
    {
        public static DescribeDataLimitsResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeDataLimitsResponse describeDataLimitsResponse = new DescribeDataLimitsResponse();

			describeDataLimitsResponse.HttpResponse = _ctx.HttpResponse;
			describeDataLimitsResponse.RequestId = _ctx.StringValue("DescribeDataLimits.RequestId");
			describeDataLimitsResponse.PageSize = _ctx.IntegerValue("DescribeDataLimits.PageSize");
			describeDataLimitsResponse.CurrentPage = _ctx.IntegerValue("DescribeDataLimits.CurrentPage");
			describeDataLimitsResponse.TotalCount = _ctx.IntegerValue("DescribeDataLimits.TotalCount");

			List<DescribeDataLimitsResponse.DescribeDataLimits_DataLimit> describeDataLimitsResponse_items = new List<DescribeDataLimitsResponse.DescribeDataLimits_DataLimit>();
			for (int i = 0; i < _ctx.Length("DescribeDataLimits.Items.Length"); i++) {
				DescribeDataLimitsResponse.DescribeDataLimits_DataLimit dataLimit = new DescribeDataLimitsResponse.DescribeDataLimits_DataLimit();
				dataLimit.RegionId = _ctx.StringValue("DescribeDataLimits.Items["+ i +"].RegionId");
				dataLimit.LocalName = _ctx.StringValue("DescribeDataLimits.Items["+ i +"].LocalName");
				dataLimit.ParentId = _ctx.StringValue("DescribeDataLimits.Items["+ i +"].ParentId");
				dataLimit.Id = _ctx.LongValue("DescribeDataLimits.Items["+ i +"].Id");
				dataLimit.UserName = _ctx.StringValue("DescribeDataLimits.Items["+ i +"].UserName");
				dataLimit.GmtCreate = _ctx.LongValue("DescribeDataLimits.Items["+ i +"].GmtCreate");
				dataLimit.Connector = _ctx.StringValue("DescribeDataLimits.Items["+ i +"].Connector");
				dataLimit.CheckStatus = _ctx.IntegerValue("DescribeDataLimits.Items["+ i +"].CheckStatus");
				dataLimit.CheckStatusName = _ctx.StringValue("DescribeDataLimits.Items["+ i +"].CheckStatusName");
				dataLimit.ResourceType = _ctx.LongValue("DescribeDataLimits.Items["+ i +"].ResourceType");
				dataLimit.ResourceTypeCode = _ctx.StringValue("DescribeDataLimits.Items["+ i +"].ResourceTypeCode");
				dataLimit.AuditStatus = _ctx.IntegerValue("DescribeDataLimits.Items["+ i +"].AuditStatus");
				dataLimit.LogStoreDay = _ctx.IntegerValue("DescribeDataLimits.Items["+ i +"].LogStoreDay");
				dataLimit.Enable = _ctx.IntegerValue("DescribeDataLimits.Items["+ i +"].Enable");
				dataLimit.AutoScan = _ctx.IntegerValue("DescribeDataLimits.Items["+ i +"].AutoScan");
				dataLimit.EngineType = _ctx.StringValue("DescribeDataLimits.Items["+ i +"].EngineType");
				dataLimit.ProcessStatus = _ctx.IntegerValue("DescribeDataLimits.Items["+ i +"].ProcessStatus");
				dataLimit.ProcessTotalCount = _ctx.IntegerValue("DescribeDataLimits.Items["+ i +"].ProcessTotalCount");
				dataLimit.TotalCount = _ctx.IntegerValue("DescribeDataLimits.Items["+ i +"].TotalCount");
				dataLimit.LastFinishedTime = _ctx.LongValue("DescribeDataLimits.Items["+ i +"].LastFinishedTime");
				dataLimit.ErrorCode = _ctx.StringValue("DescribeDataLimits.Items["+ i +"].ErrorCode");
				dataLimit.ErrorMessage = _ctx.StringValue("DescribeDataLimits.Items["+ i +"].ErrorMessage");
				dataLimit.Port = _ctx.IntegerValue("DescribeDataLimits.Items["+ i +"].Port");
				dataLimit.DbVersion = _ctx.StringValue("DescribeDataLimits.Items["+ i +"].DbVersion");
				dataLimit.SupportDatamask = _ctx.BooleanValue("DescribeDataLimits.Items["+ i +"].SupportDatamask");
				dataLimit.SupportScan = _ctx.BooleanValue("DescribeDataLimits.Items["+ i +"].SupportScan");
				dataLimit.SupportAudit = _ctx.BooleanValue("DescribeDataLimits.Items["+ i +"].SupportAudit");
				dataLimit.DatamaskStatus = _ctx.IntegerValue("DescribeDataLimits.Items["+ i +"].DatamaskStatus");
				dataLimit.SamplingSize = _ctx.IntegerValue("DescribeDataLimits.Items["+ i +"].SamplingSize");
				dataLimit.NextStartTime = _ctx.LongValue("DescribeDataLimits.Items["+ i +"].NextStartTime");
				dataLimit.SupportOcr = _ctx.BooleanValue("DescribeDataLimits.Items["+ i +"].SupportOcr");
				dataLimit.OcrStatus = _ctx.IntegerValue("DescribeDataLimits.Items["+ i +"].OcrStatus");
				dataLimit.AgentId = _ctx.StringValue("DescribeDataLimits.Items["+ i +"].AgentId");
				dataLimit.AgentState = _ctx.IntegerValue("DescribeDataLimits.Items["+ i +"].AgentState");
				dataLimit.SupportAgentInstall = _ctx.BooleanValue("DescribeDataLimits.Items["+ i +"].SupportAgentInstall");
				dataLimit.EventStatus = _ctx.IntegerValue("DescribeDataLimits.Items["+ i +"].EventStatus");
				dataLimit.SupportEvent = _ctx.BooleanValue("DescribeDataLimits.Items["+ i +"].SupportEvent");
				dataLimit.InstanceId = _ctx.StringValue("DescribeDataLimits.Items["+ i +"].InstanceId");
				dataLimit.InstanceDescription = _ctx.StringValue("DescribeDataLimits.Items["+ i +"].InstanceDescription");
				dataLimit.TenantName = _ctx.StringValue("DescribeDataLimits.Items["+ i +"].TenantName");

				describeDataLimitsResponse_items.Add(dataLimit);
			}
			describeDataLimitsResponse.Items = describeDataLimitsResponse_items;
        
			return describeDataLimitsResponse;
        }
    }
}
