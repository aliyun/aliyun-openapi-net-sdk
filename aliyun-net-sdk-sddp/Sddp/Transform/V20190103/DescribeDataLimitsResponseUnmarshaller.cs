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
			describeDataLimitsResponse.CurrentPage = _ctx.IntegerValue("DescribeDataLimits.CurrentPage");
			describeDataLimitsResponse.RequestId = _ctx.StringValue("DescribeDataLimits.RequestId");
			describeDataLimitsResponse.PageSize = _ctx.IntegerValue("DescribeDataLimits.PageSize");
			describeDataLimitsResponse.TotalCount = _ctx.IntegerValue("DescribeDataLimits.TotalCount");

			List<DescribeDataLimitsResponse.DescribeDataLimits_DataLimit> describeDataLimitsResponse_items = new List<DescribeDataLimitsResponse.DescribeDataLimits_DataLimit>();
			for (int i = 0; i < _ctx.Length("DescribeDataLimits.Items.Length"); i++) {
				DescribeDataLimitsResponse.DescribeDataLimits_DataLimit dataLimit = new DescribeDataLimitsResponse.DescribeDataLimits_DataLimit();
				dataLimit.SupportEvent = _ctx.BooleanValue("DescribeDataLimits.Items["+ i +"].SupportEvent");
				dataLimit.ErrorMessage = _ctx.StringValue("DescribeDataLimits.Items["+ i +"].ErrorMessage");
				dataLimit.CheckStatus = _ctx.IntegerValue("DescribeDataLimits.Items["+ i +"].CheckStatus");
				dataLimit.LocalName = _ctx.StringValue("DescribeDataLimits.Items["+ i +"].LocalName");
				dataLimit.TenantName = _ctx.StringValue("DescribeDataLimits.Items["+ i +"].TenantName");
				dataLimit.AgentId = _ctx.StringValue("DescribeDataLimits.Items["+ i +"].AgentId");
				dataLimit.NextStartTime = _ctx.LongValue("DescribeDataLimits.Items["+ i +"].NextStartTime");
				dataLimit.Connector = _ctx.StringValue("DescribeDataLimits.Items["+ i +"].Connector");
				dataLimit.Port = _ctx.IntegerValue("DescribeDataLimits.Items["+ i +"].Port");
				dataLimit.CheckStatusName = _ctx.StringValue("DescribeDataLimits.Items["+ i +"].CheckStatusName");
				dataLimit.AgentState = _ctx.IntegerValue("DescribeDataLimits.Items["+ i +"].AgentState");
				dataLimit.SamplingSize = _ctx.IntegerValue("DescribeDataLimits.Items["+ i +"].SamplingSize");
				dataLimit.ParentId = _ctx.StringValue("DescribeDataLimits.Items["+ i +"].ParentId");
				dataLimit.DatamaskStatus = _ctx.IntegerValue("DescribeDataLimits.Items["+ i +"].DatamaskStatus");
				dataLimit.ProcessTotalCount = _ctx.IntegerValue("DescribeDataLimits.Items["+ i +"].ProcessTotalCount");
				dataLimit.ResourceType = _ctx.LongValue("DescribeDataLimits.Items["+ i +"].ResourceType");
				dataLimit.ErrorCode = _ctx.StringValue("DescribeDataLimits.Items["+ i +"].ErrorCode");
				dataLimit.OcrStatus = _ctx.IntegerValue("DescribeDataLimits.Items["+ i +"].OcrStatus");
				dataLimit.LogStoreDay = _ctx.IntegerValue("DescribeDataLimits.Items["+ i +"].LogStoreDay");
				dataLimit.EventStatus = _ctx.IntegerValue("DescribeDataLimits.Items["+ i +"].EventStatus");
				dataLimit.SupportScan = _ctx.BooleanValue("DescribeDataLimits.Items["+ i +"].SupportScan");
				dataLimit.LastFinishedTime = _ctx.LongValue("DescribeDataLimits.Items["+ i +"].LastFinishedTime");
				dataLimit.UserName = _ctx.StringValue("DescribeDataLimits.Items["+ i +"].UserName");
				dataLimit.AuditStatus = _ctx.IntegerValue("DescribeDataLimits.Items["+ i +"].AuditStatus");
				dataLimit.SupportOcr = _ctx.BooleanValue("DescribeDataLimits.Items["+ i +"].SupportOcr");
				dataLimit.SupportAgentInstall = _ctx.BooleanValue("DescribeDataLimits.Items["+ i +"].SupportAgentInstall");
				dataLimit.EngineType = _ctx.StringValue("DescribeDataLimits.Items["+ i +"].EngineType");
				dataLimit.InstanceId = _ctx.StringValue("DescribeDataLimits.Items["+ i +"].InstanceId");
				dataLimit.TotalCount = _ctx.IntegerValue("DescribeDataLimits.Items["+ i +"].TotalCount");
				dataLimit.InstanceDescription = _ctx.StringValue("DescribeDataLimits.Items["+ i +"].InstanceDescription");
				dataLimit.DbVersion = _ctx.StringValue("DescribeDataLimits.Items["+ i +"].DbVersion");
				dataLimit.RegionId = _ctx.StringValue("DescribeDataLimits.Items["+ i +"].RegionId");
				dataLimit.GmtCreate = _ctx.LongValue("DescribeDataLimits.Items["+ i +"].GmtCreate");
				dataLimit.SupportAudit = _ctx.BooleanValue("DescribeDataLimits.Items["+ i +"].SupportAudit");
				dataLimit.AutoScan = _ctx.IntegerValue("DescribeDataLimits.Items["+ i +"].AutoScan");
				dataLimit.ResourceTypeCode = _ctx.StringValue("DescribeDataLimits.Items["+ i +"].ResourceTypeCode");
				dataLimit.SupportDatamask = _ctx.BooleanValue("DescribeDataLimits.Items["+ i +"].SupportDatamask");
				dataLimit.ProcessStatus = _ctx.IntegerValue("DescribeDataLimits.Items["+ i +"].ProcessStatus");
				dataLimit.Id = _ctx.LongValue("DescribeDataLimits.Items["+ i +"].Id");
				dataLimit.Enable = _ctx.IntegerValue("DescribeDataLimits.Items["+ i +"].Enable");

				describeDataLimitsResponse_items.Add(dataLimit);
			}
			describeDataLimitsResponse.Items = describeDataLimitsResponse_items;
        
			return describeDataLimitsResponse;
        }
    }
}
