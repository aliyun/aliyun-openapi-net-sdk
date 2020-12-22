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
using Aliyun.Acs.imm.Model.V20170906;

namespace Aliyun.Acs.imm.Transform.V20170906
{
    public class FindSimilarFacesResponseUnmarshaller
    {
        public static FindSimilarFacesResponse Unmarshall(UnmarshallerContext _ctx)
        {
			FindSimilarFacesResponse findSimilarFacesResponse = new FindSimilarFacesResponse();

			findSimilarFacesResponse.HttpResponse = _ctx.HttpResponse;
			findSimilarFacesResponse.RequestId = _ctx.StringValue("FindSimilarFaces.RequestId");

			List<FindSimilarFacesResponse.FindSimilarFaces_FacesItem> findSimilarFacesResponse_faces = new List<FindSimilarFacesResponse.FindSimilarFaces_FacesItem>();
			for (int i = 0; i < _ctx.Length("FindSimilarFaces.Faces.Length"); i++) {
				FindSimilarFacesResponse.FindSimilarFaces_FacesItem facesItem = new FindSimilarFacesResponse.FindSimilarFaces_FacesItem();
				facesItem.FaceId = _ctx.StringValue("FindSimilarFaces.Faces["+ i +"].FaceId");
				facesItem.ImageUri = _ctx.StringValue("FindSimilarFaces.Faces["+ i +"].ImageUri");
				facesItem.Similarity = _ctx.FloatValue("FindSimilarFaces.Faces["+ i +"].Similarity");
				facesItem.ExternalId = _ctx.StringValue("FindSimilarFaces.Faces["+ i +"].ExternalId");

				FindSimilarFacesResponse.FindSimilarFaces_FacesItem.FindSimilarFaces_FaceAttributes faceAttributes = new FindSimilarFacesResponse.FindSimilarFaces_FacesItem.FindSimilarFaces_FaceAttributes();

				FindSimilarFacesResponse.FindSimilarFaces_FacesItem.FindSimilarFaces_FaceAttributes.FindSimilarFaces_FaceBoundary2 faceBoundary2 = new FindSimilarFacesResponse.FindSimilarFaces_FacesItem.FindSimilarFaces_FaceAttributes.FindSimilarFaces_FaceBoundary2();
				faceBoundary2.Left = _ctx.IntegerValue("FindSimilarFaces.Faces["+ i +"].FaceAttributes.FaceBoundary.Left");
				faceBoundary2.Top = _ctx.IntegerValue("FindSimilarFaces.Faces["+ i +"].FaceAttributes.FaceBoundary.Top");
				faceBoundary2.Width = _ctx.IntegerValue("FindSimilarFaces.Faces["+ i +"].FaceAttributes.FaceBoundary.Width");
				faceBoundary2.Height = _ctx.IntegerValue("FindSimilarFaces.Faces["+ i +"].FaceAttributes.FaceBoundary.Height");
				faceAttributes.FaceBoundary2 = faceBoundary2;
				facesItem.FaceAttributes = faceAttributes;

				List<FindSimilarFacesResponse.FindSimilarFaces_FacesItem.FindSimilarFaces_SimilarFacesItem> facesItem_similarFaces = new List<FindSimilarFacesResponse.FindSimilarFaces_FacesItem.FindSimilarFaces_SimilarFacesItem>();
				for (int j = 0; j < _ctx.Length("FindSimilarFaces.Faces["+ i +"].SimilarFaces.Length"); j++) {
					FindSimilarFacesResponse.FindSimilarFaces_FacesItem.FindSimilarFaces_SimilarFacesItem similarFacesItem = new FindSimilarFacesResponse.FindSimilarFaces_FacesItem.FindSimilarFaces_SimilarFacesItem();
					similarFacesItem.FaceId = _ctx.StringValue("FindSimilarFaces.Faces["+ i +"].SimilarFaces["+ j +"].FaceId");
					similarFacesItem.ImageUri = _ctx.StringValue("FindSimilarFaces.Faces["+ i +"].SimilarFaces["+ j +"].ImageUri");
					similarFacesItem.Similarity = _ctx.FloatValue("FindSimilarFaces.Faces["+ i +"].SimilarFaces["+ j +"].Similarity");
					similarFacesItem.ExternalId = _ctx.StringValue("FindSimilarFaces.Faces["+ i +"].SimilarFaces["+ j +"].ExternalId");

					FindSimilarFacesResponse.FindSimilarFaces_FacesItem.FindSimilarFaces_SimilarFacesItem.FindSimilarFaces_FaceAttributes1 faceAttributes1 = new FindSimilarFacesResponse.FindSimilarFaces_FacesItem.FindSimilarFaces_SimilarFacesItem.FindSimilarFaces_FaceAttributes1();

					FindSimilarFacesResponse.FindSimilarFaces_FacesItem.FindSimilarFaces_SimilarFacesItem.FindSimilarFaces_FaceAttributes1.FindSimilarFaces_FaceBoundary faceBoundary = new FindSimilarFacesResponse.FindSimilarFaces_FacesItem.FindSimilarFaces_SimilarFacesItem.FindSimilarFaces_FaceAttributes1.FindSimilarFaces_FaceBoundary();
					faceBoundary.Left = _ctx.IntegerValue("FindSimilarFaces.Faces["+ i +"].SimilarFaces["+ j +"].FaceAttributes.FaceBoundary.Left");
					faceBoundary.Top = _ctx.IntegerValue("FindSimilarFaces.Faces["+ i +"].SimilarFaces["+ j +"].FaceAttributes.FaceBoundary.Top");
					faceBoundary.Width = _ctx.IntegerValue("FindSimilarFaces.Faces["+ i +"].SimilarFaces["+ j +"].FaceAttributes.FaceBoundary.Width");
					faceBoundary.Height = _ctx.IntegerValue("FindSimilarFaces.Faces["+ i +"].SimilarFaces["+ j +"].FaceAttributes.FaceBoundary.Height");
					faceAttributes1.FaceBoundary = faceBoundary;
					similarFacesItem.FaceAttributes1 = faceAttributes1;

					facesItem_similarFaces.Add(similarFacesItem);
				}
				facesItem.SimilarFaces = facesItem_similarFaces;

				findSimilarFacesResponse_faces.Add(facesItem);
			}
			findSimilarFacesResponse.Faces = findSimilarFacesResponse_faces;
        
			return findSimilarFacesResponse;
        }
    }
}
