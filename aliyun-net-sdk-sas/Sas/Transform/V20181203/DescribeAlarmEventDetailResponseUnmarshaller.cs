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
        public static DescribeAlarmEventDetailResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeAlarmEventDetailResponse describeAlarmEventDetailResponse = new DescribeAlarmEventDetailResponse();

			describeAlarmEventDetailResponse.HttpResponse = _ctx.HttpResponse;
			describeAlarmEventDetailResponse.RequestId = _ctx.StringValue("DescribeAlarmEventDetail.RequestId");

			DescribeAlarmEventDetailResponse.DescribeAlarmEventDetail_Data data = new DescribeAlarmEventDetailResponse.DescribeAlarmEventDetail_Data();
			data.Type = _ctx.StringValue("DescribeAlarmEventDetail.Data.Type");
			data.InternetIp = _ctx.StringValue("DescribeAlarmEventDetail.Data.InternetIp");
			data.K8sClusterName = _ctx.StringValue("DescribeAlarmEventDetail.Data.K8sClusterName");
			data.ContainerImageId = _ctx.StringValue("DescribeAlarmEventDetail.Data.ContainerImageId");
			data.AlarmEventDesc = _ctx.StringValue("DescribeAlarmEventDetail.Data.AlarmEventDesc");
			data.AlarmUniqueInfo = _ctx.StringValue("DescribeAlarmEventDetail.Data.AlarmUniqueInfo");
			data.CanCancelFault = _ctx.BooleanValue("DescribeAlarmEventDetail.Data.CanCancelFault");
			data.AppName = _ctx.StringValue("DescribeAlarmEventDetail.Data.AppName");
			data.CanBeDealOnLine = _ctx.BooleanValue("DescribeAlarmEventDetail.Data.CanBeDealOnLine");
			data.ContainerImageName = _ctx.StringValue("DescribeAlarmEventDetail.Data.ContainerImageName");
			data.K8sClusterId = _ctx.StringValue("DescribeAlarmEventDetail.Data.K8sClusterId");
			data.ContainHwMode = _ctx.BooleanValue("DescribeAlarmEventDetail.Data.ContainHwMode");
			data.InstanceName = _ctx.StringValue("DescribeAlarmEventDetail.Data.InstanceName");
			data.K8sNodeId = _ctx.StringValue("DescribeAlarmEventDetail.Data.K8sNodeId");
			data.Solution = _ctx.StringValue("DescribeAlarmEventDetail.Data.Solution");
			data.DataSource = _ctx.StringValue("DescribeAlarmEventDetail.Data.DataSource");
			data.IntranetIp = _ctx.StringValue("DescribeAlarmEventDetail.Data.IntranetIp");
			data.AlarmEventAliasName = _ctx.StringValue("DescribeAlarmEventDetail.Data.AlarmEventAliasName");
			data.EndTime = _ctx.LongValue("DescribeAlarmEventDetail.Data.EndTime");
			data.Uuid = _ctx.StringValue("DescribeAlarmEventDetail.Data.Uuid");
			data.StartTime = _ctx.LongValue("DescribeAlarmEventDetail.Data.StartTime");
			data.ContainerId = _ctx.StringValue("DescribeAlarmEventDetail.Data.ContainerId");
			data.K8sPodName = _ctx.StringValue("DescribeAlarmEventDetail.Data.K8sPodName");
			data.K8sNamespace = _ctx.StringValue("DescribeAlarmEventDetail.Data.K8sNamespace");
			data.K8sNodeName = _ctx.StringValue("DescribeAlarmEventDetail.Data.K8sNodeName");
			data.Level = _ctx.StringValue("DescribeAlarmEventDetail.Data.Level");

			List<DescribeAlarmEventDetailResponse.DescribeAlarmEventDetail_Data.DescribeAlarmEventDetail_CauseDetail> data_causeDetails = new List<DescribeAlarmEventDetailResponse.DescribeAlarmEventDetail_Data.DescribeAlarmEventDetail_CauseDetail>();
			for (int i = 0; i < _ctx.Length("DescribeAlarmEventDetail.Data.CauseDetails.Length"); i++) {
				DescribeAlarmEventDetailResponse.DescribeAlarmEventDetail_Data.DescribeAlarmEventDetail_CauseDetail causeDetail = new DescribeAlarmEventDetailResponse.DescribeAlarmEventDetail_Data.DescribeAlarmEventDetail_CauseDetail();
				causeDetail.Key = _ctx.StringValue("DescribeAlarmEventDetail.Data.CauseDetails["+ i +"].Key");

				List<DescribeAlarmEventDetailResponse.DescribeAlarmEventDetail_Data.DescribeAlarmEventDetail_CauseDetail.DescribeAlarmEventDetail_ValueItem> causeDetail_value = new List<DescribeAlarmEventDetailResponse.DescribeAlarmEventDetail_Data.DescribeAlarmEventDetail_CauseDetail.DescribeAlarmEventDetail_ValueItem>();
				for (int j = 0; j < _ctx.Length("DescribeAlarmEventDetail.Data.CauseDetails["+ i +"].Value.Length"); j++) {
					DescribeAlarmEventDetailResponse.DescribeAlarmEventDetail_Data.DescribeAlarmEventDetail_CauseDetail.DescribeAlarmEventDetail_ValueItem valueItem = new DescribeAlarmEventDetailResponse.DescribeAlarmEventDetail_Data.DescribeAlarmEventDetail_CauseDetail.DescribeAlarmEventDetail_ValueItem();
					valueItem.Type = _ctx.StringValue("DescribeAlarmEventDetail.Data.CauseDetails["+ i +"].Value["+ j +"].Type");
					valueItem._Value = _ctx.StringValue("DescribeAlarmEventDetail.Data.CauseDetails["+ i +"].Value["+ j +"].Value");
					valueItem.Name = _ctx.StringValue("DescribeAlarmEventDetail.Data.CauseDetails["+ i +"].Value["+ j +"].Name");

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
