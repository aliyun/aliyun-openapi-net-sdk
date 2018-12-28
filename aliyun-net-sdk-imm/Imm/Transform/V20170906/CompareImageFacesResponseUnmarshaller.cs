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
    public class CompareImageFacesResponseUnmarshaller
    {
        public static CompareImageFacesResponse Unmarshall(UnmarshallerContext context)
        {
			CompareImageFacesResponse compareImageFacesResponse = new CompareImageFacesResponse();

			compareImageFacesResponse.HttpResponse = context.HttpResponse;
			compareImageFacesResponse.RequestId = context.StringValue("CompareImageFaces.RequestId");
			compareImageFacesResponse.SetId = context.StringValue("CompareImageFaces.SetId");
			compareImageFacesResponse.Similarity = context.FloatValue("CompareImageFaces.Similarity");

			CompareImageFacesResponse.CompareImageFaces_FaceA faceA = new CompareImageFacesResponse.CompareImageFaces_FaceA();
			faceA.FaceId = context.StringValue("CompareImageFaces.FaceA.FaceId");

			CompareImageFacesResponse.CompareImageFaces_FaceA.CompareImageFaces_FaceAttributes faceAttributes = new CompareImageFacesResponse.CompareImageFaces_FaceA.CompareImageFaces_FaceAttributes();

			CompareImageFacesResponse.CompareImageFaces_FaceA.CompareImageFaces_FaceAttributes.CompareImageFaces_FaceBoundary faceBoundary = new CompareImageFacesResponse.CompareImageFaces_FaceA.CompareImageFaces_FaceAttributes.CompareImageFaces_FaceBoundary();
			faceBoundary.Left = context.IntegerValue("CompareImageFaces.FaceA.FaceAttributes.FaceBoundary.Left");
			faceBoundary.Top = context.IntegerValue("CompareImageFaces.FaceA.FaceAttributes.FaceBoundary.Top");
			faceBoundary.Width = context.IntegerValue("CompareImageFaces.FaceA.FaceAttributes.FaceBoundary.Width");
			faceBoundary.Height = context.IntegerValue("CompareImageFaces.FaceA.FaceAttributes.FaceBoundary.Height");
			faceAttributes.FaceBoundary = faceBoundary;
			faceA.FaceAttributes = faceAttributes;
			compareImageFacesResponse.FaceA = faceA;

			CompareImageFacesResponse.CompareImageFaces_FaceB faceB = new CompareImageFacesResponse.CompareImageFaces_FaceB();
			faceB.FaceId = context.StringValue("CompareImageFaces.FaceB.FaceId");

			CompareImageFacesResponse.CompareImageFaces_FaceB.CompareImageFaces_FaceAttributes1 faceAttributes1 = new CompareImageFacesResponse.CompareImageFaces_FaceB.CompareImageFaces_FaceAttributes1();

			CompareImageFacesResponse.CompareImageFaces_FaceB.CompareImageFaces_FaceAttributes1.CompareImageFaces_FaceBoundary2 faceBoundary2 = new CompareImageFacesResponse.CompareImageFaces_FaceB.CompareImageFaces_FaceAttributes1.CompareImageFaces_FaceBoundary2();
			faceBoundary2.Left = context.IntegerValue("CompareImageFaces.FaceB.FaceAttributes.FaceBoundary.Left");
			faceBoundary2.Top = context.IntegerValue("CompareImageFaces.FaceB.FaceAttributes.FaceBoundary.Top");
			faceBoundary2.Width = context.IntegerValue("CompareImageFaces.FaceB.FaceAttributes.FaceBoundary.Width");
			faceBoundary2.Height = context.IntegerValue("CompareImageFaces.FaceB.FaceAttributes.FaceBoundary.Height");
			faceAttributes1.FaceBoundary2 = faceBoundary2;
			faceB.FaceAttributes1 = faceAttributes1;
			compareImageFacesResponse.FaceB = faceB;
        
			return compareImageFacesResponse;
        }
    }
}