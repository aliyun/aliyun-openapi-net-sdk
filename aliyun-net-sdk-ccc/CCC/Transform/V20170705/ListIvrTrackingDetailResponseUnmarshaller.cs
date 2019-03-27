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
    public class ListIvrTrackingDetailResponseUnmarshaller
    {
        public static ListIvrTrackingDetailResponse Unmarshall(UnmarshallerContext context)
        {
			ListIvrTrackingDetailResponse listIvrTrackingDetailResponse = new ListIvrTrackingDetailResponse();

			listIvrTrackingDetailResponse.HttpResponse = context.HttpResponse;
			listIvrTrackingDetailResponse.RequestId = context.StringValue("ListIvrTrackingDetail.RequestId");
			listIvrTrackingDetailResponse.Success = context.BooleanValue("ListIvrTrackingDetail.Success");
			listIvrTrackingDetailResponse.Code = context.StringValue("ListIvrTrackingDetail.Code");
			listIvrTrackingDetailResponse.Message = context.StringValue("ListIvrTrackingDetail.Message");
			listIvrTrackingDetailResponse.HttpStatusCode = context.IntegerValue("ListIvrTrackingDetail.HttpStatusCode");

			ListIvrTrackingDetailResponse.ListIvrTrackingDetail_IvrTrackingDetails ivrTrackingDetails = new ListIvrTrackingDetailResponse.ListIvrTrackingDetail_IvrTrackingDetails();
			ivrTrackingDetails.TotalCount = context.IntegerValue("ListIvrTrackingDetail.IvrTrackingDetails.TotalCount");
			ivrTrackingDetails.PageNumber = context.IntegerValue("ListIvrTrackingDetail.IvrTrackingDetails.PageNumber");
			ivrTrackingDetails.PageSize = context.IntegerValue("ListIvrTrackingDetail.IvrTrackingDetails.PageSize");

			List<ListIvrTrackingDetailResponse.ListIvrTrackingDetail_IvrTrackingDetails.ListIvrTrackingDetail_IvrTrackingDetail> ivrTrackingDetails_list = new List<ListIvrTrackingDetailResponse.ListIvrTrackingDetail_IvrTrackingDetails.ListIvrTrackingDetail_IvrTrackingDetail>();
			for (int i = 0; i < context.Length("ListIvrTrackingDetail.IvrTrackingDetails.List.Length"); i++) {
				ListIvrTrackingDetailResponse.ListIvrTrackingDetail_IvrTrackingDetails.ListIvrTrackingDetail_IvrTrackingDetail ivrTrackingDetail = new ListIvrTrackingDetailResponse.ListIvrTrackingDetail_IvrTrackingDetails.ListIvrTrackingDetail_IvrTrackingDetail();
				ivrTrackingDetail.FlowName = context.StringValue("ListIvrTrackingDetail.IvrTrackingDetails.List["+ i +"].FlowName");
				ivrTrackingDetail.NodeName = context.StringValue("ListIvrTrackingDetail.IvrTrackingDetails.List["+ i +"].NodeName");
				ivrTrackingDetail.NodeType = context.StringValue("ListIvrTrackingDetail.IvrTrackingDetails.List["+ i +"].NodeType");
				ivrTrackingDetail.ContactId = context.StringValue("ListIvrTrackingDetail.IvrTrackingDetails.List["+ i +"].ContactId");
				ivrTrackingDetail.CallingNumber = context.StringValue("ListIvrTrackingDetail.IvrTrackingDetails.List["+ i +"].CallingNumber");
				ivrTrackingDetail.CalledNumber = context.StringValue("ListIvrTrackingDetail.IvrTrackingDetails.List["+ i +"].CalledNumber");
				ivrTrackingDetail.StartTime = context.LongValue("ListIvrTrackingDetail.IvrTrackingDetails.List["+ i +"].StartTime");
				ivrTrackingDetail.StopTime = context.LongValue("ListIvrTrackingDetail.IvrTrackingDetails.List["+ i +"].StopTime");
				ivrTrackingDetail.Status = context.StringValue("ListIvrTrackingDetail.IvrTrackingDetails.List["+ i +"].Status");
				ivrTrackingDetail.InputData = context.StringValue("ListIvrTrackingDetail.IvrTrackingDetails.List["+ i +"].InputData");
				ivrTrackingDetail.OutputData = context.StringValue("ListIvrTrackingDetail.IvrTrackingDetails.List["+ i +"].OutputData");
				ivrTrackingDetail.Description = context.StringValue("ListIvrTrackingDetail.IvrTrackingDetails.List["+ i +"].Description");
				ivrTrackingDetail.DeviceID = context.StringValue("ListIvrTrackingDetail.IvrTrackingDetails.List["+ i +"].DeviceID");
				ivrTrackingDetail.TenantId = context.StringValue("ListIvrTrackingDetail.IvrTrackingDetails.List["+ i +"].TenantId");

				ivrTrackingDetails_list.Add(ivrTrackingDetail);
			}
			ivrTrackingDetails.List = ivrTrackingDetails_list;
			listIvrTrackingDetailResponse.IvrTrackingDetails = ivrTrackingDetails;
        
			return listIvrTrackingDetailResponse;
        }
    }
}
