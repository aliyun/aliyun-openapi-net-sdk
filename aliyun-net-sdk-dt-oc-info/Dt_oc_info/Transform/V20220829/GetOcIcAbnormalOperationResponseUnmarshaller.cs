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
    public class GetOcIcAbnormalOperationResponseUnmarshaller
    {
        public static GetOcIcAbnormalOperationResponse Unmarshall(UnmarshallerContext _ctx)
        {
			GetOcIcAbnormalOperationResponse getOcIcAbnormalOperationResponse = new GetOcIcAbnormalOperationResponse();

			getOcIcAbnormalOperationResponse.HttpResponse = _ctx.HttpResponse;
			getOcIcAbnormalOperationResponse.Code = _ctx.StringValue("GetOcIcAbnormalOperation.Code");
			getOcIcAbnormalOperationResponse.Success = _ctx.BooleanValue("GetOcIcAbnormalOperation.Success");
			getOcIcAbnormalOperationResponse.Message = _ctx.StringValue("GetOcIcAbnormalOperation.Message");
			getOcIcAbnormalOperationResponse.TotalNum = _ctx.IntegerValue("GetOcIcAbnormalOperation.TotalNum");
			getOcIcAbnormalOperationResponse.PageIndex = _ctx.IntegerValue("GetOcIcAbnormalOperation.PageIndex");
			getOcIcAbnormalOperationResponse.PageNum = _ctx.IntegerValue("GetOcIcAbnormalOperation.PageNum");
			getOcIcAbnormalOperationResponse.RequestId = _ctx.StringValue("GetOcIcAbnormalOperation.RequestId");

			List<GetOcIcAbnormalOperationResponse.GetOcIcAbnormalOperation_DataItem> getOcIcAbnormalOperationResponse_data = new List<GetOcIcAbnormalOperationResponse.GetOcIcAbnormalOperation_DataItem>();
			for (int i = 0; i < _ctx.Length("GetOcIcAbnormalOperation.Data.Length"); i++) {
				GetOcIcAbnormalOperationResponse.GetOcIcAbnormalOperation_DataItem dataItem = new GetOcIcAbnormalOperationResponse.GetOcIcAbnormalOperation_DataItem();
				dataItem.InDate = _ctx.StringValue("GetOcIcAbnormalOperation.Data["+ i +"].InDate");
				dataItem.InReason = _ctx.StringValue("GetOcIcAbnormalOperation.Data["+ i +"].InReason");
				dataItem.InDepartment = _ctx.StringValue("GetOcIcAbnormalOperation.Data["+ i +"].InDepartment");
				dataItem.OutDate = _ctx.StringValue("GetOcIcAbnormalOperation.Data["+ i +"].OutDate");
				dataItem.OutReason = _ctx.StringValue("GetOcIcAbnormalOperation.Data["+ i +"].OutReason");
				dataItem.OutDepartment = _ctx.StringValue("GetOcIcAbnormalOperation.Data["+ i +"].OutDepartment");

				getOcIcAbnormalOperationResponse_data.Add(dataItem);
			}
			getOcIcAbnormalOperationResponse.Data = getOcIcAbnormalOperationResponse_data;
        
			return getOcIcAbnormalOperationResponse;
        }
    }
}
