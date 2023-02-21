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
    public class GetOcIcDoubleCheckupResponseUnmarshaller
    {
        public static GetOcIcDoubleCheckupResponse Unmarshall(UnmarshallerContext _ctx)
        {
			GetOcIcDoubleCheckupResponse getOcIcDoubleCheckupResponse = new GetOcIcDoubleCheckupResponse();

			getOcIcDoubleCheckupResponse.HttpResponse = _ctx.HttpResponse;
			getOcIcDoubleCheckupResponse.Code = _ctx.StringValue("GetOcIcDoubleCheckup.Code");
			getOcIcDoubleCheckupResponse.Success = _ctx.BooleanValue("GetOcIcDoubleCheckup.Success");
			getOcIcDoubleCheckupResponse.Message = _ctx.StringValue("GetOcIcDoubleCheckup.Message");
			getOcIcDoubleCheckupResponse.TotalNum = _ctx.IntegerValue("GetOcIcDoubleCheckup.TotalNum");
			getOcIcDoubleCheckupResponse.PageIndex = _ctx.IntegerValue("GetOcIcDoubleCheckup.PageIndex");
			getOcIcDoubleCheckupResponse.PageNum = _ctx.IntegerValue("GetOcIcDoubleCheckup.PageNum");
			getOcIcDoubleCheckupResponse.RequestId = _ctx.StringValue("GetOcIcDoubleCheckup.RequestId");

			List<GetOcIcDoubleCheckupResponse.GetOcIcDoubleCheckup_DataItem> getOcIcDoubleCheckupResponse_data = new List<GetOcIcDoubleCheckupResponse.GetOcIcDoubleCheckup_DataItem>();
			for (int i = 0; i < _ctx.Length("GetOcIcDoubleCheckup.Data.Length"); i++) {
				GetOcIcDoubleCheckupResponse.GetOcIcDoubleCheckup_DataItem dataItem = new GetOcIcDoubleCheckupResponse.GetOcIcDoubleCheckup_DataItem();
				dataItem.InspectPlanId = _ctx.StringValue("GetOcIcDoubleCheckup.Data["+ i +"].InspectPlanId");
				dataItem.InspectPlanName = _ctx.StringValue("GetOcIcDoubleCheckup.Data["+ i +"].InspectPlanName");
				dataItem.InspectTaskId = _ctx.StringValue("GetOcIcDoubleCheckup.Data["+ i +"].InspectTaskId");
				dataItem.InspectTaskName = _ctx.StringValue("GetOcIcDoubleCheckup.Data["+ i +"].InspectTaskName");
				dataItem.InspectTypeName = _ctx.StringValue("GetOcIcDoubleCheckup.Data["+ i +"].InspectTypeName");
				dataItem.InspectDepartment = _ctx.StringValue("GetOcIcDoubleCheckup.Data["+ i +"].InspectDepartment");
				dataItem.InspectDate = _ctx.StringValue("GetOcIcDoubleCheckup.Data["+ i +"].InspectDate");
				dataItem.InspectItem = _ctx.StringValue("GetOcIcDoubleCheckup.Data["+ i +"].InspectItem");
				dataItem.InspectResult = _ctx.StringValue("GetOcIcDoubleCheckup.Data["+ i +"].InspectResult");

				getOcIcDoubleCheckupResponse_data.Add(dataItem);
			}
			getOcIcDoubleCheckupResponse.Data = getOcIcDoubleCheckupResponse_data;
        
			return getOcIcDoubleCheckupResponse;
        }
    }
}
