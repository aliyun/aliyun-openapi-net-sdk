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
        public static RegisterFaceResponse Unmarshall(UnmarshallerContext _ctx)
        {
			RegisterFaceResponse registerFaceResponse = new RegisterFaceResponse();

			registerFaceResponse.HttpResponse = _ctx.HttpResponse;
			registerFaceResponse.RequestId = _ctx.StringValue("RegisterFace.RequestId");
			registerFaceResponse.GroupId = _ctx.StringValue("RegisterFace.GroupId");

			List<RegisterFaceResponse.RegisterFace_Face> registerFaceResponse_faces = new List<RegisterFaceResponse.RegisterFace_Face>();
			for (int i = 0; i < _ctx.Length("RegisterFace.Faces.Length"); i++) {
				RegisterFaceResponse.RegisterFace_Face face = new RegisterFaceResponse.RegisterFace_Face();
				face.FaceToken = _ctx.StringValue("RegisterFace.Faces["+ i +"].FaceToken");

				RegisterFaceResponse.RegisterFace_Face.RegisterFace_Rect rect = new RegisterFaceResponse.RegisterFace_Face.RegisterFace_Rect();
				rect.Top = _ctx.IntegerValue("RegisterFace.Faces["+ i +"].Rect.Top");
				rect.Width = _ctx.IntegerValue("RegisterFace.Faces["+ i +"].Rect.Width");
				rect.Height = _ctx.IntegerValue("RegisterFace.Faces["+ i +"].Rect.Height");
				rect.Left = _ctx.IntegerValue("RegisterFace.Faces["+ i +"].Rect.Left");
				face.Rect = rect;

				registerFaceResponse_faces.Add(face);
			}
			registerFaceResponse.Faces = registerFaceResponse_faces;
        
			return registerFaceResponse;
        }
    }
}
