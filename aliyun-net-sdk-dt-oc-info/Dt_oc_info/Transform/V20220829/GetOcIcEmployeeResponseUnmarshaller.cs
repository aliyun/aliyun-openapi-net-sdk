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
    public class GetOcIcEmployeeResponseUnmarshaller
    {
        public static GetOcIcEmployeeResponse Unmarshall(UnmarshallerContext _ctx)
        {
			GetOcIcEmployeeResponse getOcIcEmployeeResponse = new GetOcIcEmployeeResponse();

			getOcIcEmployeeResponse.HttpResponse = _ctx.HttpResponse;
			getOcIcEmployeeResponse.Code = _ctx.StringValue("GetOcIcEmployee.Code");
			getOcIcEmployeeResponse.Success = _ctx.BooleanValue("GetOcIcEmployee.Success");
			getOcIcEmployeeResponse.Message = _ctx.StringValue("GetOcIcEmployee.Message");
			getOcIcEmployeeResponse.TotalNum = _ctx.IntegerValue("GetOcIcEmployee.TotalNum");
			getOcIcEmployeeResponse.PageIndex = _ctx.IntegerValue("GetOcIcEmployee.PageIndex");
			getOcIcEmployeeResponse.PageNum = _ctx.IntegerValue("GetOcIcEmployee.PageNum");
			getOcIcEmployeeResponse.RequestId = _ctx.StringValue("GetOcIcEmployee.RequestId");

			List<GetOcIcEmployeeResponse.GetOcIcEmployee_DataItem> getOcIcEmployeeResponse_data = new List<GetOcIcEmployeeResponse.GetOcIcEmployee_DataItem>();
			for (int i = 0; i < _ctx.Length("GetOcIcEmployee.Data.Length"); i++) {
				GetOcIcEmployeeResponse.GetOcIcEmployee_DataItem dataItem = new GetOcIcEmployeeResponse.GetOcIcEmployee_DataItem();
				dataItem.Name = _ctx.StringValue("GetOcIcEmployee.Data["+ i +"].Name");
				dataItem.JobTitle = _ctx.StringValue("GetOcIcEmployee.Data["+ i +"].JobTitle");

				getOcIcEmployeeResponse_data.Add(dataItem);
			}
			getOcIcEmployeeResponse.Data = getOcIcEmployeeResponse_data;
        
			return getOcIcEmployeeResponse;
        }
    }
}
