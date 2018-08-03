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
    public class FaceRegistResponseUnmarshaller
    {
        public static FaceRegistResponse Unmarshall(UnmarshallerContext context)
        {
			FaceRegistResponse faceRegistResponse = new FaceRegistResponse();

			faceRegistResponse.HttpResponse = context.HttpResponse;
			faceRegistResponse.RequestId = context.StringValue("FaceRegist.RequestId");
			faceRegistResponse.GroupId = context.StringValue("FaceRegist.GroupId");
			faceRegistResponse.ImageUrl = context.StringValue("FaceRegist.ImageUrl");
			faceRegistResponse.ImageMd5 = context.StringValue("FaceRegist.ImageMd5");
			faceRegistResponse.ImageId = context.StringValue("FaceRegist.ImageId");
			faceRegistResponse.GroupName = context.StringValue("FaceRegist.GroupName");
			faceRegistResponse.User = context.StringValue("FaceRegist.User");
			faceRegistResponse.Roll = context.FloatValue("FaceRegist.Roll");
			faceRegistResponse.FaceId = context.StringValue("FaceRegist.FaceId");
			faceRegistResponse.Yaw = context.StringValue("FaceRegist.Yaw");
			faceRegistResponse.Quality = context.FloatValue("FaceRegist.Quality");
			faceRegistResponse.Glasses = context.IntegerValue("FaceRegist.Glasses");
			faceRegistResponse.Hat = context.IntegerValue("FaceRegist.Hat");
			faceRegistResponse.Pitch = context.FloatValue("FaceRegist.Pitch");
			faceRegistResponse.Age = context.IntegerValue("FaceRegist.Age");
			faceRegistResponse.Gender = context.StringValue("FaceRegist.Gender");

			List<string> faceRegistResponse_axis = new List<string>();
			for (int i = 0; i < context.Length("FaceRegist.Axis.Length"); i++) {
				faceRegistResponse_axis.Add(context.StringValue("FaceRegist.Axis["+ i +"]"));
			}
			faceRegistResponse.Axis = faceRegistResponse_axis;
        
			return faceRegistResponse;
        }
    }
}