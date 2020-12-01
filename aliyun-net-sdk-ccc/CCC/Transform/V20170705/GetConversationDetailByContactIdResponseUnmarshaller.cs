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
    public class GetConversationDetailByContactIdResponseUnmarshaller
    {
        public static GetConversationDetailByContactIdResponse Unmarshall(UnmarshallerContext _ctx)
        {
			GetConversationDetailByContactIdResponse getConversationDetailByContactIdResponse = new GetConversationDetailByContactIdResponse();

			getConversationDetailByContactIdResponse.HttpResponse = _ctx.HttpResponse;
			getConversationDetailByContactIdResponse.RequestId = _ctx.StringValue("GetConversationDetailByContactId.RequestId");
			getConversationDetailByContactIdResponse.Success = _ctx.BooleanValue("GetConversationDetailByContactId.Success");
			getConversationDetailByContactIdResponse.Code = _ctx.StringValue("GetConversationDetailByContactId.Code");
			getConversationDetailByContactIdResponse.Message = _ctx.StringValue("GetConversationDetailByContactId.Message");
			getConversationDetailByContactIdResponse.HttpStatusCode = _ctx.IntegerValue("GetConversationDetailByContactId.HttpStatusCode");

			GetConversationDetailByContactIdResponse.GetConversationDetailByContactId_DataList dataList = new GetConversationDetailByContactIdResponse.GetConversationDetailByContactId_DataList();
			dataList.TotalCount = _ctx.IntegerValue("GetConversationDetailByContactId.DataList.TotalCount");
			dataList.PageNumber = _ctx.IntegerValue("GetConversationDetailByContactId.DataList.PageNumber");
			dataList.PageSize = _ctx.IntegerValue("GetConversationDetailByContactId.DataList.PageSize");

			List<GetConversationDetailByContactIdResponse.GetConversationDetailByContactId_DataList.GetConversationDetailByContactId_QualityCheckPhrase> dataList_list = new List<GetConversationDetailByContactIdResponse.GetConversationDetailByContactId_DataList.GetConversationDetailByContactId_QualityCheckPhrase>();
			for (int i = 0; i < _ctx.Length("GetConversationDetailByContactId.DataList.List.Length"); i++) {
				GetConversationDetailByContactIdResponse.GetConversationDetailByContactId_DataList.GetConversationDetailByContactId_QualityCheckPhrase qualityCheckPhrase = new GetConversationDetailByContactIdResponse.GetConversationDetailByContactId_DataList.GetConversationDetailByContactId_QualityCheckPhrase();
				qualityCheckPhrase.Identity = _ctx.StringValue("GetConversationDetailByContactId.DataList.List["+ i +"].Identity");
				qualityCheckPhrase.Role = _ctx.StringValue("GetConversationDetailByContactId.DataList.List["+ i +"].Role");
				qualityCheckPhrase.Words = _ctx.StringValue("GetConversationDetailByContactId.DataList.List["+ i +"].Words");
				qualityCheckPhrase.Begin = _ctx.LongValue("GetConversationDetailByContactId.DataList.List["+ i +"].Begin");
				qualityCheckPhrase.End = _ctx.LongValue("GetConversationDetailByContactId.DataList.List["+ i +"].End");

				dataList_list.Add(qualityCheckPhrase);
			}
			dataList.List = dataList_list;
			getConversationDetailByContactIdResponse.DataList = dataList;
        
			return getConversationDetailByContactIdResponse;
        }
    }
}
