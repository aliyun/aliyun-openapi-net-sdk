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
    public class GetOcIcSeriousOffenseResponseUnmarshaller
    {
        public static GetOcIcSeriousOffenseResponse Unmarshall(UnmarshallerContext _ctx)
        {
			GetOcIcSeriousOffenseResponse getOcIcSeriousOffenseResponse = new GetOcIcSeriousOffenseResponse();

			getOcIcSeriousOffenseResponse.HttpResponse = _ctx.HttpResponse;
			getOcIcSeriousOffenseResponse.Code = _ctx.StringValue("GetOcIcSeriousOffense.Code");
			getOcIcSeriousOffenseResponse.Success = _ctx.BooleanValue("GetOcIcSeriousOffense.Success");
			getOcIcSeriousOffenseResponse.Message = _ctx.StringValue("GetOcIcSeriousOffense.Message");
			getOcIcSeriousOffenseResponse.TotalNum = _ctx.IntegerValue("GetOcIcSeriousOffense.TotalNum");
			getOcIcSeriousOffenseResponse.PageIndex = _ctx.IntegerValue("GetOcIcSeriousOffense.PageIndex");
			getOcIcSeriousOffenseResponse.PageNum = _ctx.IntegerValue("GetOcIcSeriousOffense.PageNum");
			getOcIcSeriousOffenseResponse.RequestId = _ctx.StringValue("GetOcIcSeriousOffense.RequestId");

			List<GetOcIcSeriousOffenseResponse.GetOcIcSeriousOffense_DataItem> getOcIcSeriousOffenseResponse_data = new List<GetOcIcSeriousOffenseResponse.GetOcIcSeriousOffense_DataItem>();
			for (int i = 0; i < _ctx.Length("GetOcIcSeriousOffense.Data.Length"); i++) {
				GetOcIcSeriousOffenseResponse.GetOcIcSeriousOffense_DataItem dataItem = new GetOcIcSeriousOffenseResponse.GetOcIcSeriousOffense_DataItem();
				dataItem.EntName = _ctx.StringValue("GetOcIcSeriousOffense.Data["+ i +"].EntName");
				dataItem.InReason = _ctx.StringValue("GetOcIcSeriousOffense.Data["+ i +"].InReason");
				dataItem.InDate = _ctx.StringValue("GetOcIcSeriousOffense.Data["+ i +"].InDate");
				dataItem.OutReason = _ctx.StringValue("GetOcIcSeriousOffense.Data["+ i +"].OutReason");
				dataItem.OutDate = _ctx.StringValue("GetOcIcSeriousOffense.Data["+ i +"].OutDate");
				dataItem.InDepartment = _ctx.StringValue("GetOcIcSeriousOffense.Data["+ i +"].InDepartment");
				dataItem.OutDepartment = _ctx.StringValue("GetOcIcSeriousOffense.Data["+ i +"].OutDepartment");

				getOcIcSeriousOffenseResponse_data.Add(dataItem);
			}
			getOcIcSeriousOffenseResponse.Data = getOcIcSeriousOffenseResponse_data;
        
			return getOcIcSeriousOffenseResponse;
        }
    }
}
