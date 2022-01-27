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
    public class CompareImageFacesResponseUnmarshaller
    {
        public static CompareImageFacesResponse Unmarshall(UnmarshallerContext _ctx)
        {
			CompareImageFacesResponse compareImageFacesResponse = new CompareImageFacesResponse();

			compareImageFacesResponse.HttpResponse = _ctx.HttpResponse;
			compareImageFacesResponse.RequestId = _ctx.StringValue("CompareImageFaces.RequestId");
			compareImageFacesResponse.SetId = _ctx.StringValue("CompareImageFaces.SetId");
			compareImageFacesResponse.Similarity = _ctx.FloatValue("CompareImageFaces.Similarity");

			CompareImageFacesResponse.CompareImageFaces_FaceA faceA = new CompareImageFacesResponse.CompareImageFaces_FaceA();
			faceA.FaceId = _ctx.StringValue("CompareImageFaces.FaceA.FaceId");

			CompareImageFacesResponse.CompareImageFaces_FaceA.CompareImageFaces_FaceAttributes faceAttributes = new CompareImageFacesResponse.CompareImageFaces_FaceA.CompareImageFaces_FaceAttributes();

			CompareImageFacesResponse.CompareImageFaces_FaceA.CompareImageFaces_FaceAttributes.CompareImageFaces_FaceBoundary faceBoundary = new CompareImageFacesResponse.CompareImageFaces_FaceA.CompareImageFaces_FaceAttributes.CompareImageFaces_FaceBoundary();
			faceBoundary.Left = _ctx.IntegerValue("CompareImageFaces.FaceA.FaceAttributes.FaceBoundary.Left");
			faceBoundary.Top = _ctx.IntegerValue("CompareImageFaces.FaceA.FaceAttributes.FaceBoundary.Top");
			faceBoundary.Width = _ctx.IntegerValue("CompareImageFaces.FaceA.FaceAttributes.FaceBoundary.Width");
			faceBoundary.Height = _ctx.IntegerValue("CompareImageFaces.FaceA.FaceAttributes.FaceBoundary.Height");
			faceAttributes.FaceBoundary = faceBoundary;
			faceA.FaceAttributes = faceAttributes;
			compareImageFacesResponse.FaceA = faceA;

			CompareImageFacesResponse.CompareImageFaces_FaceB faceB = new CompareImageFacesResponse.CompareImageFaces_FaceB();
			faceB.FaceId = _ctx.StringValue("CompareImageFaces.FaceB.FaceId");

			CompareImageFacesResponse.CompareImageFaces_FaceB.CompareImageFaces_FaceAttributes1 faceAttributes1 = new CompareImageFacesResponse.CompareImageFaces_FaceB.CompareImageFaces_FaceAttributes1();

			CompareImageFacesResponse.CompareImageFaces_FaceB.CompareImageFaces_FaceAttributes1.CompareImageFaces_FaceBoundary2 faceBoundary2 = new CompareImageFacesResponse.CompareImageFaces_FaceB.CompareImageFaces_FaceAttributes1.CompareImageFaces_FaceBoundary2();
			faceBoundary2.Left = _ctx.IntegerValue("CompareImageFaces.FaceB.FaceAttributes.FaceBoundary.Left");
			faceBoundary2.Top = _ctx.IntegerValue("CompareImageFaces.FaceB.FaceAttributes.FaceBoundary.Top");
			faceBoundary2.Width = _ctx.IntegerValue("CompareImageFaces.FaceB.FaceAttributes.FaceBoundary.Width");
			faceBoundary2.Height = _ctx.IntegerValue("CompareImageFaces.FaceB.FaceAttributes.FaceBoundary.Height");
			faceAttributes1.FaceBoundary2 = faceBoundary2;
			faceB.FaceAttributes1 = faceAttributes1;
			compareImageFacesResponse.FaceB = faceB;
        
			return compareImageFacesResponse;
        }
    }
}
