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
using Aliyun.Acs.AppMallsService.Model.V20180224;

namespace Aliyun.Acs.AppMallsService.Transform.V20180224
{
    public class TaobaoFilmGetShowCommentsResponseUnmarshaller
    {
        public static TaobaoFilmGetShowCommentsResponse Unmarshall(UnmarshallerContext context)
        {
			TaobaoFilmGetShowCommentsResponse taobaoFilmGetShowCommentsResponse = new TaobaoFilmGetShowCommentsResponse();

			taobaoFilmGetShowCommentsResponse.HttpResponse = context.HttpResponse;
			taobaoFilmGetShowCommentsResponse.ErrorCode = context.StringValue("TaobaoFilmGetShowComments.ErrorCode");
			taobaoFilmGetShowCommentsResponse.Msg = context.StringValue("TaobaoFilmGetShowComments.Msg");
			taobaoFilmGetShowCommentsResponse.SubCode = context.StringValue("TaobaoFilmGetShowComments.SubCode");
			taobaoFilmGetShowCommentsResponse.SubMsg = context.StringValue("TaobaoFilmGetShowComments.SubMsg");
			taobaoFilmGetShowCommentsResponse.Count = context.LongValue("TaobaoFilmGetShowComments.Count");
			taobaoFilmGetShowCommentsResponse.LogsId = context.StringValue("TaobaoFilmGetShowComments.LogsId");
			taobaoFilmGetShowCommentsResponse.RequestId = context.StringValue("TaobaoFilmGetShowComments.RequestId");

			List<TaobaoFilmGetShowCommentsResponse.TaobaoFilmGetShowComments_CommentListItem> taobaoFilmGetShowCommentsResponse_commentList = new List<TaobaoFilmGetShowCommentsResponse.TaobaoFilmGetShowComments_CommentListItem>();
			for (int i = 0; i < context.Length("TaobaoFilmGetShowComments.CommentList.Length"); i++) {
				TaobaoFilmGetShowCommentsResponse.TaobaoFilmGetShowComments_CommentListItem commentListItem = new TaobaoFilmGetShowCommentsResponse.TaobaoFilmGetShowComments_CommentListItem();
				commentListItem.CommentTime = context.StringValue("TaobaoFilmGetShowComments.CommentList["+ i +"].CommentTime");
				commentListItem.Content = context.StringValue("TaobaoFilmGetShowComments.CommentList["+ i +"].Content");
				commentListItem.FavorCount = context.LongValue("TaobaoFilmGetShowComments.CommentList["+ i +"].FavorCount");
				commentListItem.Id = context.LongValue("TaobaoFilmGetShowComments.CommentList["+ i +"].Id");
				commentListItem.NickName = context.StringValue("TaobaoFilmGetShowComments.CommentList["+ i +"].NickName");
				commentListItem.Remark = context.LongValue("TaobaoFilmGetShowComments.CommentList["+ i +"].Remark");
				commentListItem.ShowId = context.LongValue("TaobaoFilmGetShowComments.CommentList["+ i +"].ShowId");
				commentListItem.Subject = context.StringValue("TaobaoFilmGetShowComments.CommentList["+ i +"].Subject");

				taobaoFilmGetShowCommentsResponse_commentList.Add(commentListItem);
			}
			taobaoFilmGetShowCommentsResponse.CommentList = taobaoFilmGetShowCommentsResponse_commentList;
        
			return taobaoFilmGetShowCommentsResponse;
        }
    }
}
