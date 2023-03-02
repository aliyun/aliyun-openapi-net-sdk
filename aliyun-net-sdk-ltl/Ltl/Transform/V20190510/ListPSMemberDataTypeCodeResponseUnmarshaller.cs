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
using Aliyun.Acs.ltl.Model.V20190510;

namespace Aliyun.Acs.ltl.Transform.V20190510
{
    public class ListPSMemberDataTypeCodeResponseUnmarshaller
    {
        public static ListPSMemberDataTypeCodeResponse Unmarshall(UnmarshallerContext _ctx)
        {
			ListPSMemberDataTypeCodeResponse listPSMemberDataTypeCodeResponse = new ListPSMemberDataTypeCodeResponse();

			listPSMemberDataTypeCodeResponse.HttpResponse = _ctx.HttpResponse;
			listPSMemberDataTypeCodeResponse.Code = _ctx.IntegerValue("ListPSMemberDataTypeCode.Code");
			listPSMemberDataTypeCodeResponse.Message = _ctx.StringValue("ListPSMemberDataTypeCode.Message");
			listPSMemberDataTypeCodeResponse.RequestId = _ctx.StringValue("ListPSMemberDataTypeCode.RequestId");
			listPSMemberDataTypeCodeResponse.Success = _ctx.BooleanValue("ListPSMemberDataTypeCode.Success");

			ListPSMemberDataTypeCodeResponse.ListPSMemberDataTypeCode_Data data = new ListPSMemberDataTypeCodeResponse.ListPSMemberDataTypeCode_Data();
			data.Num = _ctx.IntegerValue("ListPSMemberDataTypeCode.Data.Num");
			data.Total = _ctx.IntegerValue("ListPSMemberDataTypeCode.Data.Total");
			data.Size = _ctx.IntegerValue("ListPSMemberDataTypeCode.Data.Size");

			List<ListPSMemberDataTypeCodeResponse.ListPSMemberDataTypeCode_Data.ListPSMemberDataTypeCode_MemberInfo> data_pageData = new List<ListPSMemberDataTypeCodeResponse.ListPSMemberDataTypeCode_Data.ListPSMemberDataTypeCode_MemberInfo>();
			for (int i = 0; i < _ctx.Length("ListPSMemberDataTypeCode.Data.PageData.Length"); i++) {
				ListPSMemberDataTypeCodeResponse.ListPSMemberDataTypeCode_Data.ListPSMemberDataTypeCode_MemberInfo memberInfo = new ListPSMemberDataTypeCodeResponse.ListPSMemberDataTypeCode_Data.ListPSMemberDataTypeCode_MemberInfo();
				memberInfo.MemberId = _ctx.StringValue("ListPSMemberDataTypeCode.Data.PageData["+ i +"].MemberId");
				memberInfo.DataTypeCode = _ctx.StringValue("ListPSMemberDataTypeCode.Data.PageData["+ i +"].DataTypeCode");
				memberInfo.MemberName = _ctx.StringValue("ListPSMemberDataTypeCode.Data.PageData["+ i +"].MemberName");
				memberInfo.MemberUid = _ctx.StringValue("ListPSMemberDataTypeCode.Data.PageData["+ i +"].MemberUid");

				data_pageData.Add(memberInfo);
			}
			data.PageData = data_pageData;
			listPSMemberDataTypeCodeResponse.Data = data;
        
			return listPSMemberDataTypeCodeResponse;
        }
    }
}
