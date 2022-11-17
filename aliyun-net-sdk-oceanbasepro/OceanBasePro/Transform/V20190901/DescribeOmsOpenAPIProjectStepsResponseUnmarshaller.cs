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
    public class DescribeOmsOpenAPIProjectStepsResponseUnmarshaller
    {
        public static DescribeOmsOpenAPIProjectStepsResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeOmsOpenAPIProjectStepsResponse describeOmsOpenAPIProjectStepsResponse = new DescribeOmsOpenAPIProjectStepsResponse();

			describeOmsOpenAPIProjectStepsResponse.HttpResponse = _ctx.HttpResponse;
			describeOmsOpenAPIProjectStepsResponse.Success = _ctx.BooleanValue("DescribeOmsOpenAPIProjectSteps.Success");
			describeOmsOpenAPIProjectStepsResponse.Code = _ctx.StringValue("DescribeOmsOpenAPIProjectSteps.Code");
			describeOmsOpenAPIProjectStepsResponse.Message = _ctx.StringValue("DescribeOmsOpenAPIProjectSteps.Message");
			describeOmsOpenAPIProjectStepsResponse.Advice = _ctx.StringValue("DescribeOmsOpenAPIProjectSteps.Advice");
			describeOmsOpenAPIProjectStepsResponse.RequestId = _ctx.StringValue("DescribeOmsOpenAPIProjectSteps.RequestId");
			describeOmsOpenAPIProjectStepsResponse.PageNumber = _ctx.IntegerValue("DescribeOmsOpenAPIProjectSteps.PageNumber");
			describeOmsOpenAPIProjectStepsResponse.PageSize = _ctx.IntegerValue("DescribeOmsOpenAPIProjectSteps.PageSize");
			describeOmsOpenAPIProjectStepsResponse.TotalCount = _ctx.LongValue("DescribeOmsOpenAPIProjectSteps.TotalCount");
			describeOmsOpenAPIProjectStepsResponse.Cost = _ctx.StringValue("DescribeOmsOpenAPIProjectSteps.Cost");

			DescribeOmsOpenAPIProjectStepsResponse.DescribeOmsOpenAPIProjectSteps_ErrorDetail1 errorDetail1 = new DescribeOmsOpenAPIProjectStepsResponse.DescribeOmsOpenAPIProjectSteps_ErrorDetail1();
			errorDetail1.Code = _ctx.StringValue("DescribeOmsOpenAPIProjectSteps.ErrorDetail.Code");
			errorDetail1.Level = _ctx.StringValue("DescribeOmsOpenAPIProjectSteps.ErrorDetail.Level");
			errorDetail1.Message = _ctx.StringValue("DescribeOmsOpenAPIProjectSteps.ErrorDetail.Message");
			errorDetail1.Proposal = _ctx.StringValue("DescribeOmsOpenAPIProjectSteps.ErrorDetail.Proposal");
			describeOmsOpenAPIProjectStepsResponse.ErrorDetail1 = errorDetail1;

			List<DescribeOmsOpenAPIProjectStepsResponse.DescribeOmsOpenAPIProjectSteps_DataItem> describeOmsOpenAPIProjectStepsResponse_data = new List<DescribeOmsOpenAPIProjectStepsResponse.DescribeOmsOpenAPIProjectSteps_DataItem>();
			for (int i = 0; i < _ctx.Length("DescribeOmsOpenAPIProjectSteps.Data.Length"); i++) {
				DescribeOmsOpenAPIProjectStepsResponse.DescribeOmsOpenAPIProjectSteps_DataItem dataItem = new DescribeOmsOpenAPIProjectStepsResponse.DescribeOmsOpenAPIProjectSteps_DataItem();
				dataItem.StepOrder = _ctx.IntegerValue("DescribeOmsOpenAPIProjectSteps.Data["+ i +"].StepOrder");
				dataItem.StepName = _ctx.StringValue("DescribeOmsOpenAPIProjectSteps.Data["+ i +"].StepName");
				dataItem.StepDescription = _ctx.StringValue("DescribeOmsOpenAPIProjectSteps.Data["+ i +"].StepDescription");
				dataItem.StepStatus = _ctx.StringValue("DescribeOmsOpenAPIProjectSteps.Data["+ i +"].StepStatus");
				dataItem.StepProgress = _ctx.IntegerValue("DescribeOmsOpenAPIProjectSteps.Data["+ i +"].StepProgress");
				dataItem.StartTime = _ctx.StringValue("DescribeOmsOpenAPIProjectSteps.Data["+ i +"].StartTime");
				dataItem.EstimatedRemainingSeconds = _ctx.LongValue("DescribeOmsOpenAPIProjectSteps.Data["+ i +"].EstimatedRemainingSeconds");
				dataItem.FinishTime = _ctx.StringValue("DescribeOmsOpenAPIProjectSteps.Data["+ i +"].FinishTime");
				dataItem.Interactive = _ctx.BooleanValue("DescribeOmsOpenAPIProjectSteps.Data["+ i +"].Interactive");

				DescribeOmsOpenAPIProjectStepsResponse.DescribeOmsOpenAPIProjectSteps_DataItem.DescribeOmsOpenAPIProjectSteps_StepInfo stepInfo = new DescribeOmsOpenAPIProjectStepsResponse.DescribeOmsOpenAPIProjectSteps_DataItem.DescribeOmsOpenAPIProjectSteps_StepInfo();
				stepInfo.JobId = _ctx.StringValue("DescribeOmsOpenAPIProjectSteps.Data["+ i +"].StepInfo.JobId");
				stepInfo.IncrTimestampCheckpoint = _ctx.LongValue("DescribeOmsOpenAPIProjectSteps.Data["+ i +"].StepInfo.IncrTimestampCheckpoint");
				stepInfo.Checkpoint = _ctx.StringValue("DescribeOmsOpenAPIProjectSteps.Data["+ i +"].StepInfo.Checkpoint");
				stepInfo.Gmt = _ctx.LongValue("DescribeOmsOpenAPIProjectSteps.Data["+ i +"].StepInfo.Gmt");
				stepInfo.Validated = _ctx.BooleanValue("DescribeOmsOpenAPIProjectSteps.Data["+ i +"].StepInfo.Validated");
				stepInfo.Skipped = _ctx.BooleanValue("DescribeOmsOpenAPIProjectSteps.Data["+ i +"].StepInfo.Skipped");
				stepInfo.Inconsistencies = _ctx.LongValue("DescribeOmsOpenAPIProjectSteps.Data["+ i +"].StepInfo.Inconsistencies");
				stepInfo.DeployId = _ctx.StringValue("DescribeOmsOpenAPIProjectSteps.Data["+ i +"].StepInfo.DeployId");
				stepInfo.ProcessedRecords = _ctx.LongValue("DescribeOmsOpenAPIProjectSteps.Data["+ i +"].StepInfo.ProcessedRecords");
				stepInfo.Capacity = _ctx.LongValue("DescribeOmsOpenAPIProjectSteps.Data["+ i +"].StepInfo.Capacity");
				stepInfo.SrcRps = _ctx.LongValue("DescribeOmsOpenAPIProjectSteps.Data["+ i +"].StepInfo.SrcRps");
				stepInfo.SrcRt = _ctx.LongValue("DescribeOmsOpenAPIProjectSteps.Data["+ i +"].StepInfo.SrcRt");
				stepInfo.SrcIops = _ctx.LongValue("DescribeOmsOpenAPIProjectSteps.Data["+ i +"].StepInfo.SrcIops");
				stepInfo.DstRps = _ctx.LongValue("DescribeOmsOpenAPIProjectSteps.Data["+ i +"].StepInfo.DstRps");
				stepInfo.DstRt = _ctx.LongValue("DescribeOmsOpenAPIProjectSteps.Data["+ i +"].StepInfo.DstRt");
				stepInfo.DstIops = _ctx.LongValue("DescribeOmsOpenAPIProjectSteps.Data["+ i +"].StepInfo.DstIops");
				stepInfo.SrcRpsRef = _ctx.LongValue("DescribeOmsOpenAPIProjectSteps.Data["+ i +"].StepInfo.SrcRpsRef");
				stepInfo.SrcRtRef = _ctx.LongValue("DescribeOmsOpenAPIProjectSteps.Data["+ i +"].StepInfo.SrcRtRef");
				stepInfo.DstRpsRef = _ctx.LongValue("DescribeOmsOpenAPIProjectSteps.Data["+ i +"].StepInfo.DstRpsRef");
				stepInfo.DstRtRef = _ctx.LongValue("DescribeOmsOpenAPIProjectSteps.Data["+ i +"].StepInfo.DstRtRef");
				stepInfo.SrcIopsRef = _ctx.LongValue("DescribeOmsOpenAPIProjectSteps.Data["+ i +"].StepInfo.SrcIopsRef");

				DescribeOmsOpenAPIProjectStepsResponse.DescribeOmsOpenAPIProjectSteps_DataItem.DescribeOmsOpenAPIProjectSteps_StepInfo.DescribeOmsOpenAPIProjectSteps_ConnectorFullProgressOverview connectorFullProgressOverview = new DescribeOmsOpenAPIProjectStepsResponse.DescribeOmsOpenAPIProjectSteps_DataItem.DescribeOmsOpenAPIProjectSteps_StepInfo.DescribeOmsOpenAPIProjectSteps_ConnectorFullProgressOverview();
				connectorFullProgressOverview.EstimatedTotalCount = _ctx.LongValue("DescribeOmsOpenAPIProjectSteps.Data["+ i +"].StepInfo.ConnectorFullProgressOverview.EstimatedTotalCount");
				connectorFullProgressOverview.FinishedCount = _ctx.LongValue("DescribeOmsOpenAPIProjectSteps.Data["+ i +"].StepInfo.ConnectorFullProgressOverview.FinishedCount");
				connectorFullProgressOverview.Progress = _ctx.IntegerValue("DescribeOmsOpenAPIProjectSteps.Data["+ i +"].StepInfo.ConnectorFullProgressOverview.Progress");
				connectorFullProgressOverview.EstimatedRemainingTimeOfSec = _ctx.LongValue("DescribeOmsOpenAPIProjectSteps.Data["+ i +"].StepInfo.ConnectorFullProgressOverview.EstimatedRemainingTimeOfSec");
				stepInfo.ConnectorFullProgressOverview = connectorFullProgressOverview;
				dataItem.StepInfo = stepInfo;

				DescribeOmsOpenAPIProjectStepsResponse.DescribeOmsOpenAPIProjectSteps_DataItem.DescribeOmsOpenAPIProjectSteps_ExtraInfo extraInfo = new DescribeOmsOpenAPIProjectStepsResponse.DescribeOmsOpenAPIProjectSteps_DataItem.DescribeOmsOpenAPIProjectSteps_ExtraInfo();
				extraInfo.ErrorCode = _ctx.StringValue("DescribeOmsOpenAPIProjectSteps.Data["+ i +"].ExtraInfo.ErrorCode");
				extraInfo.ErrorMsg = _ctx.StringValue("DescribeOmsOpenAPIProjectSteps.Data["+ i +"].ExtraInfo.ErrorMsg");
				extraInfo.ErrorParam = _ctx.StringValue("DescribeOmsOpenAPIProjectSteps.Data["+ i +"].ExtraInfo.ErrorParam");
				extraInfo.FailedTime = _ctx.StringValue("DescribeOmsOpenAPIProjectSteps.Data["+ i +"].ExtraInfo.FailedTime");

				List<DescribeOmsOpenAPIProjectStepsResponse.DescribeOmsOpenAPIProjectSteps_DataItem.DescribeOmsOpenAPIProjectSteps_ExtraInfo.DescribeOmsOpenAPIProjectSteps_ErrorDetail> extraInfo_errorDetails = new List<DescribeOmsOpenAPIProjectStepsResponse.DescribeOmsOpenAPIProjectSteps_DataItem.DescribeOmsOpenAPIProjectSteps_ExtraInfo.DescribeOmsOpenAPIProjectSteps_ErrorDetail>();
				for (int j = 0; j < _ctx.Length("DescribeOmsOpenAPIProjectSteps.Data["+ i +"].ExtraInfo.ErrorDetails.Length"); j++) {
					DescribeOmsOpenAPIProjectStepsResponse.DescribeOmsOpenAPIProjectSteps_DataItem.DescribeOmsOpenAPIProjectSteps_ExtraInfo.DescribeOmsOpenAPIProjectSteps_ErrorDetail errorDetail = new DescribeOmsOpenAPIProjectStepsResponse.DescribeOmsOpenAPIProjectSteps_DataItem.DescribeOmsOpenAPIProjectSteps_ExtraInfo.DescribeOmsOpenAPIProjectSteps_ErrorDetail();
					errorDetail.Code = _ctx.StringValue("DescribeOmsOpenAPIProjectSteps.Data["+ i +"].ExtraInfo.ErrorDetails["+ j +"].Code");
					errorDetail.Level = _ctx.StringValue("DescribeOmsOpenAPIProjectSteps.Data["+ i +"].ExtraInfo.ErrorDetails["+ j +"].Level");
					errorDetail.Message = _ctx.StringValue("DescribeOmsOpenAPIProjectSteps.Data["+ i +"].ExtraInfo.ErrorDetails["+ j +"].Message");
					errorDetail.Proposal = _ctx.StringValue("DescribeOmsOpenAPIProjectSteps.Data["+ i +"].ExtraInfo.ErrorDetails["+ j +"].Proposal");

					extraInfo_errorDetails.Add(errorDetail);
				}
				extraInfo.ErrorDetails = extraInfo_errorDetails;
				dataItem.ExtraInfo = extraInfo;

				describeOmsOpenAPIProjectStepsResponse_data.Add(dataItem);
			}
			describeOmsOpenAPIProjectStepsResponse.Data = describeOmsOpenAPIProjectStepsResponse_data;
        
			return describeOmsOpenAPIProjectStepsResponse;
        }
    }
}
