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
using Aliyun.Acs.companyreg.Model.V20200306;

namespace Aliyun.Acs.companyreg.Transform.V20200306
{
    public class ListUserIntentionsResponseUnmarshaller
    {
        public static ListUserIntentionsResponse Unmarshall(UnmarshallerContext _ctx)
        {
			ListUserIntentionsResponse listUserIntentionsResponse = new ListUserIntentionsResponse();

			listUserIntentionsResponse.HttpResponse = _ctx.HttpResponse;
			listUserIntentionsResponse.RequestId = _ctx.StringValue("ListUserIntentions.RequestId");
			listUserIntentionsResponse.TotalItemNum = _ctx.IntegerValue("ListUserIntentions.TotalItemNum");
			listUserIntentionsResponse.CurrentPageNum = _ctx.IntegerValue("ListUserIntentions.CurrentPageNum");
			listUserIntentionsResponse.PageSize = _ctx.IntegerValue("ListUserIntentions.PageSize");
			listUserIntentionsResponse.TotalPageNum = _ctx.IntegerValue("ListUserIntentions.TotalPageNum");

			List<ListUserIntentionsResponse.ListUserIntentions_Intention> listUserIntentionsResponse_data = new List<ListUserIntentionsResponse.ListUserIntentions_Intention>();
			for (int i = 0; i < _ctx.Length("ListUserIntentions.Data.Length"); i++) {
				ListUserIntentionsResponse.ListUserIntentions_Intention intention = new ListUserIntentionsResponse.ListUserIntentions_Intention();
				intention.UserId = _ctx.StringValue("ListUserIntentions.Data["+ i +"].UserId");
				intention.Mobile = _ctx.StringValue("ListUserIntentions.Data["+ i +"].Mobile");
				intention.ContactName = _ctx.StringValue("ListUserIntentions.Data["+ i +"].ContactName");
				intention.BizType = _ctx.StringValue("ListUserIntentions.Data["+ i +"].BizType");
				intention.BizId = _ctx.StringValue("ListUserIntentions.Data["+ i +"].BizId");
				intention.Description = _ctx.StringValue("ListUserIntentions.Data["+ i +"].Description");
				intention.Status = _ctx.IntegerValue("ListUserIntentions.Data["+ i +"].Status");
				intention.UpdateTime = _ctx.LongValue("ListUserIntentions.Data["+ i +"].UpdateTime");
				intention.CreateTime = _ctx.LongValue("ListUserIntentions.Data["+ i +"].CreateTime");
				intention.Area = _ctx.StringValue("ListUserIntentions.Data["+ i +"].Area");
				intention.Reason = _ctx.StringValue("ListUserIntentions.Data["+ i +"].Reason");

				listUserIntentionsResponse_data.Add(intention);
			}
			listUserIntentionsResponse.Data = listUserIntentionsResponse_data;
        
			return listUserIntentionsResponse;
        }
    }
}
