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
    public class GetFaceSearchImageResponseUnmarshaller
    {
        public static GetFaceSearchImageResponse Unmarshall(UnmarshallerContext context)
        {
			GetFaceSearchImageResponse getFaceSearchImageResponse = new GetFaceSearchImageResponse();

			getFaceSearchImageResponse.HttpResponse = context.HttpResponse;
			getFaceSearchImageResponse.RequestId = context.StringValue("GetFaceSearchImage.RequestId");
			getFaceSearchImageResponse.GroupName = context.StringValue("GetFaceSearchImage.GroupName");
			getFaceSearchImageResponse.GroupId = context.StringValue("GetFaceSearchImage.GroupId");
			getFaceSearchImageResponse.Gender = context.StringValue("GetFaceSearchImage.Gender");
			getFaceSearchImageResponse.Age = context.IntegerValue("GetFaceSearchImage.Age");
			getFaceSearchImageResponse.Pitch = context.FloatValue("GetFaceSearchImage.Pitch");
			getFaceSearchImageResponse.ImageUri = context.StringValue("GetFaceSearchImage.ImageUri");
			getFaceSearchImageResponse.ImageMd5 = context.StringValue("GetFaceSearchImage.ImageMd5");
			getFaceSearchImageResponse.Roll = context.FloatValue("GetFaceSearchImage.Roll");
			getFaceSearchImageResponse.FaceId = context.StringValue("GetFaceSearchImage.FaceId");
			getFaceSearchImageResponse.Yaw = context.FloatValue("GetFaceSearchImage.Yaw");
			getFaceSearchImageResponse.Quality = context.FloatValue("GetFaceSearchImage.Quality");
			getFaceSearchImageResponse.Hat = context.IntegerValue("GetFaceSearchImage.Hat");
			getFaceSearchImageResponse.Glasses = context.IntegerValue("GetFaceSearchImage.Glasses");
			getFaceSearchImageResponse.ImageId = context.StringValue("GetFaceSearchImage.ImageId");
			getFaceSearchImageResponse.User = context.StringValue("GetFaceSearchImage.User");

			List<string> getFaceSearchImageResponse_axis = new List<string>();
			for (int i = 0; i < context.Length("GetFaceSearchImage.Axis.Length"); i++) {
				getFaceSearchImageResponse_axis.Add(context.StringValue("GetFaceSearchImage.Axis["+ i +"]"));
			}
			getFaceSearchImageResponse.Axis = getFaceSearchImageResponse_axis;
        
			return getFaceSearchImageResponse;
        }
    }
}