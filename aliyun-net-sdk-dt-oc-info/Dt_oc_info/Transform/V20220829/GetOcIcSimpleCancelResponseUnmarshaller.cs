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
using Aliyun.Acs.dt_oc_info.Model.V20220829;

namespace Aliyun.Acs.dt_oc_info.Transform.V20220829
{
    public class GetOcIcSimpleCancelResponseUnmarshaller
    {
        public static GetOcIcSimpleCancelResponse Unmarshall(UnmarshallerContext _ctx)
        {
			GetOcIcSimpleCancelResponse getOcIcSimpleCancelResponse = new GetOcIcSimpleCancelResponse();

			getOcIcSimpleCancelResponse.HttpResponse = _ctx.HttpResponse;
			getOcIcSimpleCancelResponse.Code = _ctx.StringValue("GetOcIcSimpleCancel.Code");
			getOcIcSimpleCancelResponse.Success = _ctx.BooleanValue("GetOcIcSimpleCancel.Success");
			getOcIcSimpleCancelResponse.Message = _ctx.StringValue("GetOcIcSimpleCancel.Message");
			getOcIcSimpleCancelResponse.TotalNum = _ctx.IntegerValue("GetOcIcSimpleCancel.TotalNum");
			getOcIcSimpleCancelResponse.PageIndex = _ctx.IntegerValue("GetOcIcSimpleCancel.PageIndex");
			getOcIcSimpleCancelResponse.PageNum = _ctx.IntegerValue("GetOcIcSimpleCancel.PageNum");
			getOcIcSimpleCancelResponse.RequestId = _ctx.StringValue("GetOcIcSimpleCancel.RequestId");

			List<GetOcIcSimpleCancelResponse.GetOcIcSimpleCancel_DataItem> getOcIcSimpleCancelResponse_data = new List<GetOcIcSimpleCancelResponse.GetOcIcSimpleCancel_DataItem>();
			for (int i = 0; i < _ctx.Length("GetOcIcSimpleCancel.Data.Length"); i++) {
				GetOcIcSimpleCancelResponse.GetOcIcSimpleCancel_DataItem dataItem = new GetOcIcSimpleCancelResponse.GetOcIcSimpleCancel_DataItem();
				dataItem.EntName = _ctx.StringValue("GetOcIcSimpleCancel.Data["+ i +"].EntName");
				dataItem.SocialCreditCode = _ctx.StringValue("GetOcIcSimpleCancel.Data["+ i +"].SocialCreditCode");
				dataItem.Department = _ctx.StringValue("GetOcIcSimpleCancel.Data["+ i +"].Department");
				dataItem.NoticePeriod = _ctx.StringValue("GetOcIcSimpleCancel.Data["+ i +"].NoticePeriod");
				dataItem.ScaProposer = _ctx.StringValue("GetOcIcSimpleCancel.Data["+ i +"].ScaProposer");
				dataItem.ScaDate = _ctx.StringValue("GetOcIcSimpleCancel.Data["+ i +"].ScaDate");
				dataItem.ScaContent = _ctx.StringValue("GetOcIcSimpleCancel.Data["+ i +"].ScaContent");
				dataItem.ScaResult = _ctx.StringValue("GetOcIcSimpleCancel.Data["+ i +"].ScaResult");
				dataItem.ScaResultDate = _ctx.StringValue("GetOcIcSimpleCancel.Data["+ i +"].ScaResultDate");

				getOcIcSimpleCancelResponse_data.Add(dataItem);
			}
			getOcIcSimpleCancelResponse.Data = getOcIcSimpleCancelResponse_data;
        
			return getOcIcSimpleCancelResponse;
        }
    }
}
