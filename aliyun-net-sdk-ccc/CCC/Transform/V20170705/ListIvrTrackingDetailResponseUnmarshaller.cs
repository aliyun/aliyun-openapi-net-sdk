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
        public static ListIvrTrackingDetailResponse Unmarshall(UnmarshallerContext _ctx)
        {
			ListIvrTrackingDetailResponse listIvrTrackingDetailResponse = new ListIvrTrackingDetailResponse();

			listIvrTrackingDetailResponse.HttpResponse = _ctx.HttpResponse;
			listIvrTrackingDetailResponse.RequestId = _ctx.StringValue("ListIvrTrackingDetail.RequestId");
			listIvrTrackingDetailResponse.Success = _ctx.BooleanValue("ListIvrTrackingDetail.Success");
			listIvrTrackingDetailResponse.Code = _ctx.StringValue("ListIvrTrackingDetail.Code");
			listIvrTrackingDetailResponse.Message = _ctx.StringValue("ListIvrTrackingDetail.Message");
			listIvrTrackingDetailResponse.HttpStatusCode = _ctx.IntegerValue("ListIvrTrackingDetail.HttpStatusCode");

			ListIvrTrackingDetailResponse.ListIvrTrackingDetail_IvrTrackingDetails ivrTrackingDetails = new ListIvrTrackingDetailResponse.ListIvrTrackingDetail_IvrTrackingDetails();
			ivrTrackingDetails.TotalCount = _ctx.IntegerValue("ListIvrTrackingDetail.IvrTrackingDetails.TotalCount");
			ivrTrackingDetails.PageNumber = _ctx.IntegerValue("ListIvrTrackingDetail.IvrTrackingDetails.PageNumber");
			ivrTrackingDetails.PageSize = _ctx.IntegerValue("ListIvrTrackingDetail.IvrTrackingDetails.PageSize");

			List<ListIvrTrackingDetailResponse.ListIvrTrackingDetail_IvrTrackingDetails.ListIvrTrackingDetail_IvrTrackingDetail> ivrTrackingDetails_list = new List<ListIvrTrackingDetailResponse.ListIvrTrackingDetail_IvrTrackingDetails.ListIvrTrackingDetail_IvrTrackingDetail>();
			for (int i = 0; i < _ctx.Length("ListIvrTrackingDetail.IvrTrackingDetails.List.Length"); i++) {
				ListIvrTrackingDetailResponse.ListIvrTrackingDetail_IvrTrackingDetails.ListIvrTrackingDetail_IvrTrackingDetail ivrTrackingDetail = new ListIvrTrackingDetailResponse.ListIvrTrackingDetail_IvrTrackingDetails.ListIvrTrackingDetail_IvrTrackingDetail();
				ivrTrackingDetail.FlowName = _ctx.StringValue("ListIvrTrackingDetail.IvrTrackingDetails.List["+ i +"].FlowName");
				ivrTrackingDetail.NodeName = _ctx.StringValue("ListIvrTrackingDetail.IvrTrackingDetails.List["+ i +"].NodeName");
				ivrTrackingDetail.NodeType = _ctx.StringValue("ListIvrTrackingDetail.IvrTrackingDetails.List["+ i +"].NodeType");
				ivrTrackingDetail.ContactId = _ctx.StringValue("ListIvrTrackingDetail.IvrTrackingDetails.List["+ i +"].ContactId");
				ivrTrackingDetail.CallingNumber = _ctx.StringValue("ListIvrTrackingDetail.IvrTrackingDetails.List["+ i +"].CallingNumber");
				ivrTrackingDetail.CalledNumber = _ctx.StringValue("ListIvrTrackingDetail.IvrTrackingDetails.List["+ i +"].CalledNumber");
				ivrTrackingDetail.StartTime = _ctx.LongValue("ListIvrTrackingDetail.IvrTrackingDetails.List["+ i +"].StartTime");
				ivrTrackingDetail.StopTime = _ctx.LongValue("ListIvrTrackingDetail.IvrTrackingDetails.List["+ i +"].StopTime");
				ivrTrackingDetail.Status = _ctx.StringValue("ListIvrTrackingDetail.IvrTrackingDetails.List["+ i +"].Status");
				ivrTrackingDetail.InputData = _ctx.StringValue("ListIvrTrackingDetail.IvrTrackingDetails.List["+ i +"].InputData");
				ivrTrackingDetail.OutputData = _ctx.StringValue("ListIvrTrackingDetail.IvrTrackingDetails.List["+ i +"].OutputData");
				ivrTrackingDetail.Description = _ctx.StringValue("ListIvrTrackingDetail.IvrTrackingDetails.List["+ i +"].Description");
				ivrTrackingDetail.DeviceID = _ctx.StringValue("ListIvrTrackingDetail.IvrTrackingDetails.List["+ i +"].DeviceID");
				ivrTrackingDetail.TenantId = _ctx.StringValue("ListIvrTrackingDetail.IvrTrackingDetails.List["+ i +"].TenantId");

				ivrTrackingDetails_list.Add(ivrTrackingDetail);
			}
			ivrTrackingDetails.List = ivrTrackingDetails_list;
			listIvrTrackingDetailResponse.IvrTrackingDetails = ivrTrackingDetails;
        
			return listIvrTrackingDetailResponse;
        }
    }
}
