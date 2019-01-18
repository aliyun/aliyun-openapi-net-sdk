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
using Aliyun.Acs.imm.Model.V20170906;
using System;
using System.Collections.Generic;

namespace Aliyun.Acs.imm.Transform.V20170906
{
    public class ListImageFacesResponseUnmarshaller
    {
        public static ListImageFacesResponse Unmarshall(UnmarshallerContext context)
        {
			ListImageFacesResponse listImageFacesResponse = new ListImageFacesResponse();

			listImageFacesResponse.HttpResponse = context.HttpResponse;
			listImageFacesResponse.RequestId = context.StringValue("ListImageFaces.RequestId");
			listImageFacesResponse.NextMarker = context.StringValue("ListImageFaces.NextMarker");

			List<ListImageFacesResponse.ListImageFaces_FacesItem> listImageFacesResponse_faces = new List<ListImageFacesResponse.ListImageFaces_FacesItem>();
			for (int i = 0; i < context.Length("ListImageFaces.Faces.Length"); i++) {
				ListImageFacesResponse.ListImageFaces_FacesItem facesItem = new ListImageFacesResponse.ListImageFaces_FacesItem();
				facesItem.GroupId = context.StringValue("ListImageFaces.Faces["+ i +"].GroupId");
				facesItem.FaceId = context.StringValue("ListImageFaces.Faces["+ i +"].FaceId");
				facesItem.UnGroupReason = context.StringValue("ListImageFaces.Faces["+ i +"].UnGroupReason");

				listImageFacesResponse_faces.Add(facesItem);
			}
			listImageFacesResponse.Faces = listImageFacesResponse_faces;
        
			return listImageFacesResponse;
        }
    }
}