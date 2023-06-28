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
    public class PageIncrementMembersResponseUnmarshaller
    {
        public static PageIncrementMembersResponse Unmarshall(UnmarshallerContext _ctx)
        {
			PageIncrementMembersResponse pageIncrementMembersResponse = new PageIncrementMembersResponse();

			pageIncrementMembersResponse.HttpResponse = _ctx.HttpResponse;
			pageIncrementMembersResponse.TotalCount = _ctx.IntegerValue("PageIncrementMembers.TotalCount");
			pageIncrementMembersResponse.RequestId = _ctx.StringValue("PageIncrementMembers.RequestId");
			pageIncrementMembersResponse.Success = _ctx.StringValue("PageIncrementMembers.Success");
			pageIncrementMembersResponse.ErrorCode = _ctx.StringValue("PageIncrementMembers.ErrorCode");
			pageIncrementMembersResponse.ErrorMessage = _ctx.StringValue("PageIncrementMembers.ErrorMessage");

			List<PageIncrementMembersResponse.PageIncrementMembers_DataItem> pageIncrementMembersResponse_data = new List<PageIncrementMembersResponse.PageIncrementMembers_DataItem>();
			for (int i = 0; i < _ctx.Length("PageIncrementMembers.Data.Length"); i++) {
				PageIncrementMembersResponse.PageIncrementMembers_DataItem dataItem = new PageIncrementMembersResponse.PageIncrementMembers_DataItem();
				dataItem.OpenMerchantId = _ctx.StringValue("PageIncrementMembers.Data["+ i +"].OpenMerchantId");
				dataItem.OuterMemberId = _ctx.StringValue("PageIncrementMembers.Data["+ i +"].OuterMemberId");
				dataItem.Name = _ctx.StringValue("PageIncrementMembers.Data["+ i +"].Name");
				dataItem.Mobile = _ctx.StringValue("PageIncrementMembers.Data["+ i +"].Mobile");
				dataItem.MixMobile = _ctx.StringValue("PageIncrementMembers.Data["+ i +"].MixMobile");
				dataItem.Birthday = _ctx.StringValue("PageIncrementMembers.Data["+ i +"].Birthday");
				dataItem.Province = _ctx.StringValue("PageIncrementMembers.Data["+ i +"].Province");
				dataItem.City = _ctx.StringValue("PageIncrementMembers.Data["+ i +"].City");
				dataItem.Sex = _ctx.StringValue("PageIncrementMembers.Data["+ i +"].Sex");
				dataItem.Email = _ctx.StringValue("PageIncrementMembers.Data["+ i +"].Email");
				dataItem.Status = _ctx.IntegerValue("PageIncrementMembers.Data["+ i +"].Status");
				dataItem.EntryChannel = _ctx.StringValue("PageIncrementMembers.Data["+ i +"].EntryChannel");
				dataItem.LevelNum = _ctx.IntegerValue("PageIncrementMembers.Data["+ i +"].LevelNum");
				dataItem.LevelPoints = _ctx.StringValue("PageIncrementMembers.Data["+ i +"].LevelPoints");
				dataItem.ConsumePoints = _ctx.StringValue("PageIncrementMembers.Data["+ i +"].ConsumePoints");
				dataItem.SiteUsers = _ctx.StringValue("PageIncrementMembers.Data["+ i +"].SiteUsers");

				pageIncrementMembersResponse_data.Add(dataItem);
			}
			pageIncrementMembersResponse.Data = pageIncrementMembersResponse_data;
        
			return pageIncrementMembersResponse;
        }
    }
}
