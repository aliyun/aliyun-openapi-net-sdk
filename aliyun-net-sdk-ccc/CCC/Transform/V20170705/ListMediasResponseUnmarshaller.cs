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
using Aliyun.Acs.CCC.Model.V20170705;

namespace Aliyun.Acs.CCC.Transform.V20170705
{
    public class ListMediasResponseUnmarshaller
    {
        public static ListMediasResponse Unmarshall(UnmarshallerContext _ctx)
        {
			ListMediasResponse listMediasResponse = new ListMediasResponse();

			listMediasResponse.HttpResponse = _ctx.HttpResponse;
			listMediasResponse.RequestId = _ctx.StringValue("ListMedias.RequestId");
			listMediasResponse.Success = _ctx.BooleanValue("ListMedias.Success");
			listMediasResponse.Code = _ctx.StringValue("ListMedias.Code");
			listMediasResponse.Message = _ctx.StringValue("ListMedias.Message");
			listMediasResponse.HttpStatusCode = _ctx.IntegerValue("ListMedias.HttpStatusCode");

			ListMediasResponse.ListMedias_Medias medias = new ListMediasResponse.ListMedias_Medias();
			medias.TotalCount = _ctx.IntegerValue("ListMedias.Medias.TotalCount");
			medias.PageNumber = _ctx.IntegerValue("ListMedias.Medias.PageNumber");
			medias.PageSize = _ctx.IntegerValue("ListMedias.Medias.PageSize");

			List<ListMediasResponse.ListMedias_Medias.ListMedias_Media> medias_list = new List<ListMediasResponse.ListMedias_Medias.ListMedias_Media>();
			for (int i = 0; i < _ctx.Length("ListMedias.Medias.List.Length"); i++) {
				ListMediasResponse.ListMedias_Medias.ListMedias_Media media = new ListMediasResponse.ListMedias_Medias.ListMedias_Media();
				media.Instance = _ctx.StringValue("ListMedias.Medias.List["+ i +"].Instance");
				media.Name = _ctx.StringValue("ListMedias.Medias.List["+ i +"].Name");
				media.Description = _ctx.StringValue("ListMedias.Medias.List["+ i +"].Description");
				media.Type = _ctx.StringValue("ListMedias.Medias.List["+ i +"].Type");
				media.Content = _ctx.StringValue("ListMedias.Medias.List["+ i +"].Content");
				media.FilePath = _ctx.StringValue("ListMedias.Medias.List["+ i +"].FilePath");
				media.FileName = _ctx.StringValue("ListMedias.Medias.List["+ i +"].FileName");
				media.OssFileName = _ctx.StringValue("ListMedias.Medias.List["+ i +"].OssFileName");
				media.Status = _ctx.StringValue("ListMedias.Medias.List["+ i +"].Status");

				medias_list.Add(media);
			}
			medias.List = medias_list;
			listMediasResponse.Medias = medias;
        
			return listMediasResponse;
        }
    }
}
