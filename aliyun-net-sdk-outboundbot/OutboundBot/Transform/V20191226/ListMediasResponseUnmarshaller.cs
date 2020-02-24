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
    public class ListMediasResponseUnmarshaller
    {
        public static ListMediasResponse Unmarshall(UnmarshallerContext context)
        {
			ListMediasResponse listMediasResponse = new ListMediasResponse();

			listMediasResponse.HttpResponse = context.HttpResponse;
			listMediasResponse.RequestId = context.StringValue("ListMedias.RequestId");
			listMediasResponse.Success = context.BooleanValue("ListMedias.Success");
			listMediasResponse.Code = context.StringValue("ListMedias.Code");
			listMediasResponse.Message = context.StringValue("ListMedias.Message");
			listMediasResponse.HttpStatusCode = context.IntegerValue("ListMedias.HttpStatusCode");
			listMediasResponse.TotalCount = context.IntegerValue("ListMedias.TotalCount");
			listMediasResponse.PageNumber = context.IntegerValue("ListMedias.PageNumber");
			listMediasResponse.PageSize = context.IntegerValue("ListMedias.PageSize");

			List<ListMediasResponse.ListMedias_Media> listMediasResponse_mediaList = new List<ListMediasResponse.ListMedias_Media>();
			for (int i = 0; i < context.Length("ListMedias.MediaList.Length"); i++) {
				ListMediasResponse.ListMedias_Media media = new ListMediasResponse.ListMedias_Media();
				media.MediaId = context.StringValue("ListMedias.MediaList["+ i +"].MediaId");
				media.Name = context.StringValue("ListMedias.MediaList["+ i +"].Name");

				listMediasResponse_mediaList.Add(media);
			}
			listMediasResponse.MediaList = listMediasResponse_mediaList;
        
			return listMediasResponse;
        }
    }
}
