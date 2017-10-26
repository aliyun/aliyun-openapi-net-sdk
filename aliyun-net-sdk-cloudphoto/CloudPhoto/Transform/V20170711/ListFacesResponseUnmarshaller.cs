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
using Aliyun.Acs.Core.Transform;
using Aliyun.Acs.CloudPhoto.Model.V20170711;
using System;
using System.Collections.Generic;

namespace Aliyun.Acs.CloudPhoto.Transform.V20170711
{
    public class ListFacesResponseUnmarshaller
    {
        public static ListFacesResponse Unmarshall(UnmarshallerContext context)
        {
			ListFacesResponse listFacesResponse = new ListFacesResponse();

			listFacesResponse.HttpResponse = context.HttpResponse;
			listFacesResponse.Code = context.StringValue("ListFaces.Code");
			listFacesResponse.Message = context.StringValue("ListFaces.Message");
			listFacesResponse.NextCursor = context.StringValue("ListFaces.NextCursor");
			listFacesResponse.TotalCount = context.IntegerValue("ListFaces.TotalCount");
			listFacesResponse.RequestId = context.StringValue("ListFaces.RequestId");
			listFacesResponse.Action = context.StringValue("ListFaces.Action");

			List<ListFacesResponse.ListFaces_Face> listFacesResponse_faces = new List<ListFacesResponse.ListFaces_Face>();
			for (int i = 0; i < context.Length("ListFaces.Faces.Length"); i++) {
				ListFacesResponse.ListFaces_Face face = new ListFacesResponse.ListFaces_Face();
				face.Id = context.LongValue("ListFaces.Faces["+ i +"].Id");
				face.Name = context.StringValue("ListFaces.Faces["+ i +"].Name");
				face.PhotosCount = context.IntegerValue("ListFaces.Faces["+ i +"].PhotosCount");
				face.State = context.StringValue("ListFaces.Faces["+ i +"].State");
				face.IsMe = context.BooleanValue("ListFaces.Faces["+ i +"].IsMe");
				face.Ctime = context.LongValue("ListFaces.Faces["+ i +"].Ctime");
				face.Mtime = context.LongValue("ListFaces.Faces["+ i +"].Mtime");

				List<string> face_axis = new List<string>();
				for (int j = 0; j < context.Length("ListFaces.Faces["+ i +"].Axis.Length"); j++) {
					face_axis.Add(context.StringValue("ListFaces.Faces["+ i +"].Axis["+ j +"]"));
				}
				face.Axis = face_axis;

				ListFacesResponse.ListFaces_Face.ListFaces_Cover cover = new ListFacesResponse.ListFaces_Face.ListFaces_Cover();
				cover.Id = context.LongValue("ListFaces.Faces["+ i +"].Cover.Id");
				cover.Title = context.StringValue("ListFaces.Faces["+ i +"].Cover.Title");
				cover.FileId = context.StringValue("ListFaces.Faces["+ i +"].Cover.FileId");
				cover.State = context.StringValue("ListFaces.Faces["+ i +"].Cover.State");
				cover.Md5 = context.StringValue("ListFaces.Faces["+ i +"].Cover.Md5");
				cover.IsVideo = context.BooleanValue("ListFaces.Faces["+ i +"].Cover.IsVideo");
				cover.Width = context.LongValue("ListFaces.Faces["+ i +"].Cover.Width");
				cover.Height = context.LongValue("ListFaces.Faces["+ i +"].Cover.Height");
				cover.Ctime = context.LongValue("ListFaces.Faces["+ i +"].Cover.Ctime");
				cover.Mtime = context.LongValue("ListFaces.Faces["+ i +"].Cover.Mtime");
				cover.Remark = context.StringValue("ListFaces.Faces["+ i +"].Cover.Remark");
				face.Cover = cover;

				listFacesResponse_faces.Add(face);
			}
			listFacesResponse.Faces = listFacesResponse_faces;
        
			return listFacesResponse;
        }
    }
}