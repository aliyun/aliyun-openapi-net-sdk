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
using Aliyun.Acs.retailadvqa.Model.V20230417;

namespace Aliyun.Acs.retailadvqa.Transform.V20230417
{
    public class PageMembersResponseUnmarshaller
    {
        public static PageMembersResponse Unmarshall(UnmarshallerContext _ctx)
        {
			PageMembersResponse pageMembersResponse = new PageMembersResponse();

			pageMembersResponse.HttpResponse = _ctx.HttpResponse;
			pageMembersResponse.TotalCount = _ctx.IntegerValue("PageMembers.TotalCount");
			pageMembersResponse.RequestId = _ctx.StringValue("PageMembers.RequestId");
			pageMembersResponse.Success = _ctx.BooleanValue("PageMembers.Success");
			pageMembersResponse.ErrorCode = _ctx.StringValue("PageMembers.ErrorCode");
			pageMembersResponse.ErrorMessage = _ctx.StringValue("PageMembers.ErrorMessage");

			List<PageMembersResponse.PageMembers_DataItem> pageMembersResponse_data = new List<PageMembersResponse.PageMembers_DataItem>();
			for (int i = 0; i < _ctx.Length("PageMembers.Data.Length"); i++) {
				PageMembersResponse.PageMembers_DataItem dataItem = new PageMembersResponse.PageMembers_DataItem();
				dataItem.OpenMerchantId = _ctx.StringValue("PageMembers.Data["+ i +"].OpenMerchantId");
				dataItem.OuterMemberId = _ctx.StringValue("PageMembers.Data["+ i +"].OuterMemberId");
				dataItem.Name = _ctx.StringValue("PageMembers.Data["+ i +"].Name");
				dataItem.Mobile = _ctx.StringValue("PageMembers.Data["+ i +"].Mobile");
				dataItem.MixMobile = _ctx.StringValue("PageMembers.Data["+ i +"].MixMobile");
				dataItem.Birthday = _ctx.StringValue("PageMembers.Data["+ i +"].Birthday");
				dataItem.Province = _ctx.StringValue("PageMembers.Data["+ i +"].Province");
				dataItem.City = _ctx.StringValue("PageMembers.Data["+ i +"].City");
				dataItem.Sex = _ctx.StringValue("PageMembers.Data["+ i +"].Sex");
				dataItem.Email = _ctx.StringValue("PageMembers.Data["+ i +"].Email");
				dataItem.Status = _ctx.IntegerValue("PageMembers.Data["+ i +"].Status");
				dataItem.EntryChannel = _ctx.StringValue("PageMembers.Data["+ i +"].EntryChannel");
				dataItem.LevelNum = _ctx.IntegerValue("PageMembers.Data["+ i +"].LevelNum");
				dataItem.LevelPoints = _ctx.StringValue("PageMembers.Data["+ i +"].LevelPoints");
				dataItem.ConsumePoints = _ctx.StringValue("PageMembers.Data["+ i +"].ConsumePoints");
				dataItem.SiteUsers = _ctx.StringValue("PageMembers.Data["+ i +"].SiteUsers");

				pageMembersResponse_data.Add(dataItem);
			}
			pageMembersResponse.Data = pageMembersResponse_data;
        
			return pageMembersResponse;
        }
    }
}
