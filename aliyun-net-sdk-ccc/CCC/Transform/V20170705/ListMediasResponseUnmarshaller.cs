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
        public static ListMediasResponse Unmarshall(UnmarshallerContext context)
        {
			ListMediasResponse listMediasResponse = new ListMediasResponse();

			listMediasResponse.HttpResponse = context.HttpResponse;
			listMediasResponse.RequestId = context.StringValue("ListMedias.RequestId");
			listMediasResponse.Success = context.BooleanValue("ListMedias.Success");
			listMediasResponse.Code = context.StringValue("ListMedias.Code");
			listMediasResponse.Message = context.StringValue("ListMedias.Message");
			listMediasResponse.HttpStatusCode = context.IntegerValue("ListMedias.HttpStatusCode");

			ListMediasResponse.ListMedias_Medias medias = new ListMediasResponse.ListMedias_Medias();
			medias.TotalCount = context.IntegerValue("ListMedias.Medias.TotalCount");
			medias.PageNumber = context.IntegerValue("ListMedias.Medias.PageNumber");
			medias.PageSize = context.IntegerValue("ListMedias.Medias.PageSize");

			List<ListMediasResponse.ListMedias_Medias.ListMedias_Media> medias_list = new List<ListMediasResponse.ListMedias_Medias.ListMedias_Media>();
			for (int i = 0; i < context.Length("ListMedias.Medias.List.Length"); i++) {
				ListMediasResponse.ListMedias_Medias.ListMedias_Media media = new ListMediasResponse.ListMedias_Medias.ListMedias_Media();
				media.Instance = context.StringValue("ListMedias.Medias.List["+ i +"].Instance");
				media.Name = context.StringValue("ListMedias.Medias.List["+ i +"].Name");
				media.Description = context.StringValue("ListMedias.Medias.List["+ i +"].Description");
				media.Type = context.StringValue("ListMedias.Medias.List["+ i +"].Type");
				media.Content = context.StringValue("ListMedias.Medias.List["+ i +"].Content");
				media.FilePath = context.StringValue("ListMedias.Medias.List["+ i +"].FilePath");
				media.FileName = context.StringValue("ListMedias.Medias.List["+ i +"].FileName");
				media.OssFileName = context.StringValue("ListMedias.Medias.List["+ i +"].OssFileName");
				media.Status = context.StringValue("ListMedias.Medias.List["+ i +"].Status");

				medias_list.Add(media);
			}
			medias.List = medias_list;
			listMediasResponse.Medias = medias;
        
			return listMediasResponse;
        }
    }
}
