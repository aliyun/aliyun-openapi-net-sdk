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
using Aliyun.Acs.OutboundBot.Model.V20191226;

namespace Aliyun.Acs.OutboundBot.Transform.V20191226
{
    public class ListMediaResponseUnmarshaller
    {
        public static ListMediaResponse Unmarshall(UnmarshallerContext _ctx)
        {
			ListMediaResponse listMediaResponse = new ListMediaResponse();

			listMediaResponse.HttpResponse = _ctx.HttpResponse;
			listMediaResponse.Code = _ctx.StringValue("ListMedia.Code");
			listMediaResponse.HttpStatusCode = _ctx.IntegerValue("ListMedia.HttpStatusCode");
			listMediaResponse.Message = _ctx.StringValue("ListMedia.Message");
			listMediaResponse.PageNumber = _ctx.IntegerValue("ListMedia.PageNumber");
			listMediaResponse.PageSize = _ctx.IntegerValue("ListMedia.PageSize");
			listMediaResponse.RequestId = _ctx.StringValue("ListMedia.RequestId");
			listMediaResponse.Success = _ctx.BooleanValue("ListMedia.Success");
			listMediaResponse.TotalCount = _ctx.IntegerValue("ListMedia.TotalCount");

			List<ListMediaResponse.ListMedia_Media> listMediaResponse_mediaList = new List<ListMediaResponse.ListMedia_Media>();
			for (int i = 0; i < _ctx.Length("ListMedia.MediaList.Length"); i++) {
				ListMediaResponse.ListMedia_Media media = new ListMediaResponse.ListMedia_Media();
				media.MediaId = _ctx.StringValue("ListMedia.MediaList["+ i +"].MediaId");
				media.Name = _ctx.StringValue("ListMedia.MediaList["+ i +"].Name");

				listMediaResponse_mediaList.Add(media);
			}
			listMediaResponse.MediaList = listMediaResponse_mediaList;
        
			return listMediaResponse;
        }
    }
}
