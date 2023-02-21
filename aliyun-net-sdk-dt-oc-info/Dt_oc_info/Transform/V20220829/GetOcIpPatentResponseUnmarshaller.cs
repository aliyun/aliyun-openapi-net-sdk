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
    public class GetOcIpPatentResponseUnmarshaller
    {
        public static GetOcIpPatentResponse Unmarshall(UnmarshallerContext _ctx)
        {
			GetOcIpPatentResponse getOcIpPatentResponse = new GetOcIpPatentResponse();

			getOcIpPatentResponse.HttpResponse = _ctx.HttpResponse;
			getOcIpPatentResponse.Code = _ctx.StringValue("GetOcIpPatent.Code");
			getOcIpPatentResponse.Success = _ctx.BooleanValue("GetOcIpPatent.Success");
			getOcIpPatentResponse.Message = _ctx.StringValue("GetOcIpPatent.Message");
			getOcIpPatentResponse.TotalNum = _ctx.IntegerValue("GetOcIpPatent.TotalNum");
			getOcIpPatentResponse.PageIndex = _ctx.IntegerValue("GetOcIpPatent.PageIndex");
			getOcIpPatentResponse.PageNum = _ctx.IntegerValue("GetOcIpPatent.PageNum");
			getOcIpPatentResponse.RequestId = _ctx.StringValue("GetOcIpPatent.RequestId");

			List<GetOcIpPatentResponse.GetOcIpPatent_DataItem> getOcIpPatentResponse_data = new List<GetOcIpPatentResponse.GetOcIpPatent_DataItem>();
			for (int i = 0; i < _ctx.Length("GetOcIpPatent.Data.Length"); i++) {
				GetOcIpPatentResponse.GetOcIpPatent_DataItem dataItem = new GetOcIpPatentResponse.GetOcIpPatent_DataItem();
				dataItem.EntName = _ctx.StringValue("GetOcIpPatent.Data["+ i +"].EntName");
				dataItem.PatentType = _ctx.StringValue("GetOcIpPatent.Data["+ i +"].PatentType");
				dataItem.PatentName = _ctx.StringValue("GetOcIpPatent.Data["+ i +"].PatentName");
				dataItem.PatentStatus = _ctx.StringValue("GetOcIpPatent.Data["+ i +"].PatentStatus");
				dataItem.RequestNum = _ctx.StringValue("GetOcIpPatent.Data["+ i +"].RequestNum");
				dataItem.RequestDate = _ctx.StringValue("GetOcIpPatent.Data["+ i +"].RequestDate");
				dataItem.PublicNum = _ctx.StringValue("GetOcIpPatent.Data["+ i +"].PublicNum");
				dataItem.PublicDate = _ctx.StringValue("GetOcIpPatent.Data["+ i +"].PublicDate");
				dataItem.InventorList = _ctx.StringValue("GetOcIpPatent.Data["+ i +"].InventorList");
				dataItem.PatenteeList = _ctx.StringValue("GetOcIpPatent.Data["+ i +"].PatenteeList");
				dataItem.CateNum = _ctx.StringValue("GetOcIpPatent.Data["+ i +"].CateNum");
				dataItem.PrioNum = _ctx.StringValue("GetOcIpPatent.Data["+ i +"].PrioNum");
				dataItem.PrioDate = _ctx.StringValue("GetOcIpPatent.Data["+ i +"].PrioDate");
				dataItem.Agency = _ctx.StringValue("GetOcIpPatent.Data["+ i +"].Agency");
				dataItem.Agent = _ctx.StringValue("GetOcIpPatent.Data["+ i +"].Agent");
				dataItem.Brief = _ctx.StringValue("GetOcIpPatent.Data["+ i +"].Brief");
				dataItem.MainClaim = _ctx.StringValue("GetOcIpPatent.Data["+ i +"].MainClaim");

				getOcIpPatentResponse_data.Add(dataItem);
			}
			getOcIpPatentResponse.Data = getOcIpPatentResponse_data;
        
			return getOcIpPatentResponse;
        }
    }
}
