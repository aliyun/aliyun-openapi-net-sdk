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
    public class DescribeDataLimitsInstanceDimResponseUnmarshaller
    {
        public static DescribeDataLimitsInstanceDimResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeDataLimitsInstanceDimResponse describeDataLimitsInstanceDimResponse = new DescribeDataLimitsInstanceDimResponse();

			describeDataLimitsInstanceDimResponse.HttpResponse = _ctx.HttpResponse;
			describeDataLimitsInstanceDimResponse.RequestId = _ctx.StringValue("DescribeDataLimitsInstanceDim.RequestId");
			describeDataLimitsInstanceDimResponse.PageSize = _ctx.IntegerValue("DescribeDataLimitsInstanceDim.PageSize");
			describeDataLimitsInstanceDimResponse.CurrentPage = _ctx.IntegerValue("DescribeDataLimitsInstanceDim.CurrentPage");
			describeDataLimitsInstanceDimResponse.TotalCount = _ctx.IntegerValue("DescribeDataLimitsInstanceDim.TotalCount");

			List<DescribeDataLimitsInstanceDimResponse.DescribeDataLimitsInstanceDim_DataLimit> describeDataLimitsInstanceDimResponse_items = new List<DescribeDataLimitsInstanceDimResponse.DescribeDataLimitsInstanceDim_DataLimit>();
			for (int i = 0; i < _ctx.Length("DescribeDataLimitsInstanceDim.Items.Length"); i++) {
				DescribeDataLimitsInstanceDimResponse.DescribeDataLimitsInstanceDim_DataLimit dataLimit = new DescribeDataLimitsInstanceDimResponse.DescribeDataLimitsInstanceDim_DataLimit();
				dataLimit.RegionId = _ctx.StringValue("DescribeDataLimitsInstanceDim.Items["+ i +"].RegionId");
				dataLimit.LocalName = _ctx.StringValue("DescribeDataLimitsInstanceDim.Items["+ i +"].LocalName");
				dataLimit.ParentId = _ctx.StringValue("DescribeDataLimitsInstanceDim.Items["+ i +"].ParentId");
				dataLimit.Id = _ctx.LongValue("DescribeDataLimitsInstanceDim.Items["+ i +"].Id");
				dataLimit.UserName = _ctx.StringValue("DescribeDataLimitsInstanceDim.Items["+ i +"].UserName");
				dataLimit.GmtCreate = _ctx.LongValue("DescribeDataLimitsInstanceDim.Items["+ i +"].GmtCreate");
				dataLimit.Connector = _ctx.StringValue("DescribeDataLimitsInstanceDim.Items["+ i +"].Connector");
				dataLimit.CheckStatus = _ctx.IntegerValue("DescribeDataLimitsInstanceDim.Items["+ i +"].CheckStatus");
				dataLimit.CheckStatusName = _ctx.StringValue("DescribeDataLimitsInstanceDim.Items["+ i +"].CheckStatusName");
				dataLimit.ResourceType = _ctx.LongValue("DescribeDataLimitsInstanceDim.Items["+ i +"].ResourceType");
				dataLimit.ResourceTypeCode = _ctx.StringValue("DescribeDataLimitsInstanceDim.Items["+ i +"].ResourceTypeCode");
				dataLimit.AuditStatus = _ctx.IntegerValue("DescribeDataLimitsInstanceDim.Items["+ i +"].AuditStatus");
				dataLimit.LogStoreDay = _ctx.IntegerValue("DescribeDataLimitsInstanceDim.Items["+ i +"].LogStoreDay");
				dataLimit.Enable = _ctx.IntegerValue("DescribeDataLimitsInstanceDim.Items["+ i +"].Enable");
				dataLimit.AutoScan = _ctx.IntegerValue("DescribeDataLimitsInstanceDim.Items["+ i +"].AutoScan");
				dataLimit.EngineType = _ctx.StringValue("DescribeDataLimitsInstanceDim.Items["+ i +"].EngineType");
				dataLimit.ProcessStatus = _ctx.IntegerValue("DescribeDataLimitsInstanceDim.Items["+ i +"].ProcessStatus");
				dataLimit.ProcessTotalCount = _ctx.IntegerValue("DescribeDataLimitsInstanceDim.Items["+ i +"].ProcessTotalCount");
				dataLimit.TotalCount = _ctx.IntegerValue("DescribeDataLimitsInstanceDim.Items["+ i +"].TotalCount");
				dataLimit.LastFinishedTime = _ctx.LongValue("DescribeDataLimitsInstanceDim.Items["+ i +"].LastFinishedTime");
				dataLimit.ErrorCode = _ctx.StringValue("DescribeDataLimitsInstanceDim.Items["+ i +"].ErrorCode");
				dataLimit.ErrorMessage = _ctx.StringValue("DescribeDataLimitsInstanceDim.Items["+ i +"].ErrorMessage");
				dataLimit.Port = _ctx.IntegerValue("DescribeDataLimitsInstanceDim.Items["+ i +"].Port");
				dataLimit.DbVersion = _ctx.StringValue("DescribeDataLimitsInstanceDim.Items["+ i +"].DbVersion");
				dataLimit.SupportDatamask = _ctx.BooleanValue("DescribeDataLimitsInstanceDim.Items["+ i +"].SupportDatamask");
				dataLimit.SupportScan = _ctx.BooleanValue("DescribeDataLimitsInstanceDim.Items["+ i +"].SupportScan");
				dataLimit.SupportAudit = _ctx.BooleanValue("DescribeDataLimitsInstanceDim.Items["+ i +"].SupportAudit");
				dataLimit.DatamaskStatus = _ctx.IntegerValue("DescribeDataLimitsInstanceDim.Items["+ i +"].DatamaskStatus");
				dataLimit.SamplingSize = _ctx.IntegerValue("DescribeDataLimitsInstanceDim.Items["+ i +"].SamplingSize");
				dataLimit.NextStartTime = _ctx.LongValue("DescribeDataLimitsInstanceDim.Items["+ i +"].NextStartTime");
				dataLimit.SupportOcr = _ctx.BooleanValue("DescribeDataLimitsInstanceDim.Items["+ i +"].SupportOcr");
				dataLimit.OcrStatus = _ctx.IntegerValue("DescribeDataLimitsInstanceDim.Items["+ i +"].OcrStatus");
				dataLimit.AgentId = _ctx.StringValue("DescribeDataLimitsInstanceDim.Items["+ i +"].AgentId");
				dataLimit.AgentState = _ctx.IntegerValue("DescribeDataLimitsInstanceDim.Items["+ i +"].AgentState");
				dataLimit.SupportAgentInstall = _ctx.BooleanValue("DescribeDataLimitsInstanceDim.Items["+ i +"].SupportAgentInstall");
				dataLimit.InstanceDescription = _ctx.StringValue("DescribeDataLimitsInstanceDim.Items["+ i +"].InstanceDescription");

				List<DescribeDataLimitsInstanceDimResponse.DescribeDataLimitsInstanceDim_DataLimit.DescribeDataLimitsInstanceDim_DataLimitListInner> dataLimit_dataLimitList = new List<DescribeDataLimitsInstanceDimResponse.DescribeDataLimitsInstanceDim_DataLimit.DescribeDataLimitsInstanceDim_DataLimitListInner>();
				for (int j = 0; j < _ctx.Length("DescribeDataLimitsInstanceDim.Items["+ i +"].DataLimitList.Length"); j++) {
					DescribeDataLimitsInstanceDimResponse.DescribeDataLimitsInstanceDim_DataLimit.DescribeDataLimitsInstanceDim_DataLimitListInner dataLimitListInner = new DescribeDataLimitsInstanceDimResponse.DescribeDataLimitsInstanceDim_DataLimit.DescribeDataLimitsInstanceDim_DataLimitListInner();
					dataLimitListInner.RegionId = _ctx.StringValue("DescribeDataLimitsInstanceDim.Items["+ i +"].DataLimitList["+ j +"].RegionId");
					dataLimitListInner.LocalName = _ctx.StringValue("DescribeDataLimitsInstanceDim.Items["+ i +"].DataLimitList["+ j +"].LocalName");
					dataLimitListInner.ParentId = _ctx.StringValue("DescribeDataLimitsInstanceDim.Items["+ i +"].DataLimitList["+ j +"].ParentId");
					dataLimitListInner.Id = _ctx.LongValue("DescribeDataLimitsInstanceDim.Items["+ i +"].DataLimitList["+ j +"].Id");
					dataLimitListInner.UserName = _ctx.StringValue("DescribeDataLimitsInstanceDim.Items["+ i +"].DataLimitList["+ j +"].UserName");
					dataLimitListInner.GmtCreate = _ctx.LongValue("DescribeDataLimitsInstanceDim.Items["+ i +"].DataLimitList["+ j +"].GmtCreate");
					dataLimitListInner.Connector = _ctx.StringValue("DescribeDataLimitsInstanceDim.Items["+ i +"].DataLimitList["+ j +"].Connector");
					dataLimitListInner.CheckStatus = _ctx.IntegerValue("DescribeDataLimitsInstanceDim.Items["+ i +"].DataLimitList["+ j +"].CheckStatus");
					dataLimitListInner.CheckStatusName = _ctx.StringValue("DescribeDataLimitsInstanceDim.Items["+ i +"].DataLimitList["+ j +"].CheckStatusName");
					dataLimitListInner.ResourceType = _ctx.LongValue("DescribeDataLimitsInstanceDim.Items["+ i +"].DataLimitList["+ j +"].ResourceType");
					dataLimitListInner.ResourceTypeCode = _ctx.StringValue("DescribeDataLimitsInstanceDim.Items["+ i +"].DataLimitList["+ j +"].ResourceTypeCode");
					dataLimitListInner.AuditStatus = _ctx.IntegerValue("DescribeDataLimitsInstanceDim.Items["+ i +"].DataLimitList["+ j +"].AuditStatus");
					dataLimitListInner.LogStoreDay = _ctx.IntegerValue("DescribeDataLimitsInstanceDim.Items["+ i +"].DataLimitList["+ j +"].LogStoreDay");
					dataLimitListInner.Enable = _ctx.IntegerValue("DescribeDataLimitsInstanceDim.Items["+ i +"].DataLimitList["+ j +"].Enable");
					dataLimitListInner.AutoScan = _ctx.IntegerValue("DescribeDataLimitsInstanceDim.Items["+ i +"].DataLimitList["+ j +"].AutoScan");
					dataLimitListInner.EngineType = _ctx.StringValue("DescribeDataLimitsInstanceDim.Items["+ i +"].DataLimitList["+ j +"].EngineType");
					dataLimitListInner.ProcessStatus = _ctx.IntegerValue("DescribeDataLimitsInstanceDim.Items["+ i +"].DataLimitList["+ j +"].ProcessStatus");
					dataLimitListInner.ProcessTotalCount = _ctx.IntegerValue("DescribeDataLimitsInstanceDim.Items["+ i +"].DataLimitList["+ j +"].ProcessTotalCount");
					dataLimitListInner.TotalCount = _ctx.IntegerValue("DescribeDataLimitsInstanceDim.Items["+ i +"].DataLimitList["+ j +"].TotalCount");
					dataLimitListInner.LastFinishedTime = _ctx.LongValue("DescribeDataLimitsInstanceDim.Items["+ i +"].DataLimitList["+ j +"].LastFinishedTime");
					dataLimitListInner.ErrorCode = _ctx.StringValue("DescribeDataLimitsInstanceDim.Items["+ i +"].DataLimitList["+ j +"].ErrorCode");
					dataLimitListInner.ErrorMessage = _ctx.StringValue("DescribeDataLimitsInstanceDim.Items["+ i +"].DataLimitList["+ j +"].ErrorMessage");
					dataLimitListInner.Port = _ctx.IntegerValue("DescribeDataLimitsInstanceDim.Items["+ i +"].DataLimitList["+ j +"].Port");
					dataLimitListInner.DbVersion = _ctx.StringValue("DescribeDataLimitsInstanceDim.Items["+ i +"].DataLimitList["+ j +"].DbVersion");
					dataLimitListInner.SupportDatamask = _ctx.BooleanValue("DescribeDataLimitsInstanceDim.Items["+ i +"].DataLimitList["+ j +"].SupportDatamask");
					dataLimitListInner.SupportScan = _ctx.BooleanValue("DescribeDataLimitsInstanceDim.Items["+ i +"].DataLimitList["+ j +"].SupportScan");
					dataLimitListInner.SupportAudit = _ctx.BooleanValue("DescribeDataLimitsInstanceDim.Items["+ i +"].DataLimitList["+ j +"].SupportAudit");
					dataLimitListInner.DatamaskStatus = _ctx.IntegerValue("DescribeDataLimitsInstanceDim.Items["+ i +"].DataLimitList["+ j +"].DatamaskStatus");
					dataLimitListInner.SamplingSize = _ctx.IntegerValue("DescribeDataLimitsInstanceDim.Items["+ i +"].DataLimitList["+ j +"].SamplingSize");
					dataLimitListInner.NextStartTime = _ctx.LongValue("DescribeDataLimitsInstanceDim.Items["+ i +"].DataLimitList["+ j +"].NextStartTime");
					dataLimitListInner.SupportOcr = _ctx.BooleanValue("DescribeDataLimitsInstanceDim.Items["+ i +"].DataLimitList["+ j +"].SupportOcr");
					dataLimitListInner.OcrStatus = _ctx.IntegerValue("DescribeDataLimitsInstanceDim.Items["+ i +"].DataLimitList["+ j +"].OcrStatus");
					dataLimitListInner.AgentId = _ctx.StringValue("DescribeDataLimitsInstanceDim.Items["+ i +"].DataLimitList["+ j +"].AgentId");
					dataLimitListInner.AgentState = _ctx.IntegerValue("DescribeDataLimitsInstanceDim.Items["+ i +"].DataLimitList["+ j +"].AgentState");
					dataLimitListInner.SupportAgentInstall = _ctx.BooleanValue("DescribeDataLimitsInstanceDim.Items["+ i +"].DataLimitList["+ j +"].SupportAgentInstall");
					dataLimitListInner.AutoCreateAccount = _ctx.BooleanValue("DescribeDataLimitsInstanceDim.Items["+ i +"].DataLimitList["+ j +"].AutoCreateAccount");
					dataLimitListInner.EventStatus = _ctx.IntegerValue("DescribeDataLimitsInstanceDim.Items["+ i +"].DataLimitList["+ j +"].EventStatus");
					dataLimitListInner.SupportEvent = _ctx.BooleanValue("DescribeDataLimitsInstanceDim.Items["+ i +"].DataLimitList["+ j +"].SupportEvent");

					dataLimit_dataLimitList.Add(dataLimitListInner);
				}
				dataLimit.DataLimitList = dataLimit_dataLimitList;

				describeDataLimitsInstanceDimResponse_items.Add(dataLimit);
			}
			describeDataLimitsInstanceDimResponse.Items = describeDataLimitsInstanceDimResponse_items;
        
			return describeDataLimitsInstanceDimResponse;
        }
    }
}
