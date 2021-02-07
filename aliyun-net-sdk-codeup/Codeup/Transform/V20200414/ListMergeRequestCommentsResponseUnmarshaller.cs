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
using Aliyun.Acs.codeup.Model.V20200414;

namespace Aliyun.Acs.codeup.Transform.V20200414
{
    public class ListMergeRequestCommentsResponseUnmarshaller
    {
        public static ListMergeRequestCommentsResponse Unmarshall(UnmarshallerContext _ctx)
        {
			ListMergeRequestCommentsResponse listMergeRequestCommentsResponse = new ListMergeRequestCommentsResponse();

			listMergeRequestCommentsResponse.HttpResponse = _ctx.HttpResponse;
			listMergeRequestCommentsResponse.ErrorCode = _ctx.StringValue("ListMergeRequestComments.ErrorCode");
			listMergeRequestCommentsResponse.ErrorMessage = _ctx.StringValue("ListMergeRequestComments.ErrorMessage");
			listMergeRequestCommentsResponse.RequestId = _ctx.StringValue("ListMergeRequestComments.RequestId");
			listMergeRequestCommentsResponse.Success = _ctx.BooleanValue("ListMergeRequestComments.Success");
			listMergeRequestCommentsResponse.Total = _ctx.LongValue("ListMergeRequestComments.Total");

			List<ListMergeRequestCommentsResponse.ListMergeRequestComments_ResultItem> listMergeRequestCommentsResponse_result = new List<ListMergeRequestCommentsResponse.ListMergeRequestComments_ResultItem>();
			for (int i = 0; i < _ctx.Length("ListMergeRequestComments.Result.Length"); i++) {
				ListMergeRequestCommentsResponse.ListMergeRequestComments_ResultItem resultItem = new ListMergeRequestCommentsResponse.ListMergeRequestComments_ResultItem();
				resultItem.Closed = _ctx.IntegerValue("ListMergeRequestComments.Result["+ i +"].Closed");
				resultItem.CreatedAt = _ctx.StringValue("ListMergeRequestComments.Result["+ i +"].CreatedAt");
				resultItem.Id = _ctx.LongValue("ListMergeRequestComments.Result["+ i +"].Id");
				resultItem.IsDraft = _ctx.BooleanValue("ListMergeRequestComments.Result["+ i +"].IsDraft");
				resultItem.Line = _ctx.LongValue("ListMergeRequestComments.Result["+ i +"].Line");
				resultItem.Note = _ctx.StringValue("ListMergeRequestComments.Result["+ i +"].Note");
				resultItem.OutDated = _ctx.BooleanValue("ListMergeRequestComments.Result["+ i +"].OutDated");
				resultItem.ParentNoteId = _ctx.LongValue("ListMergeRequestComments.Result["+ i +"].ParentNoteId");
				resultItem.Path = _ctx.StringValue("ListMergeRequestComments.Result["+ i +"].Path");
				resultItem.ProjectId = _ctx.LongValue("ListMergeRequestComments.Result["+ i +"].ProjectId");
				resultItem.RangeContext = _ctx.StringValue("ListMergeRequestComments.Result["+ i +"].RangeContext");
				resultItem.Side = _ctx.StringValue("ListMergeRequestComments.Result["+ i +"].Side");
				resultItem.UpdatedAt = _ctx.StringValue("ListMergeRequestComments.Result["+ i +"].UpdatedAt");

				ListMergeRequestCommentsResponse.ListMergeRequestComments_ResultItem.ListMergeRequestComments_Author author = new ListMergeRequestCommentsResponse.ListMergeRequestComments_ResultItem.ListMergeRequestComments_Author();
				author.AvatarUrl = _ctx.StringValue("ListMergeRequestComments.Result["+ i +"].Author.AvatarUrl");
				author.Email = _ctx.StringValue("ListMergeRequestComments.Result["+ i +"].Author.Email");
				author.ExternUserId = _ctx.StringValue("ListMergeRequestComments.Result["+ i +"].Author.ExternUserId");
				author.Id = _ctx.LongValue("ListMergeRequestComments.Result["+ i +"].Author.Id");
				author.Name = _ctx.StringValue("ListMergeRequestComments.Result["+ i +"].Author.Name");
				resultItem.Author = author;

				listMergeRequestCommentsResponse_result.Add(resultItem);
			}
			listMergeRequestCommentsResponse.Result = listMergeRequestCommentsResponse_result;
        
			return listMergeRequestCommentsResponse;
        }
    }
}
