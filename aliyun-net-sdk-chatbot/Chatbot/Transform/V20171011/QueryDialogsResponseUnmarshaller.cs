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
using Aliyun.Acs.Core.Transform;
using Aliyun.Acs.Chatbot.Model.V20171011;
using System;
using System.Collections.Generic;

namespace Aliyun.Acs.Chatbot.Transform.V20171011
{
    public class QueryDialogsResponseUnmarshaller
    {
        public static QueryDialogsResponse Unmarshall(UnmarshallerContext context)
        {
			QueryDialogsResponse queryDialogsResponse = new QueryDialogsResponse();

			queryDialogsResponse.HttpResponse = context.HttpResponse;
			queryDialogsResponse.RequestId = context.StringValue("QueryDialogs.RequestId");
			queryDialogsResponse.PageSize = context.IntegerValue("QueryDialogs.PageSize");
			queryDialogsResponse.PageNumber = context.IntegerValue("QueryDialogs.PageNumber");
			queryDialogsResponse.TotalCount = context.IntegerValue("QueryDialogs.TotalCount");

			List<QueryDialogsResponse.QueryDialogs_Dialog> queryDialogsResponse_dialogs = new List<QueryDialogsResponse.QueryDialogs_Dialog>();
			for (int i = 0; i < context.Length("QueryDialogs.Dialogs.Length"); i++) {
				QueryDialogsResponse.QueryDialogs_Dialog dialog = new QueryDialogsResponse.QueryDialogs_Dialog();
				dialog.DialogId = context.LongValue("QueryDialogs.Dialogs["+ i +"].DialogId");
				dialog.DialogName = context.StringValue("QueryDialogs.Dialogs["+ i +"].DialogName");
				dialog.Description = context.StringValue("QueryDialogs.Dialogs["+ i +"].Description");
				dialog.CreateTime = context.StringValue("QueryDialogs.Dialogs["+ i +"].CreateTime");
				dialog.ModifyTime = context.StringValue("QueryDialogs.Dialogs["+ i +"].ModifyTime");
				dialog.CreateUserId = context.StringValue("QueryDialogs.Dialogs["+ i +"].CreateUserId");
				dialog.CreateUserName = context.StringValue("QueryDialogs.Dialogs["+ i +"].CreateUserName");
				dialog.ModifyUserId = context.StringValue("QueryDialogs.Dialogs["+ i +"].ModifyUserId");
				dialog.ModifyUserName = context.StringValue("QueryDialogs.Dialogs["+ i +"].ModifyUserName");
				dialog.IsSampleDialog = context.BooleanValue("QueryDialogs.Dialogs["+ i +"].IsSampleDialog");
				dialog.Status = context.IntegerValue("QueryDialogs.Dialogs["+ i +"].Status");
				dialog.IsOnline = context.BooleanValue("QueryDialogs.Dialogs["+ i +"].IsOnline");

				queryDialogsResponse_dialogs.Add(dialog);
			}
			queryDialogsResponse.Dialogs = queryDialogsResponse_dialogs;
        
			return queryDialogsResponse;
        }
    }
}