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
    public class ListPhotoFacesResponseUnmarshaller
    {
        public static ListPhotoFacesResponse Unmarshall(UnmarshallerContext context)
        {
			ListPhotoFacesResponse listPhotoFacesResponse = new ListPhotoFacesResponse();

			listPhotoFacesResponse.HttpResponse = context.HttpResponse;
			listPhotoFacesResponse.Code = context.StringValue("ListPhotoFaces.Code");
			listPhotoFacesResponse.Message = context.StringValue("ListPhotoFaces.Message");
			listPhotoFacesResponse.RequestId = context.StringValue("ListPhotoFaces.RequestId");
			listPhotoFacesResponse.Action = context.StringValue("ListPhotoFaces.Action");

			List<ListPhotoFacesResponse.ListPhotoFaces_Face> listPhotoFacesResponse_faces = new List<ListPhotoFacesResponse.ListPhotoFaces_Face>();
			for (int i = 0; i < context.Length("ListPhotoFaces.Faces.Length"); i++) {
				ListPhotoFacesResponse.ListPhotoFaces_Face face = new ListPhotoFacesResponse.ListPhotoFaces_Face();
				face.FaceId = context.LongValue("ListPhotoFaces.Faces["+ i +"].FaceId");
				face.FaceName = context.StringValue("ListPhotoFaces.Faces["+ i +"].FaceName");

				List<string> face_axis = new List<string>();
				for (int j = 0; j < context.Length("ListPhotoFaces.Faces["+ i +"].Axis.Length"); j++) {
					face_axis.Add(context.StringValue("ListPhotoFaces.Faces["+ i +"].Axis["+ j +"]"));
				}
				face.Axis = face_axis;

				listPhotoFacesResponse_faces.Add(face);
			}
			listPhotoFacesResponse.Faces = listPhotoFacesResponse_faces;
        
			return listPhotoFacesResponse;
        }
    }
}