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
using Aliyun.Acs.lto.Model.V20210707;

namespace Aliyun.Acs.lto.Transform.V20210707
{
    public class ListMemberAccessRecordResponseUnmarshaller
    {
        public static ListMemberAccessRecordResponse Unmarshall(UnmarshallerContext _ctx)
        {
			ListMemberAccessRecordResponse listMemberAccessRecordResponse = new ListMemberAccessRecordResponse();

			listMemberAccessRecordResponse.HttpResponse = _ctx.HttpResponse;
			listMemberAccessRecordResponse.Code = _ctx.StringValue("ListMemberAccessRecord.Code");
			listMemberAccessRecordResponse.HttpStatusCode = _ctx.IntegerValue("ListMemberAccessRecord.HttpStatusCode");
			listMemberAccessRecordResponse.Message = _ctx.StringValue("ListMemberAccessRecord.Message");
			listMemberAccessRecordResponse.RequestId = _ctx.StringValue("ListMemberAccessRecord.RequestId");
			listMemberAccessRecordResponse.Success = _ctx.BooleanValue("ListMemberAccessRecord.Success");

			ListMemberAccessRecordResponse.ListMemberAccessRecord_Data data = new ListMemberAccessRecordResponse.ListMemberAccessRecord_Data();
			data.Num = _ctx.IntegerValue("ListMemberAccessRecord.Data.Num");
			data.Total = _ctx.IntegerValue("ListMemberAccessRecord.Data.Total");
			data.Size = _ctx.IntegerValue("ListMemberAccessRecord.Data.Size");

			List<ListMemberAccessRecordResponse.ListMemberAccessRecord_Data.ListMemberAccessRecord_MemberInfo> data_pageData = new List<ListMemberAccessRecordResponse.ListMemberAccessRecord_Data.ListMemberAccessRecord_MemberInfo>();
			for (int i = 0; i < _ctx.Length("ListMemberAccessRecord.Data.PageData.Length"); i++) {
				ListMemberAccessRecordResponse.ListMemberAccessRecord_Data.ListMemberAccessRecord_MemberInfo memberInfo = new ListMemberAccessRecordResponse.ListMemberAccessRecord_Data.ListMemberAccessRecord_MemberInfo();
				memberInfo.Status = _ctx.StringValue("ListMemberAccessRecord.Data.PageData["+ i +"].Status");
				memberInfo.AuthorizedCount = _ctx.LongValue("ListMemberAccessRecord.Data.PageData["+ i +"].AuthorizedCount");
				memberInfo.Remark = _ctx.StringValue("ListMemberAccessRecord.Data.PageData["+ i +"].Remark");
				memberInfo.AdminName = _ctx.StringValue("ListMemberAccessRecord.Data.PageData["+ i +"].AdminName");
				memberInfo.MemberId = _ctx.StringValue("ListMemberAccessRecord.Data.PageData["+ i +"].MemberId");
				memberInfo.Name = _ctx.StringValue("ListMemberAccessRecord.Data.PageData["+ i +"].Name");
				memberInfo.Contactor = _ctx.StringValue("ListMemberAccessRecord.Data.PageData["+ i +"].Contactor");
				memberInfo.Telephony = _ctx.StringValue("ListMemberAccessRecord.Data.PageData["+ i +"].Telephony");
				memberInfo.Uid = _ctx.StringValue("ListMemberAccessRecord.Data.PageData["+ i +"].Uid");
				memberInfo.AccessStatus = _ctx.StringValue("ListMemberAccessRecord.Data.PageData["+ i +"].AccessStatus");
				memberInfo.AccessDate = _ctx.LongValue("ListMemberAccessRecord.Data.PageData["+ i +"].AccessDate");
				memberInfo.MemberResponseDate = _ctx.LongValue("ListMemberAccessRecord.Data.PageData["+ i +"].MemberResponseDate");
				memberInfo.AuthorizedDeviceCount = _ctx.IntegerValue("ListMemberAccessRecord.Data.PageData["+ i +"].AuthorizedDeviceCount");

				data_pageData.Add(memberInfo);
			}
			data.PageData = data_pageData;
			listMemberAccessRecordResponse.Data = data;
        
			return listMemberAccessRecordResponse;
        }
    }
}
