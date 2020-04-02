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
using Aliyun.Acs.linkedmall.Model.V20180116;

namespace Aliyun.Acs.linkedmall.Transform.V20180116
{
    public class QueryMovieCommentsResponseUnmarshaller
    {
        public static QueryMovieCommentsResponse Unmarshall(UnmarshallerContext context)
        {
			QueryMovieCommentsResponse queryMovieCommentsResponse = new QueryMovieCommentsResponse();

			queryMovieCommentsResponse.HttpResponse = context.HttpResponse;
			queryMovieCommentsResponse.RequestId = context.StringValue("QueryMovieComments.RequestId");
			queryMovieCommentsResponse.LogsId = context.StringValue("QueryMovieComments.LogsId");
			queryMovieCommentsResponse.SubCode = context.StringValue("QueryMovieComments.SubCode");
			queryMovieCommentsResponse.SubMessage = context.StringValue("QueryMovieComments.SubMessage");
			queryMovieCommentsResponse.Code = context.StringValue("QueryMovieComments.Code");
			queryMovieCommentsResponse.Success = context.BooleanValue("QueryMovieComments.Success");
			queryMovieCommentsResponse.Message = context.StringValue("QueryMovieComments.Message");
			queryMovieCommentsResponse.Count = context.LongValue("QueryMovieComments.Count");

			List<QueryMovieCommentsResponse.QueryMovieComments_Comment> queryMovieCommentsResponse_commentList = new List<QueryMovieCommentsResponse.QueryMovieComments_Comment>();
			for (int i = 0; i < context.Length("QueryMovieComments.CommentList.Length"); i++) {
				QueryMovieCommentsResponse.QueryMovieComments_Comment comment = new QueryMovieCommentsResponse.QueryMovieComments_Comment();
				comment.CommentTime = context.StringValue("QueryMovieComments.CommentList["+ i +"].CommentTime");
				comment.Content = context.StringValue("QueryMovieComments.CommentList["+ i +"].Content");
				comment.FavorCount = context.LongValue("QueryMovieComments.CommentList["+ i +"].FavorCount");
				comment.Id = context.LongValue("QueryMovieComments.CommentList["+ i +"].Id");
				comment.NickName = context.StringValue("QueryMovieComments.CommentList["+ i +"].NickName");
				comment.Remark = context.LongValue("QueryMovieComments.CommentList["+ i +"].Remark");
				comment.MovieId = context.LongValue("QueryMovieComments.CommentList["+ i +"].MovieId");
				comment.Subject = context.StringValue("QueryMovieComments.CommentList["+ i +"].Subject");

				queryMovieCommentsResponse_commentList.Add(comment);
			}
			queryMovieCommentsResponse.CommentList = queryMovieCommentsResponse_commentList;
        
			return queryMovieCommentsResponse;
        }
    }
}
