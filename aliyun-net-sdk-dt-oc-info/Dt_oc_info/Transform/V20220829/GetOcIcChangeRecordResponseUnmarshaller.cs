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
    public class GetOcIcChangeRecordResponseUnmarshaller
    {
        public static GetOcIcChangeRecordResponse Unmarshall(UnmarshallerContext _ctx)
        {
			GetOcIcChangeRecordResponse getOcIcChangeRecordResponse = new GetOcIcChangeRecordResponse();

			getOcIcChangeRecordResponse.HttpResponse = _ctx.HttpResponse;
			getOcIcChangeRecordResponse.Code = _ctx.StringValue("GetOcIcChangeRecord.Code");
			getOcIcChangeRecordResponse.Success = _ctx.BooleanValue("GetOcIcChangeRecord.Success");
			getOcIcChangeRecordResponse.Message = _ctx.StringValue("GetOcIcChangeRecord.Message");
			getOcIcChangeRecordResponse.TotalNum = _ctx.IntegerValue("GetOcIcChangeRecord.TotalNum");
			getOcIcChangeRecordResponse.PageIndex = _ctx.IntegerValue("GetOcIcChangeRecord.PageIndex");
			getOcIcChangeRecordResponse.PageNum = _ctx.IntegerValue("GetOcIcChangeRecord.PageNum");
			getOcIcChangeRecordResponse.RequestId = _ctx.StringValue("GetOcIcChangeRecord.RequestId");

			List<GetOcIcChangeRecordResponse.GetOcIcChangeRecord_DataItem> getOcIcChangeRecordResponse_data = new List<GetOcIcChangeRecordResponse.GetOcIcChangeRecord_DataItem>();
			for (int i = 0; i < _ctx.Length("GetOcIcChangeRecord.Data.Length"); i++) {
				GetOcIcChangeRecordResponse.GetOcIcChangeRecord_DataItem dataItem = new GetOcIcChangeRecordResponse.GetOcIcChangeRecord_DataItem();
				dataItem.Type = _ctx.StringValue("GetOcIcChangeRecord.Data["+ i +"].Type");
				dataItem.ChangeDate = _ctx.StringValue("GetOcIcChangeRecord.Data["+ i +"].ChangeDate");
				dataItem.BeforeContent = _ctx.StringValue("GetOcIcChangeRecord.Data["+ i +"].BeforeContent");
				dataItem.AfterContent = _ctx.StringValue("GetOcIcChangeRecord.Data["+ i +"].AfterContent");

				getOcIcChangeRecordResponse_data.Add(dataItem);
			}
			getOcIcChangeRecordResponse.Data = getOcIcChangeRecordResponse_data;
        
			return getOcIcChangeRecordResponse;
        }
    }
}
