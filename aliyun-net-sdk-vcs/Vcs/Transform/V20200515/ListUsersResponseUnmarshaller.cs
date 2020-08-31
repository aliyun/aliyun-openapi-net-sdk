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
using Aliyun.Acs.Vcs.Model.V20200515;

namespace Aliyun.Acs.Vcs.Transform.V20200515
{
    public class ListUsersResponseUnmarshaller
    {
        public static ListUsersResponse Unmarshall(UnmarshallerContext context)
        {
			ListUsersResponse listUsersResponse = new ListUsersResponse();

			listUsersResponse.HttpResponse = context.HttpResponse;
			listUsersResponse.Code = context.StringValue("ListUsers.Code");
			listUsersResponse.Message = context.StringValue("ListUsers.Message");
			listUsersResponse.RequestId = context.StringValue("ListUsers.RequestId");

			ListUsersResponse.ListUsers_Data data = new ListUsersResponse.ListUsers_Data();
			data.PageNumber = context.LongValue("ListUsers.Data.PageNumber");
			data.PageSize = context.LongValue("ListUsers.Data.PageSize");
			data.Success = context.LongValue("ListUsers.Data.Success");
			data.Total = context.LongValue("ListUsers.Data.Total");

			List<ListUsersResponse.ListUsers_Data.ListUsers_RecordsItem> data_records = new List<ListUsersResponse.ListUsers_Data.ListUsers_RecordsItem>();
			for (int i = 0; i < context.Length("ListUsers.Data.Records.Length"); i++) {
				ListUsersResponse.ListUsers_Data.ListUsers_RecordsItem recordsItem = new ListUsersResponse.ListUsers_Data.ListUsers_RecordsItem();
				recordsItem.UserGroupId = context.IntegerValue("ListUsers.Data.Records["+ i +"].UserGroupId");
				recordsItem.Age = context.StringValue("ListUsers.Data.Records["+ i +"].Age");
				recordsItem.Attachment = context.StringValue("ListUsers.Data.Records["+ i +"].Attachment");
				recordsItem.BizId = context.StringValue("ListUsers.Data.Records["+ i +"].BizId");
				recordsItem.FaceImageUrl = context.StringValue("ListUsers.Data.Records["+ i +"].FaceImageUrl");
				recordsItem.Gender = context.StringValue("ListUsers.Data.Records["+ i +"].Gender");
				recordsItem.IdNumber = context.StringValue("ListUsers.Data.Records["+ i +"].IdNumber");
				recordsItem.UserId = context.IntegerValue("ListUsers.Data.Records["+ i +"].UserId");
				recordsItem.UserName = context.StringValue("ListUsers.Data.Records["+ i +"].UserName");
				recordsItem.IsvSubId = context.StringValue("ListUsers.Data.Records["+ i +"].IsvSubId");
				recordsItem.MatchingRate = context.StringValue("ListUsers.Data.Records["+ i +"].MatchingRate");
				recordsItem.PersonId = context.StringValue("ListUsers.Data.Records["+ i +"].PersonId");

				data_records.Add(recordsItem);
			}
			data.Records = data_records;
			listUsersResponse.Data = data;
        
			return listUsersResponse;
        }
    }
}
