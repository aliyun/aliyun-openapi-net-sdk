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
using Aliyun.Acs.Sas.Model.V20181203;

namespace Aliyun.Acs.Sas.Transform.V20181203
{
    public class DescribeAlarmEventDetailResponseUnmarshaller
    {
        public static DescribeAlarmEventDetailResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeAlarmEventDetailResponse describeAlarmEventDetailResponse = new DescribeAlarmEventDetailResponse();

			describeAlarmEventDetailResponse.HttpResponse = context.HttpResponse;
			describeAlarmEventDetailResponse.RequestId = context.StringValue("DescribeAlarmEventDetail.RequestId");

			DescribeAlarmEventDetailResponse.DescribeAlarmEventDetail_Data data = new DescribeAlarmEventDetailResponse.DescribeAlarmEventDetail_Data();
			data.InternetIp = context.StringValue("DescribeAlarmEventDetail.Data.InternetIp");
			data.Level = context.StringValue("DescribeAlarmEventDetail.Data.Level");
			data.InstanceName = context.StringValue("DescribeAlarmEventDetail.Data.InstanceName");
			data.AlarmEventAliasName = context.StringValue("DescribeAlarmEventDetail.Data.AlarmEventAliasName");
			data.Type = context.StringValue("DescribeAlarmEventDetail.Data.Type");
			data.Uuid = context.StringValue("DescribeAlarmEventDetail.Data.Uuid");
			data.Solution = context.StringValue("DescribeAlarmEventDetail.Data.Solution");
			data.StartTime = context.LongValue("DescribeAlarmEventDetail.Data.StartTime");
			data.EndTime = context.LongValue("DescribeAlarmEventDetail.Data.EndTime");
			data.AlarmEventDesc = context.StringValue("DescribeAlarmEventDetail.Data.AlarmEventDesc");
			data.IntranetIp = context.StringValue("DescribeAlarmEventDetail.Data.IntranetIp");
			data.CanBeDealOnLine = context.BooleanValue("DescribeAlarmEventDetail.Data.CanBeDealOnLine");
			data.AlarmUniqueInfo = context.StringValue("DescribeAlarmEventDetail.Data.AlarmUniqueInfo");
			data.DataSource = context.StringValue("DescribeAlarmEventDetail.Data.DataSource");
			data.CanCancelFault = context.BooleanValue("DescribeAlarmEventDetail.Data.CanCancelFault");

			List<DescribeAlarmEventDetailResponse.DescribeAlarmEventDetail_Data.DescribeAlarmEventDetail_CauseDetail> data_causeDetails = new List<DescribeAlarmEventDetailResponse.DescribeAlarmEventDetail_Data.DescribeAlarmEventDetail_CauseDetail>();
			for (int i = 0; i < context.Length("DescribeAlarmEventDetail.Data.CauseDetails.Length"); i++) {
				DescribeAlarmEventDetailResponse.DescribeAlarmEventDetail_Data.DescribeAlarmEventDetail_CauseDetail causeDetail = new DescribeAlarmEventDetailResponse.DescribeAlarmEventDetail_Data.DescribeAlarmEventDetail_CauseDetail();
				causeDetail.Key = context.StringValue("DescribeAlarmEventDetail.Data.CauseDetails["+ i +"].Key");

				List<DescribeAlarmEventDetailResponse.DescribeAlarmEventDetail_Data.DescribeAlarmEventDetail_CauseDetail.DescribeAlarmEventDetail_ValueItem> causeDetail_value = new List<DescribeAlarmEventDetailResponse.DescribeAlarmEventDetail_Data.DescribeAlarmEventDetail_CauseDetail.DescribeAlarmEventDetail_ValueItem>();
				for (int j = 0; j < context.Length("DescribeAlarmEventDetail.Data.CauseDetails["+ i +"].Value.Length"); j++) {
					DescribeAlarmEventDetailResponse.DescribeAlarmEventDetail_Data.DescribeAlarmEventDetail_CauseDetail.DescribeAlarmEventDetail_ValueItem valueItem = new DescribeAlarmEventDetailResponse.DescribeAlarmEventDetail_Data.DescribeAlarmEventDetail_CauseDetail.DescribeAlarmEventDetail_ValueItem();
					valueItem.Name = context.StringValue("DescribeAlarmEventDetail.Data.CauseDetails["+ i +"].Value["+ j +"].Name");
					valueItem.Type = context.StringValue("DescribeAlarmEventDetail.Data.CauseDetails["+ i +"].Value["+ j +"].Type");
					valueItem._Value = context.StringValue("DescribeAlarmEventDetail.Data.CauseDetails["+ i +"].Value["+ j +"].Value");

					causeDetail_value.Add(valueItem);
				}
				causeDetail._Value = causeDetail_value;

				data_causeDetails.Add(causeDetail);
			}
			data.CauseDetails = data_causeDetails;
			describeAlarmEventDetailResponse.Data = data;
        
			return describeAlarmEventDetailResponse;
        }
    }
}
