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
using Aliyun.Acs.Copyright.Model.V20190123;

namespace Aliyun.Acs.Copyright.Transform.V20190123
{
    public class GetAllPatentListResponseUnmarshaller
    {
        public static GetAllPatentListResponse Unmarshall(UnmarshallerContext _ctx)
        {
			GetAllPatentListResponse getAllPatentListResponse = new GetAllPatentListResponse();

			getAllPatentListResponse.HttpResponse = _ctx.HttpResponse;
			getAllPatentListResponse.PageNum = _ctx.IntegerValue("GetAllPatentList.PageNum");
			getAllPatentListResponse.PageSize = _ctx.IntegerValue("GetAllPatentList.PageSize");
			getAllPatentListResponse.RequestId = _ctx.StringValue("GetAllPatentList.RequestId");
			getAllPatentListResponse.Success = _ctx.BooleanValue("GetAllPatentList.Success");
			getAllPatentListResponse.TotalItemNum = _ctx.IntegerValue("GetAllPatentList.TotalItemNum");
			getAllPatentListResponse.TotalPageNum = _ctx.IntegerValue("GetAllPatentList.TotalPageNum");

			List<GetAllPatentListResponse.GetAllPatentList_DataItem> getAllPatentListResponse_data = new List<GetAllPatentListResponse.GetAllPatentList_DataItem>();
			for (int i = 0; i < _ctx.Length("GetAllPatentList.Data.Length"); i++) {
				GetAllPatentListResponse.GetAllPatentList_DataItem dataItem = new GetAllPatentListResponse.GetAllPatentList_DataItem();
				dataItem.Agency = _ctx.StringValue("GetAllPatentList.Data["+ i +"].Agency");
				dataItem.ApplyNumber = _ctx.StringValue("GetAllPatentList.Data["+ i +"].ApplyNumber");
				dataItem.BizId = _ctx.StringValue("GetAllPatentList.Data["+ i +"].BizId");
				dataItem.Name = _ctx.StringValue("GetAllPatentList.Data["+ i +"].Name");
				dataItem.Owner = _ctx.StringValue("GetAllPatentList.Data["+ i +"].Owner");
				dataItem.PayStatus = _ctx.IntegerValue("GetAllPatentList.Data["+ i +"].PayStatus");
				dataItem.SoldStatus = _ctx.IntegerValue("GetAllPatentList.Data["+ i +"].SoldStatus");
				dataItem.Type = _ctx.StringValue("GetAllPatentList.Data["+ i +"].Type");
				dataItem.Year = _ctx.IntegerValue("GetAllPatentList.Data["+ i +"].Year");
				dataItem.PayEndDate = _ctx.StringValue("GetAllPatentList.Data["+ i +"].PayEndDate");
				dataItem.DiscountPrice = _ctx.FloatValue("GetAllPatentList.Data["+ i +"].DiscountPrice");
				dataItem.PatentDiscard = _ctx.BooleanValue("GetAllPatentList.Data["+ i +"].PatentDiscard");
				dataItem.PatentStatus = _ctx.StringValue("GetAllPatentList.Data["+ i +"].PatentStatus");

				getAllPatentListResponse_data.Add(dataItem);
			}
			getAllPatentListResponse.Data = getAllPatentListResponse_data;
        
			return getAllPatentListResponse;
        }
    }
}
