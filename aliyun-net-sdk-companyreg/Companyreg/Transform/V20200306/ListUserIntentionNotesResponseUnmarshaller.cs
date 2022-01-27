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
    public class ListUserIntentionNotesResponseUnmarshaller
    {
        public static ListUserIntentionNotesResponse Unmarshall(UnmarshallerContext _ctx)
        {
			ListUserIntentionNotesResponse listUserIntentionNotesResponse = new ListUserIntentionNotesResponse();

			listUserIntentionNotesResponse.HttpResponse = _ctx.HttpResponse;
			listUserIntentionNotesResponse.PageNum = _ctx.IntegerValue("ListUserIntentionNotes.PageNum");
			listUserIntentionNotesResponse.PageSize = _ctx.IntegerValue("ListUserIntentionNotes.PageSize");
			listUserIntentionNotesResponse.RequestId = _ctx.StringValue("ListUserIntentionNotes.RequestId");
			listUserIntentionNotesResponse.Success = _ctx.BooleanValue("ListUserIntentionNotes.Success");
			listUserIntentionNotesResponse.TotalItemNum = _ctx.IntegerValue("ListUserIntentionNotes.TotalItemNum");
			listUserIntentionNotesResponse.TotalPageNum = _ctx.IntegerValue("ListUserIntentionNotes.TotalPageNum");

			List<ListUserIntentionNotesResponse.ListUserIntentionNotes_OpateLogs> listUserIntentionNotesResponse_data = new List<ListUserIntentionNotesResponse.ListUserIntentionNotes_OpateLogs>();
			for (int i = 0; i < _ctx.Length("ListUserIntentionNotes.Data.Length"); i++) {
				ListUserIntentionNotesResponse.ListUserIntentionNotes_OpateLogs opateLogs = new ListUserIntentionNotesResponse.ListUserIntentionNotes_OpateLogs();
				opateLogs.CreateTime = _ctx.StringValue("ListUserIntentionNotes.Data["+ i +"].CreateTime");
				opateLogs.Note = _ctx.StringValue("ListUserIntentionNotes.Data["+ i +"].Note");

				listUserIntentionNotesResponse_data.Add(opateLogs);
			}
			listUserIntentionNotesResponse.Data = listUserIntentionNotesResponse_data;
        
			return listUserIntentionNotesResponse;
        }
    }
}
