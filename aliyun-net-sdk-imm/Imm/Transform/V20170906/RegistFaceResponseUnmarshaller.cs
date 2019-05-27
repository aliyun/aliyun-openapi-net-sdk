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
    public class RegistFaceResponseUnmarshaller
    {
        public static RegistFaceResponse Unmarshall(UnmarshallerContext context)
        {
			RegistFaceResponse registFaceResponse = new RegistFaceResponse();

			registFaceResponse.HttpResponse = context.HttpResponse;
			registFaceResponse.RequestId = context.StringValue("RegistFace.RequestId");
			registFaceResponse.GroupId = context.StringValue("RegistFace.GroupId");
			registFaceResponse.ImageUri = context.StringValue("RegistFace.ImageUri");
			registFaceResponse.ImageMd5 = context.StringValue("RegistFace.ImageMd5");
			registFaceResponse.ImageId = context.StringValue("RegistFace.ImageId");
			registFaceResponse.GroupName = context.StringValue("RegistFace.GroupName");
			registFaceResponse.User = context.StringValue("RegistFace.User");
			registFaceResponse.Roll = context.FloatValue("RegistFace.Roll");
			registFaceResponse.FaceId = context.StringValue("RegistFace.FaceId");
			registFaceResponse.Yaw = context.FloatValue("RegistFace.Yaw");
			registFaceResponse.Quality = context.FloatValue("RegistFace.Quality");
			registFaceResponse.Glasses = context.IntegerValue("RegistFace.Glasses");
			registFaceResponse.Hat = context.IntegerValue("RegistFace.Hat");
			registFaceResponse.Pitch = context.FloatValue("RegistFace.Pitch");
			registFaceResponse.Age = context.IntegerValue("RegistFace.Age");
			registFaceResponse.Gender = context.StringValue("RegistFace.Gender");

			List<string> registFaceResponse_axis = new List<string>();
			for (int i = 0; i < context.Length("RegistFace.Axis.Length"); i++) {
				registFaceResponse_axis.Add(context.StringValue("RegistFace.Axis["+ i +"]"));
			}
			registFaceResponse.Axis = registFaceResponse_axis;
        
			return registFaceResponse;
        }
    }
}
