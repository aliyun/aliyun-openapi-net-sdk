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
using Aliyun.Acs.ivision.Model.V20190308;

namespace Aliyun.Acs.ivision.Transform.V20190308
{
    public class RegisterFaceResponseUnmarshaller
    {
        public static RegisterFaceResponse Unmarshall(UnmarshallerContext context)
        {
			RegisterFaceResponse registerFaceResponse = new RegisterFaceResponse();

			registerFaceResponse.HttpResponse = context.HttpResponse;
			registerFaceResponse.RequestId = context.StringValue("RegisterFace.RequestId");
			registerFaceResponse.GroupId = context.StringValue("RegisterFace.GroupId");

			List<RegisterFaceResponse.RegisterFace_Face> registerFaceResponse_faces = new List<RegisterFaceResponse.RegisterFace_Face>();
			for (int i = 0; i < context.Length("RegisterFace.Faces.Length"); i++) {
				RegisterFaceResponse.RegisterFace_Face face = new RegisterFaceResponse.RegisterFace_Face();
				face.FaceToken = context.StringValue("RegisterFace.Faces["+ i +"].FaceToken");

				RegisterFaceResponse.RegisterFace_Face.RegisterFace_Rect rect = new RegisterFaceResponse.RegisterFace_Face.RegisterFace_Rect();
				rect.Left = context.IntegerValue("RegisterFace.Faces["+ i +"].Rect.Left");
				rect.Top = context.IntegerValue("RegisterFace.Faces["+ i +"].Rect.Top");
				rect.Width = context.IntegerValue("RegisterFace.Faces["+ i +"].Rect.Width");
				rect.Height = context.IntegerValue("RegisterFace.Faces["+ i +"].Rect.Height");
				face.Rect = rect;

				registerFaceResponse_faces.Add(face);
			}
			registerFaceResponse.Faces = registerFaceResponse_faces;
        
			return registerFaceResponse;
        }
    }
}
