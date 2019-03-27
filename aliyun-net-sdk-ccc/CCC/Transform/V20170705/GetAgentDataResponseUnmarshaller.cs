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
using Aliyun.Acs.CCC.Model.V20170705;

namespace Aliyun.Acs.CCC.Transform.V20170705
{
    public class GetAgentDataResponseUnmarshaller
    {
        public static GetAgentDataResponse Unmarshall(UnmarshallerContext context)
        {
			GetAgentDataResponse getAgentDataResponse = new GetAgentDataResponse();

			getAgentDataResponse.HttpResponse = context.HttpResponse;
			getAgentDataResponse.RequestId = context.StringValue("GetAgentData.RequestId");
			getAgentDataResponse.Success = context.BooleanValue("GetAgentData.Success");
			getAgentDataResponse.Code = context.StringValue("GetAgentData.Code");
			getAgentDataResponse.Message = context.StringValue("GetAgentData.Message");
			getAgentDataResponse.HttpStatusCode = context.IntegerValue("GetAgentData.HttpStatusCode");

			GetAgentDataResponse.GetAgentData_DataList dataList = new GetAgentDataResponse.GetAgentData_DataList();
			dataList.TotalCount = context.IntegerValue("GetAgentData.DataList.TotalCount");
			dataList.PageNumber = context.IntegerValue("GetAgentData.DataList.PageNumber");
			dataList.PageSize = context.IntegerValue("GetAgentData.DataList.PageSize");

			List<GetAgentDataResponse.GetAgentData_DataList.GetAgentData_GenerateAgentStatistic> dataList_list = new List<GetAgentDataResponse.GetAgentData_DataList.GetAgentData_GenerateAgentStatistic>();
			for (int i = 0; i < context.Length("GetAgentData.DataList.List.Length"); i++) {
				GetAgentDataResponse.GetAgentData_DataList.GetAgentData_GenerateAgentStatistic generateAgentStatistic = new GetAgentDataResponse.GetAgentData_DataList.GetAgentData_GenerateAgentStatistic();
				generateAgentStatistic.AgentId = context.StringValue("GetAgentData.DataList.List["+ i +"].AgentId");
				generateAgentStatistic.LoginName = context.StringValue("GetAgentData.DataList.List["+ i +"].LoginName");
				generateAgentStatistic.AgentName = context.StringValue("GetAgentData.DataList.List["+ i +"].AgentName");
				generateAgentStatistic.SkillGroupIds = context.StringValue("GetAgentData.DataList.List["+ i +"].SkillGroupIds");
				generateAgentStatistic.SkillGroupNames = context.StringValue("GetAgentData.DataList.List["+ i +"].SkillGroupNames");
				generateAgentStatistic.InstanceId = context.StringValue("GetAgentData.DataList.List["+ i +"].InstanceId");
				generateAgentStatistic.RecordDate = context.StringValue("GetAgentData.DataList.List["+ i +"].RecordDate");
				generateAgentStatistic.TotalLoggedInTime = context.LongValue("GetAgentData.DataList.List["+ i +"].TotalLoggedInTime");
				generateAgentStatistic.TotalBreakTime = context.LongValue("GetAgentData.DataList.List["+ i +"].TotalBreakTime");
				generateAgentStatistic.OccupancyRate = context.FloatValue("GetAgentData.DataList.List["+ i +"].OccupancyRate");
				generateAgentStatistic.TotalReadyTime = context.LongValue("GetAgentData.DataList.List["+ i +"].TotalReadyTime");
				generateAgentStatistic.MaxReadyTime = context.LongValue("GetAgentData.DataList.List["+ i +"].MaxReadyTime");
				generateAgentStatistic.AverageReadyTime = context.LongValue("GetAgentData.DataList.List["+ i +"].AverageReadyTime");

				GetAgentDataResponse.GetAgentData_DataList.GetAgentData_GenerateAgentStatistic.GetAgentData_Inbound inbound = new GetAgentDataResponse.GetAgentData_DataList.GetAgentData_GenerateAgentStatistic.GetAgentData_Inbound();
				inbound.TotalTalkTime = context.LongValue("GetAgentData.DataList.List["+ i +"].Inbound.TotalTalkTime");
				inbound.MaxTalkTime = context.LongValue("GetAgentData.DataList.List["+ i +"].Inbound.MaxTalkTime");
				inbound.AverageTalkTime = context.LongValue("GetAgentData.DataList.List["+ i +"].Inbound.AverageTalkTime");
				inbound.TotalHoldTime = context.LongValue("GetAgentData.DataList.List["+ i +"].Inbound.TotalHoldTime");
				inbound.MaxHoldTime = context.LongValue("GetAgentData.DataList.List["+ i +"].Inbound.MaxHoldTime");
				inbound.AverageHoldTime = context.LongValue("GetAgentData.DataList.List["+ i +"].Inbound.AverageHoldTime");
				inbound.TotalWorkTime = context.LongValue("GetAgentData.DataList.List["+ i +"].Inbound.TotalWorkTime");
				inbound.MaxWorkTime = context.LongValue("GetAgentData.DataList.List["+ i +"].Inbound.MaxWorkTime");
				inbound.AverageWorkTime = context.LongValue("GetAgentData.DataList.List["+ i +"].Inbound.AverageWorkTime");
				inbound.SatisfactionSurveysOffered = context.LongValue("GetAgentData.DataList.List["+ i +"].Inbound.SatisfactionSurveysOffered");
				inbound.SatisfactionSurveysResponded = context.LongValue("GetAgentData.DataList.List["+ i +"].Inbound.SatisfactionSurveysResponded");
				inbound.SatisfactionIndex = context.FloatValue("GetAgentData.DataList.List["+ i +"].Inbound.SatisfactionIndex");
				inbound.CallsOffered = context.LongValue("GetAgentData.DataList.List["+ i +"].Inbound.CallsOffered");
				inbound.CallsHandled = context.LongValue("GetAgentData.DataList.List["+ i +"].Inbound.CallsHandled");
				inbound.HandleRate = context.FloatValue("GetAgentData.DataList.List["+ i +"].Inbound.HandleRate");
				inbound.TotalRingTime = context.LongValue("GetAgentData.DataList.List["+ i +"].Inbound.TotalRingTime");
				inbound.MaxRingTime = context.LongValue("GetAgentData.DataList.List["+ i +"].Inbound.MaxRingTime");
				inbound.AverageRingTime = context.LongValue("GetAgentData.DataList.List["+ i +"].Inbound.AverageRingTime");
				generateAgentStatistic.Inbound = inbound;

				GetAgentDataResponse.GetAgentData_DataList.GetAgentData_GenerateAgentStatistic.GetAgentData_Outbound outbound = new GetAgentDataResponse.GetAgentData_DataList.GetAgentData_GenerateAgentStatistic.GetAgentData_Outbound();
				outbound.TotalTalkTime = context.LongValue("GetAgentData.DataList.List["+ i +"].Outbound.TotalTalkTime");
				outbound.MaxTalkTime = context.LongValue("GetAgentData.DataList.List["+ i +"].Outbound.MaxTalkTime");
				outbound.AverageTalkTime = context.LongValue("GetAgentData.DataList.List["+ i +"].Outbound.AverageTalkTime");
				outbound.TotalHoldTime = context.LongValue("GetAgentData.DataList.List["+ i +"].Outbound.TotalHoldTime");
				outbound.MaxHoldTime = context.LongValue("GetAgentData.DataList.List["+ i +"].Outbound.MaxHoldTime");
				outbound.AverageHoldTime = context.LongValue("GetAgentData.DataList.List["+ i +"].Outbound.AverageHoldTime");
				outbound.TotalWorkTime = context.LongValue("GetAgentData.DataList.List["+ i +"].Outbound.TotalWorkTime");
				outbound.MaxWorkTime = context.LongValue("GetAgentData.DataList.List["+ i +"].Outbound.MaxWorkTime");
				outbound.AverageWorkTime = context.LongValue("GetAgentData.DataList.List["+ i +"].Outbound.AverageWorkTime");
				outbound.SatisfactionSurveysOffered = context.LongValue("GetAgentData.DataList.List["+ i +"].Outbound.SatisfactionSurveysOffered");
				outbound.SatisfactionSurveysResponded = context.LongValue("GetAgentData.DataList.List["+ i +"].Outbound.SatisfactionSurveysResponded");
				outbound.SatisfactionIndex = context.FloatValue("GetAgentData.DataList.List["+ i +"].Outbound.SatisfactionIndex");
				outbound.CallsDialed = context.LongValue("GetAgentData.DataList.List["+ i +"].Outbound.CallsDialed");
				outbound.CallsAnswered = context.LongValue("GetAgentData.DataList.List["+ i +"].Outbound.CallsAnswered");
				outbound.AnswerRate = context.FloatValue("GetAgentData.DataList.List["+ i +"].Outbound.AnswerRate");
				outbound.TotalDialingTime = context.LongValue("GetAgentData.DataList.List["+ i +"].Outbound.TotalDialingTime");
				outbound.TotalDialingTime1 = context.LongValue("GetAgentData.DataList.List["+ i +"].Outbound.TotalDialingTime");
				outbound.MaxDialingTime = context.LongValue("GetAgentData.DataList.List["+ i +"].Outbound.MaxDialingTime");
				outbound.AverageDialingTime = context.LongValue("GetAgentData.DataList.List["+ i +"].Outbound.AverageDialingTime");
				generateAgentStatistic.Outbound = outbound;

				GetAgentDataResponse.GetAgentData_DataList.GetAgentData_GenerateAgentStatistic.GetAgentData_Overall overall = new GetAgentDataResponse.GetAgentData_DataList.GetAgentData_GenerateAgentStatistic.GetAgentData_Overall();
				overall.TotalTalkTime = context.LongValue("GetAgentData.DataList.List["+ i +"].Overall.TotalTalkTime");
				overall.MaxTalkTime = context.LongValue("GetAgentData.DataList.List["+ i +"].Overall.MaxTalkTime");
				overall.AverageTalkTime = context.LongValue("GetAgentData.DataList.List["+ i +"].Overall.AverageTalkTime");
				overall.TotalHoldTime = context.LongValue("GetAgentData.DataList.List["+ i +"].Overall.TotalHoldTime");
				overall.MaxHoldTime = context.LongValue("GetAgentData.DataList.List["+ i +"].Overall.MaxHoldTime");
				overall.AverageHoldTime = context.LongValue("GetAgentData.DataList.List["+ i +"].Overall.AverageHoldTime");
				overall.TotalWorkTime = context.LongValue("GetAgentData.DataList.List["+ i +"].Overall.TotalWorkTime");
				overall.MaxWorkTime = context.LongValue("GetAgentData.DataList.List["+ i +"].Overall.MaxWorkTime");
				overall.AverageWorkTime = context.LongValue("GetAgentData.DataList.List["+ i +"].Overall.AverageWorkTime");
				overall.SatisfactionSurveysOffered = context.LongValue("GetAgentData.DataList.List["+ i +"].Overall.SatisfactionSurveysOffered");
				overall.SatisfactionSurveysResponded = context.LongValue("GetAgentData.DataList.List["+ i +"].Overall.SatisfactionSurveysResponded");
				overall.SatisfactionIndex = context.FloatValue("GetAgentData.DataList.List["+ i +"].Overall.SatisfactionIndex");
				overall.TotalCalls = context.LongValue("GetAgentData.DataList.List["+ i +"].Overall.TotalCalls");
				generateAgentStatistic.Overall = overall;

				dataList_list.Add(generateAgentStatistic);
			}
			dataList.List = dataList_list;
			getAgentDataResponse.DataList = dataList;
        
			return getAgentDataResponse;
        }
    }
}
