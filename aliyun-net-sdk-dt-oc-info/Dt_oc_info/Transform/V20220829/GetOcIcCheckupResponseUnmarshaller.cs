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
    public class GetOcIcCheckupResponseUnmarshaller
    {
        public static GetOcIcCheckupResponse Unmarshall(UnmarshallerContext _ctx)
        {
			GetOcIcCheckupResponse getOcIcCheckupResponse = new GetOcIcCheckupResponse();

			getOcIcCheckupResponse.HttpResponse = _ctx.HttpResponse;
			getOcIcCheckupResponse.Code = _ctx.StringValue("GetOcIcCheckup.Code");
			getOcIcCheckupResponse.Success = _ctx.BooleanValue("GetOcIcCheckup.Success");
			getOcIcCheckupResponse.Message = _ctx.StringValue("GetOcIcCheckup.Message");
			getOcIcCheckupResponse.TotalNum = _ctx.IntegerValue("GetOcIcCheckup.TotalNum");
			getOcIcCheckupResponse.PageIndex = _ctx.IntegerValue("GetOcIcCheckup.PageIndex");
			getOcIcCheckupResponse.PageNum = _ctx.IntegerValue("GetOcIcCheckup.PageNum");
			getOcIcCheckupResponse.RequestId = _ctx.StringValue("GetOcIcCheckup.RequestId");

			List<GetOcIcCheckupResponse.GetOcIcCheckup_DataItem> getOcIcCheckupResponse_data = new List<GetOcIcCheckupResponse.GetOcIcCheckup_DataItem>();
			for (int i = 0; i < _ctx.Length("GetOcIcCheckup.Data.Length"); i++) {
				GetOcIcCheckupResponse.GetOcIcCheckup_DataItem dataItem = new GetOcIcCheckupResponse.GetOcIcCheckup_DataItem();
				dataItem.Department = _ctx.StringValue("GetOcIcCheckup.Data["+ i +"].Department");
				dataItem.Date = _ctx.StringValue("GetOcIcCheckup.Data["+ i +"].Date");
				dataItem.Type = _ctx.StringValue("GetOcIcCheckup.Data["+ i +"].Type");
				dataItem.Result = _ctx.StringValue("GetOcIcCheckup.Data["+ i +"].Result");

				getOcIcCheckupResponse_data.Add(dataItem);
			}
			getOcIcCheckupResponse.Data = getOcIcCheckupResponse_data;
        
			return getOcIcCheckupResponse;
        }
    }
}
