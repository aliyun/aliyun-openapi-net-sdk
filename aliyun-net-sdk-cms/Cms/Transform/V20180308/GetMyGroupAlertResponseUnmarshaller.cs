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
using Aliyun.Acs.Cms.Model.V20180308;

namespace Aliyun.Acs.Cms.Transform.V20180308
{
    public class GetMyGroupAlertResponseUnmarshaller
    {
        public static GetMyGroupAlertResponse Unmarshall(UnmarshallerContext context)
        {
			GetMyGroupAlertResponse getMyGroupAlertResponse = new GetMyGroupAlertResponse();

			getMyGroupAlertResponse.HttpResponse = context.HttpResponse;
			getMyGroupAlertResponse.RequestId = context.StringValue("GetMyGroupAlert.RequestId");
			getMyGroupAlertResponse.Success = context.BooleanValue("GetMyGroupAlert.Success");
			getMyGroupAlertResponse.ErrorCode = context.IntegerValue("GetMyGroupAlert.ErrorCode");
			getMyGroupAlertResponse.ErrorMessage = context.StringValue("GetMyGroupAlert.ErrorMessage");

			GetMyGroupAlertResponse.GetMyGroupAlert_GroupAlert groupAlert = new GetMyGroupAlertResponse.GetMyGroupAlert_GroupAlert();
			groupAlert.GroupId = context.StringValue("GetMyGroupAlert.GroupAlert.GroupId");
			groupAlert.AlertName = context.StringValue("GetMyGroupAlert.GroupAlert.AlertName");
			groupAlert.DisplayName = context.StringValue("GetMyGroupAlert.GroupAlert.DisplayName");
			groupAlert.Subject = context.StringValue("GetMyGroupAlert.GroupAlert.Subject");
			groupAlert.Webhook = context.StringValue("GetMyGroupAlert.GroupAlert.Webhook");
			groupAlert.Category = context.StringValue("GetMyGroupAlert.GroupAlert.Category");
			groupAlert._Namespace = context.StringValue("GetMyGroupAlert.GroupAlert.Namespace");
			groupAlert.MetricName = context.StringValue("GetMyGroupAlert.GroupAlert.MetricName");
			groupAlert.Period = context.IntegerValue("GetMyGroupAlert.GroupAlert.Period");
			groupAlert.State = context.StringValue("GetMyGroupAlert.GroupAlert.State");
			groupAlert.Description = context.StringValue("GetMyGroupAlert.GroupAlert.Description");
			groupAlert.Enable = context.BooleanValue("GetMyGroupAlert.GroupAlert.Enable");
			groupAlert.SilenceTime = context.IntegerValue("GetMyGroupAlert.GroupAlert.SilenceTime");
			groupAlert.EnableEndTime = context.StringValue("GetMyGroupAlert.GroupAlert.EnableEndTime");
			groupAlert.EnableStartTime = context.StringValue("GetMyGroupAlert.GroupAlert.EnableStartTime");
			groupAlert.Selector = context.StringValue("GetMyGroupAlert.GroupAlert.Selector");

			GetMyGroupAlertResponse.GetMyGroupAlert_GroupAlert.GetMyGroupAlert_Escalations escalations = new GetMyGroupAlertResponse.GetMyGroupAlert_GroupAlert.GetMyGroupAlert_Escalations();

			GetMyGroupAlertResponse.GetMyGroupAlert_GroupAlert.GetMyGroupAlert_Escalations.GetMyGroupAlert_Info info = new GetMyGroupAlertResponse.GetMyGroupAlert_GroupAlert.GetMyGroupAlert_Escalations.GetMyGroupAlert_Info();
			info.Statistics = context.StringValue("GetMyGroupAlert.GroupAlert.Escalations.Info.Statistics");
			info.ComparisonOperator = context.StringValue("GetMyGroupAlert.GroupAlert.Escalations.Info.ComparisonOperator");
			info.Threshold = context.StringValue("GetMyGroupAlert.GroupAlert.Escalations.Info.Threshold");
			info.Times = context.IntegerValue("GetMyGroupAlert.GroupAlert.Escalations.Info.Times");
			escalations.Info = info;

			GetMyGroupAlertResponse.GetMyGroupAlert_GroupAlert.GetMyGroupAlert_Escalations.GetMyGroupAlert_Warn warn = new GetMyGroupAlertResponse.GetMyGroupAlert_GroupAlert.GetMyGroupAlert_Escalations.GetMyGroupAlert_Warn();
			warn.Statistics = context.StringValue("GetMyGroupAlert.GroupAlert.Escalations.Warn.Statistics");
			warn.ComparisonOperator = context.StringValue("GetMyGroupAlert.GroupAlert.Escalations.Warn.ComparisonOperator");
			warn.Threshold = context.StringValue("GetMyGroupAlert.GroupAlert.Escalations.Warn.Threshold");
			warn.Times = context.IntegerValue("GetMyGroupAlert.GroupAlert.Escalations.Warn.Times");
			escalations.Warn = warn;

			GetMyGroupAlertResponse.GetMyGroupAlert_GroupAlert.GetMyGroupAlert_Escalations.GetMyGroupAlert_Critical critical = new GetMyGroupAlertResponse.GetMyGroupAlert_GroupAlert.GetMyGroupAlert_Escalations.GetMyGroupAlert_Critical();
			critical.Statistics = context.StringValue("GetMyGroupAlert.GroupAlert.Escalations.Critical.Statistics");
			critical.ComparisonOperator = context.StringValue("GetMyGroupAlert.GroupAlert.Escalations.Critical.ComparisonOperator");
			critical.Threshold = context.StringValue("GetMyGroupAlert.GroupAlert.Escalations.Critical.Threshold");
			critical.Times = context.IntegerValue("GetMyGroupAlert.GroupAlert.Escalations.Critical.Times");
			escalations.Critical = critical;
			groupAlert.Escalations = escalations;
			getMyGroupAlertResponse.GroupAlert = groupAlert;
        
			return getMyGroupAlertResponse;
        }
    }
}
