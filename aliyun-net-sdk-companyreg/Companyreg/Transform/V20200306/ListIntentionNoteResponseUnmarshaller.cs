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
    public class ListIntentionNoteResponseUnmarshaller
    {
        public static ListIntentionNoteResponse Unmarshall(UnmarshallerContext _ctx)
        {
			ListIntentionNoteResponse listIntentionNoteResponse = new ListIntentionNoteResponse();

			listIntentionNoteResponse.HttpResponse = _ctx.HttpResponse;
			listIntentionNoteResponse.RequestId = _ctx.StringValue("ListIntentionNote.RequestId");
			listIntentionNoteResponse.TotalItemNum = _ctx.IntegerValue("ListIntentionNote.TotalItemNum");
			listIntentionNoteResponse.CurrentPageNum = _ctx.IntegerValue("ListIntentionNote.CurrentPageNum");
			listIntentionNoteResponse.PageSize = _ctx.IntegerValue("ListIntentionNote.PageSize");
			listIntentionNoteResponse.TotalPageNum = _ctx.IntegerValue("ListIntentionNote.TotalPageNum");

			List<ListIntentionNoteResponse.ListIntentionNote_Note> listIntentionNoteResponse_data = new List<ListIntentionNoteResponse.ListIntentionNote_Note>();
			for (int i = 0; i < _ctx.Length("ListIntentionNote.Data.Length"); i++) {
				ListIntentionNoteResponse.ListIntentionNote_Note note = new ListIntentionNoteResponse.ListIntentionNote_Note();
				note.IntentionBizId = _ctx.StringValue("ListIntentionNote.Data["+ i +"].IntentionBizId");
				note.Note = _ctx.StringValue("ListIntentionNote.Data["+ i +"].Note");
				note.Source = _ctx.IntegerValue("ListIntentionNote.Data["+ i +"].Source");
				note.CreateTime = _ctx.StringValue("ListIntentionNote.Data["+ i +"].CreateTime");
				note.Type = _ctx.StringValue("ListIntentionNote.Data["+ i +"].Type");

				listIntentionNoteResponse_data.Add(note);
			}
			listIntentionNoteResponse.Data = listIntentionNoteResponse_data;
        
			return listIntentionNoteResponse;
        }
    }
}
